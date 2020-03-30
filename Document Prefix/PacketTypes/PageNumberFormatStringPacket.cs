using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class PageNumberFormatStringPacket: PacketData
    {
        public string pageNumberFormatString { get; set; }

        public PageNumberFormatStringPacket()
        {

        }
        public PageNumberFormatStringPacket(WP6Document document, int prefixID) :
            base(document, prefixID)
        {
            if (prefixID > -1)
            {
                pageNumberFormatString = getWPWordString();
            }
        }
    }
}
