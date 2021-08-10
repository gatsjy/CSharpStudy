using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

namespace SupportCompressionEncryption
{
    // 뭔말인지 모르겠지만.. 맛만보자..후;;
    class SupportsCompressionEncryption
    {
        const int SupportCompression = 0x10;
        const int SupportEncryption = 0x20000;

        [DllImport("Kernel32.dll", SetLastError = true)]
        extern static bool GetVolumeInformation(string vol, StringBuilder name,
            int nameSize, out uint serialNum, out uint maxNameLen, out uint flags,
            StringBuilder fileSysName, int fileSysNameSize);
        static void Main(string[] args)
        {
            uint serialNum, maxNameLen, flags;
            bool ok = GetVolumeInformation(@"C:\", null, 0, out serialNum, out maxNameLen, out flags, null, 0);

            if (!ok)
                throw new Win32Exception();

            bool canCompress = (flags & SupportCompression) != 0;
            bool canEncrypt = (flags & SupportEncryption) != 0;
        }
    }
}
