using System;
using System.Runtime.InteropServices;

namespace PS3_ELF_Editor {
    class PS3ELF {
        public class SEGMENT_FLAGS {
            public static ulong PROT_READ = 0x2;
            public static ulong PROT_WRITE = 0x1;
            public static ulong PROT_EXEC = 0x4;
        };

        [DllImport("PS3ELF.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern ulong GetSegmentBase(byte[] buffer, int segNum);

        [DllImport("PS3ELF.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern ulong GetSegmentSize(byte[] buffer, int segNum);

        [DllImport("PS3ELF.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern ulong GetSegmentAttr(byte[] buffer, int segNum);

        [DllImport("PS3ELF.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void SetSegmentAttr(byte[] buffer, int segNum, ulong flags);

        [DllImport("PS3ELF.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort GetSegmentCount(byte[] buffer);

        public static ulong GetBase(byte[] buffer, int segmentNum) {
            return GetSegmentBase(buffer, segmentNum); 
        }

        public static ulong GetSize(byte[] buffer, int segmentNum) {
            return GetSegmentSize(buffer, segmentNum);
        }

        public static ulong GetFlags(byte[] buffer, int segmentNum) {
            return GetSegmentAttr(buffer, segmentNum);
        }

        public static void SetFlags(byte[] buffer, int segmentNum, ulong flags) {
            SetSegmentAttr(buffer, segmentNum, flags);
        }
    }
}
