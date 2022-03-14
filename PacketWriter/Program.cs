using System;
using System.IO;

namespace PacketWriter
{
    public class PacketWriter : BinaryWriter
    {
        private MemoryStream _ms;

        public PacketWriter()
            : base()
        {
            _ms = new MemoryStream();
            OutStream = _ms;
        }

        public byte[] GetBytes()
        {
            Close();

            byte[] data = _ms.ToArray();


        }
    }
}
