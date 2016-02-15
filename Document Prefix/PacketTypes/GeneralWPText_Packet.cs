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
                Array.Copy(_data, dataIndex, currentTextBlock, 0, currentTextBlock.Length);
                packetText[i] = new DocumentArea(document, dataIndex, currentTextBlock.Length + dataIndex);
                dataIndex += sizeofBlock[i];
            }
        }
    }
}
