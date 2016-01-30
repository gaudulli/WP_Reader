using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WP_Reader {
    public class IndexArea {
        public IndexFlags flags { get; set; }
        public byte packetType { get; set; }
        public short packetUseCount { get; set; }
        public short hiddenCount { get; set; }
        public int sizeOfDataPacket { get; set; }
        public int dataPacketPointer { get; set; }




        //public DataPacket dataPacket { get; set; }

        public IndexArea(byte[] data, int startIndex) {
            parseIndexArea(data, startIndex);
        }

        public void parseIndexArea(byte[] data, int startIndex) {

            flags = (IndexFlags)data[startIndex];
            packetType = data[startIndex + 1];
            packetUseCount = BitConverter.ToInt16(data, startIndex + 2);
            hiddenCount = BitConverter.ToInt16(data, startIndex + 4);
            sizeOfDataPacket = BitConverter.ToInt32(data, startIndex + 6);
            dataPacketPointer = BitConverter.ToInt32(data, startIndex + 10);
            //if (sizeOfDataPacket > 0) {
            //    dataPacket = new DataPacket(data, dataPacketPointer, sizeOfDataPacket);
            //}
        }
        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Index Area: ");
            //sb.AppendLine("\tFlags: " + flags);
            sb.AppendLine("\tPacketType: " + packetType);
            sb.AppendLine("\tPacketUseCount: " + packetUseCount);
            sb.AppendLine("\tHiddenCount: " + hiddenCount);
            sb.AppendLine("\tSizeOfDataPacket: " + sizeOfDataPacket);
            sb.AppendLine("\tDataPacketPointer: " + dataPacketPointer);
            //if (dataPacket != null) {
            //    sb.AppendLine("\t" + dataPacket.ToString());
            //}
            return sb.ToString();
        }
    }
}
