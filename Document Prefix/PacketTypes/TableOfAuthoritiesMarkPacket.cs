using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class TableOfAuthoritiesMarkPacket: PacketData
    {
        public GeneralWPText_Packet childPID { get; set; } //terrible name--not sure yet what would be better
        public string shortFormName { get; set; }
        public string TOASectionName {get; set;}

        public TableOfAuthoritiesMarkPacket(WP6Document document, int prefixID): 
            base (document, prefixID)
        {
            childPID = new GeneralWPText_Packet(document, prefixID);
            shortFormName = getWPWordString();
            TOASectionName = getWPWordString();
        }

    }
}
