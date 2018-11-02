using System;
using System.IO;
using System.Windows.Forms;
using System.Management;

namespace PS3_ELF_Editor {
    public partial class Form1 : Form {
        public static byte[] ELF = null;

        public Form1() {
            InitializeComponent();
        }

        private void refreshDataGrid() {
            dataGridView1.Rows.Clear();

            if(ELF != null) {
                ushort rowCount = PS3ELF.GetSegmentCount(ELF);

                for(int i = 1; i <= rowCount; i++) {
                    string segNum = i.ToString();
                    string segStart = "0x" + PS3ELF.GetBase(ELF, i).ToString("X");
                    string segEnd = "0x" + (PS3ELF.GetBase(ELF, i) + PS3ELF.GetSize(ELF, i)).ToString("X");
                    string segSize = "0x" + PS3ELF.GetSize(ELF, i).ToString("X");

                    ulong segmentFlags = PS3ELF.GetFlags(ELF, i);
                    bool segRead = (segmentFlags & PS3ELF.SEGMENT_FLAGS.PROT_READ) != 0;
                    bool segWrite = (segmentFlags & PS3ELF.SEGMENT_FLAGS.PROT_WRITE) != 0;
                    bool segExec = (segmentFlags & PS3ELF.SEGMENT_FLAGS.PROT_EXEC) != 0;

                    dataGridView1.Rows.Add(new object[] { segNum, segStart, segEnd, segSize, segRead, segWrite, segExec });
                }
            }
        }

        private void loadElfFileButton_Click(object sender, EventArgs e) {
            string filePath = "";

            try {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "ELF Files|*.elf";
                openFileDialog1.Title = "Select a File";

                if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                    filePath = openFileDialog1.FileName;
                }
            }
            catch {
                MessageBox.Show("Unable to load file");
            }

            if(!filePath.Equals("")) {
                ELF = File.ReadAllBytes(filePath);
                label1.Text = "ELF: " + filePath;
            }
            else {
                ELF = null;
                label1.Text = "ELF: None";
            }

            refreshDataGrid();
        }

        private void saveELF() {
            
        }

        private void saveAsElfFileButton_Click(object sender, EventArgs e) {
            ushort rowCount = PS3ELF.GetSegmentCount(ELF);

            for (int i = 1; i <= rowCount; i++) {
                ulong segFlags = 0;

                if ((bool)dataGridView1.Rows[i - 1].Cells[4].Value)
                    segFlags |= PS3ELF.SEGMENT_FLAGS.PROT_READ;

                if ((bool)dataGridView1.Rows[i - 1].Cells[5].Value)
                    segFlags |= PS3ELF.SEGMENT_FLAGS.PROT_WRITE;

                if ((bool)dataGridView1.Rows[i - 1].Cells[6].Value)
                    segFlags |= PS3ELF.SEGMENT_FLAGS.PROT_EXEC;

                PS3ELF.SetFlags(ELF, i, segFlags);
            }

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "EBOOT.ELF";
            savefile.Filter = "ELF Files|*.elf";

            if (savefile.ShowDialog() == DialogResult.OK) {
                File.WriteAllBytes(savefile.FileName, ELF);
            }
        }

        private void saveAsEbootButton_Click(object sender, EventArgs e) {
            ushort rowCount = PS3ELF.GetSegmentCount(ELF);

            for (int i = 1; i <= rowCount; i++) {
                ulong segFlags = 0;

                if ((bool)dataGridView1.Rows[i - 1].Cells[4].Value)
                    segFlags |= PS3ELF.SEGMENT_FLAGS.PROT_READ;

                if ((bool)dataGridView1.Rows[i - 1].Cells[5].Value)
                    segFlags |= PS3ELF.SEGMENT_FLAGS.PROT_WRITE;

                if ((bool)dataGridView1.Rows[i - 1].Cells[6].Value)
                    segFlags |= PS3ELF.SEGMENT_FLAGS.PROT_EXEC;

                PS3ELF.SetFlags(ELF, i, segFlags);
            }

            File.WriteAllBytes("EBOOT.ELF", ELF);

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.WorkingDirectory = System.IO.Directory.GetCurrentDirectory();
            startInfo.FileName = @"C:\Windows\System32\cmd.exe";
            startInfo.Arguments = "/c make_fself.exe EBOOT.ELF EBOOT.BIN";
            process.StartInfo = startInfo;
            process.Start();

            System.Threading.Thread.Sleep(500);

            byte[] EBOOT = File.ReadAllBytes("EBOOT.BIN");

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "EBOOT.BIN";
            savefile.Filter = "BIN Files|*.bin";

            if (savefile.ShowDialog() == DialogResult.OK) {
                File.WriteAllBytes(savefile.FileName, EBOOT);
            }

            File.Delete("EBOOT.BIN");
            File.Delete("EBOOT.ELF");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            for(int i = 0; i < dataGridView1.Rows.Count; i++) {
                dataGridView1.Rows[i].Cells[4].Value = checkBox1.Checked;
                dataGridView1.Rows[i].Cells[5].Value = checkBox1.Checked;
                dataGridView1.Rows[i].Cells[6].Value = checkBox1.Checked;
            }
        }
    }
}
