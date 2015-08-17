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

        protected IndexArea indexArea;
        protected byte[] _data;
        protected int index;


        public PacketData(WP6Document document, int prefixID)
        {
            _data = document.data;
            if (prefixID > 0)
            {
                indexArea = document.indexAreas[prefixID];
                index = indexArea.dataPacketPointer;
                if (indexArea.flags.HasFlag(IndexFlags.childPacketIDs))
                {
                    childIDCount = BitConverter.ToInt16(_data, index);
                    childID = new short[childIDCount];
                    index += 2;
                    for (int i = 0; i < childIDCount; i++)
                    {
                        childID[i] = BitConverter.ToInt16(_data, index);
                        index += 2;
                    }
                }
                if (indexArea.flags.HasFlag(IndexFlags.WP_character_set_mapped_text))
                {
                    numTextBlocks = BitConverter.ToInt16(_data, index);
                    index += 2;
                    firstBlockOffset = BitConverter.ToInt32(_data, index);
                    index += 4;
                    sizeofBlock = new int[numTextBlocks];
                    for (int i = 0; i < sizeofBlock.Length; i++)
                    {
                        sizeofBlock[i] = BitConverter.ToInt32(_data, index);
                        index += 4;
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
            int endofPacket = indexArea.dataPacketPointer + indexArea.sizeOfDataPacket;
            int sizeofPacket = indexArea.sizeOfDataPacket;
            byte lowByte, highByte;
            bool nullTerminator = false;
            while (!nullTerminator && index <= endofPacket)
            {
                lowByte = _data[index];
                highByte = _data[index + 1];
                if (lowByte == 0 && highByte == 0)
                {
                    index +=2;
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
                index += 2;

            }
            //for (int i = index; i < (index + sizeofPacket - 2); i+=2)
            //{
            //    lowByte = _data[i];
            //    highByte = _data[i + 1];
            //    if (highByte == 0 && lowByte < 127)
            //    {
            //        WPWordString += (char)lowByte;
            //    }
            //    else if (highByte > 0 && highByte < 15)
            //    {
            //        WPWordString += new ExtendedCharacter(highByte, lowByte).content;   // call alternate constructor for 
            //                                                                            //  ExtendedCharacter to get Unicode value.
            //    }
            //}
                return WPWordString;
        }
    }
}
