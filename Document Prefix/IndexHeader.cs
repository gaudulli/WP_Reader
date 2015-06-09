using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WP_Reader {
    public class IndexHeader {

        public byte flags { get; set; }
        public int indexCount { get; set; }



        public IndexHeader(byte[] data, int startIndex) {
            parseIndexHeader(data, startIndex);
        }
        public void parseIndexHeader(byte[] data, int startIndex){
            flags = data[startIndex];
            indexCount = BitConverter.ToUInt16(data,startIndex+2);
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("IndexHeader:");
            sb.AppendLine("\tFlags: " + flags);
            sb.AppendLine("\tIndexCount: " + indexCount);

            return sb.ToString();
        }
    }
}
