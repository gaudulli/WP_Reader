using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
     public class PacketData
    {

        public short childIDCount { get; set; }
        public short[] childID { get; set; }

        public short numTextBlocks { get; set; }
        public int firstBlockOffset { get; set; }
        public int[] sizeofBlock { get; set; }

        protected Index index;
        protected byte[] _data;
        protected int dataIndex;


        public PacketData(WP6Document document, int prefixID)
        {
            _data = document.data;
            if (prefixID > 0)
            {
                index = document.indexArea.indexes[prefixID];
                dataIndex = index.dataPacketPointer;
                if (index.flags.HasFlag(IndexFlags.childPacketIDs))
                {
                    childIDCount = BitConverter.ToInt16(_data, dataIndex);
                    childID = new short[childIDCount];
                    dataIndex += 2;
                    for (int i = 0; i < childIDCount; i++)
                    {
                        childID[i] = BitConverter.ToInt16(_data, dataIndex);
                        dataIndex += 2;
                    }
                }
                if (index.flags.HasFlag(IndexFlags.WP_character_set_mapped_text))
                {
                    numTextBlocks = BitConverter.ToInt16(_data, dataIndex);
                    dataIndex += 2;
                    if (numTextBlocks > 0)
                    {
                        firstBlockOffset = BitConverter.ToInt32(_data, dataIndex);
                        dataIndex += 4;
                    }
                    sizeofBlock = new int[numTextBlocks];
                    for (int i = 0; i < sizeofBlock.Length; i++)
                    {
                        sizeofBlock[i] = BitConverter.ToInt32(_data, dataIndex);
                        dataIndex += 4;
                    }
                }
            }


        }

         /// <summary>
         /// get the Unicode equaivalent of a "WP Word String",
         /// which matches the Extended Character functionality
         /// </summary>
         /// <returns></returns>
        protected string getWPWordString()
        {
            string WPWordString = "";
            int endofPacket = index.dataPacketPointer + index.sizeOfDataPacket -1;
            int sizeofPacket = index.sizeOfDataPacket;
            byte lowByte, highByte;
            bool nullTerminator = false;
            while (!nullTerminator && dataIndex <= endofPacket)
            {
                lowByte = _data[dataIndex];
                highByte = _data[dataIndex + 1];
                if (lowByte == 0 && highByte == 0)
                {
                    dataIndex +=2;
                    return WPWordString;
                }
                else if (highByte == 0 && lowByte < 127)
                {
                    WPWordString += (char)lowByte;
                }
                else if (highByte > 0 && highByte < 15)
                {
                    WPWordString += new ExtendedCharacter(highByte, lowByte).content;   // call alternate constructor for 
                    //  ExtendedCharacter to get Unicode value.
                }
                dataIndex += 2;

            }
                return WPWordString;
        }
    }
}
