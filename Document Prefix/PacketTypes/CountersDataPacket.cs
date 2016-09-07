using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class CountersDataPacket:PacketData
    {

        public string name { get; set; }
        public int numberOfCounterLevelsUsed { get; set; }
        public int[] defaultNumberingMethodForLevel { get; set; }
        public string[] levelName { get; set; }

        public CountersDataPacket(WP6Document document, int prefixID) :
            base(document, prefixID)
        {
            if (prefixID > -1)
            {
                name = getWPWordString();
                dataIndex = 32; // name has 32 bytes, but some could be random, so getWPWordString does not reliably set dataIndex
                numberOfCounterLevelsUsed = _data[dataIndex];
                dataIndex++;
                for (int i = dataIndex; i < dataIndex + 5; i++)
                {
                    defaultNumberingMethodForLevel[i] = _data[i];
                }
                dataIndex += 5;
                for (int i = 0; i <  5; i++)    // 5 level name, with 16 word strings each
                {
                    for (int j = 0; j < 16; j++)
                    {
                        levelName[i] += getWPWordString();
                    }
                }
            }
        }
    }
}
