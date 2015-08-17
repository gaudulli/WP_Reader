using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    // Parses Packet Type 8, WP General Text
    // The text of each block is returned as a parsed DocumentArea
    public class GeneralWPText_Packet: PacketData
    {
        public DocumentArea[] packetText { get; set; }


        public GeneralWPText_Packet(WP6Document document, int prefixID): 
            base (document, prefixID)
        {
            packetText = new DocumentArea[numTextBlocks];
            for (int i = 0; i < numTextBlocks; i++)
            {
                byte[] currentTextBlock = new byte[sizeofBlock[i]];
                Array.Copy(_data, index, currentTextBlock, 0, currentTextBlock.Length);
                packetText[i] = new DocumentArea(document, index, currentTextBlock.Length + index);
                index += sizeofBlock[i];
            }
        }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine("GeneralWPText_Packet");
        //    sb.AppendLine("\tnumTextBlocks:  " + numTextBlocks);
        //    sb.AppendLine("\tfirstBlockOffset: " + firstBlockOffset);
        //    for (int i = 0; i < sizeofBlock.Length; i++)
        //    {
        //        sb.AppendLine(string.Format("\tSize of Text Block {0} {1}", i+1, sizeofBlock[i]));
        //        foreach (WPToken j in packetText[i].WPStream)
        //        {
        //            Type itype = j.GetType();
        //            if (itype == typeof(Character))
        //            {
        //                sb.Append(j.name.ToString());
        //            }
        //            else
        //            {
        //                //string str = " ";
        //                string str = " [" + j.name.ToString() + "] ";
        //                sb.Append(str);
        //            }
        //        }
        //    }

        //    return sb.ToString();
        //}

    }
}
