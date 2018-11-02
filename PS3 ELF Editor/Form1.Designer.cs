namespace PS3_ELF_Editor {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SegmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadProtectionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.WriteProtectionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExecuteProtectionColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load ELF File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.loadElfFileButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save as ELF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.saveAsElfFileButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Save as EBOOT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.saveAsEbootButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SegmentColumn,
            this.StartAddressColumn,
            this.EndAddressColumn,
            this.SizeColumn,
            this.ReadProtectionColumn,
            this.WriteProtectionColumn,
            this.ExecuteProtectionColumn});
            this.dataGridView1.Location = new System.Drawing.Point(13, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(457, 395);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ELF: None";
            // 
            // SegmentColumn
            // 
            this.SegmentColumn.HeaderText = "#";
            this.SegmentColumn.Name = "SegmentColumn";
            this.SegmentColumn.ReadOnly = true;
            this.SegmentColumn.Width = 20;
            // 
            // StartAddressColumn
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.StartAddressColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.StartAddressColumn.HeaderText = "Start Address";
            this.StartAddressColumn.Name = "StartAddressColumn";
            this.StartAddressColumn.ReadOnly = true;
            this.StartAddressColumn.Width = 95;
            // 
            // EndAddressColumn
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.EndAddressColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.EndAddressColumn.HeaderText = "End Address";
            this.EndAddressColumn.Name = "EndAddressColumn";
            this.EndAddressColumn.ReadOnly = true;
            this.EndAddressColumn.Width = 95;
            // 
            // SizeColumn
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SizeColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.SizeColumn.HeaderText = "Size";
            this.SizeColumn.Name = "SizeColumn";
            this.SizeColumn.ReadOnly = true;
            this.SizeColumn.Width = 75;
            // 
            // ReadProtectionColumn
            // 
            this.ReadProtectionColumn.HeaderText = "READ";
            this.ReadProtectionColumn.Name = "ReadProtectionColumn";
            this.ReadProtectionColumn.Width = 50;
            // 
            // WriteProtectionColumn
            // 
            this.WriteProtectionColumn.HeaderText = "WRITE";
            this.WriteProtectionColumn.Name = "WriteProtectionColumn";
            this.WriteProtectionColumn.Width = 50;
            // 
            // ExecuteProtectionColumn
            // 
            this.ExecuteProtectionColumn.HeaderText = "EXEC";
            this.ExecuteProtectionColumn.Name = "ExecuteProtectionColumn";
            this.ExecuteProtectionColumn.Width = 50;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(328, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Select All Protections";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 466);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "PS3 ELF Segment Protection Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ReadProtectionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn WriteProtectionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExecuteProtectionColumn;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

