using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    //Parses Packet Type 7
    public class NativeFileNamePacket: PacketData
    {
        public string filename { get; set; }
        public short[] childIDTag { get; set; }


        public NativeFileNamePacket(WP6Document document, int prefixID) :
            base(document, prefixID)
        {

            if (prefixID > 0)   // test to see if there actually is a prefixID associated with the calling function
            {
                if (index.flags.HasFlag(IndexFlags.childPacketIDs))
                {
                    childIDTag = new short[childIDCount];
                    for (int i = 0; i < childIDCount; i++)
                    {
                        childIDTag[i] = BitConverter.ToInt16(_data, dataIndex);
                    }
                }
                else
                {
                    filename = getWPWordString();
                }
            }
            else
            {
                filename = "";
            }


        }


    }
}
