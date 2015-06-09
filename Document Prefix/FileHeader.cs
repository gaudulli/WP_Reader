using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WP_Reader {
    public class FileHeader {
        public int ptrDocumentArea { get; set; }
        public byte productType { get; set; }
        public byte fileType { get; set; }
        public byte majorVersion { get; set; }
        public byte minorVersion { get; set; }
        public short encryption { get; set; }
        public short ptrIndexArea { get; set; }
        public byte[] extendedReserve { get; set; }
        public int fileSize { get; set; }


        public FileHeader(byte[] data) {
            parseFileHeader(data);
        }

        public void parseFileHeader(byte[] data) {
            //Check to make sure first 4 bytes are correct for a word perfect document.
            if (data[0] != 0xFF || data[1] != 0x57 || data[2] != 0x50 || data[3] != 0x43) {
                throw new Exception("InvalidFileID");
            }

            ptrDocumentArea = BitConverter.ToInt32(data, 4);

            productType = data[8];

            fileType = data[9];

            majorVersion = data[10];

            minorVersion = data[11];

            encryption = BitConverter.ToInt16(data, 12);

            ptrIndexArea = BitConverter.ToInt16(data, 14);

            extendedReserve = new byte[4];

            extendedReserve[0] = data[16];
            extendedReserve[1] = data[17];
            extendedReserve[2] = data[18];
            extendedReserve[3] = data[19];

            fileSize = BitConverter.ToInt32(data, 20);


        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("File Header: ");
            sb.AppendLine("\tDocument Area: " + ptrDocumentArea);
            sb.AppendLine("\tProduct Type: " + productType);
            sb.AppendLine("\tFile Type: " + fileType);
            sb.AppendLine("\tMajor Version: " + majorVersion);
            sb.AppendLine("\tMinor Version: " + minorVersion);
            sb.AppendLine("\tEncryption: " + encryption);
            sb.AppendLine("\tIndex Area Pointer: " + ptrIndexArea);
            sb.AppendLine("\tReserve1: " + extendedReserve[0]);
            sb.AppendLine("\tReserve2: " + extendedReserve[1]);
            sb.AppendLine("\tReserve3: " + extendedReserve[2]);
            sb.AppendLine("\tReserve4: " + extendedReserve[3]);
            sb.AppendLine("\tFile Size: " + fileSize);

            return sb.ToString();
        }
    }
}
