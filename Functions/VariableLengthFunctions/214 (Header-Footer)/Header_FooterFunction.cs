using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class Header_FooterFunction: VariableLengthFunction
    {
        public GeneralWPText_Packet content { get; set; }
        public Header_FooterOccurrence occurrence { get; set; }

        public Header_FooterFunction(WP6Document doc, int index)
            : base(doc, index)
        {

            
            // for now, ignore the possible second prefixID (user assistant)
            if (prefixIds[0] > 0)
            {
                content = new GeneralWPText_Packet(document, prefixIds[0] - 1);
                // WP numbers prefixIDs beginning with 1, so need to subtract 1 to get correct ID
            }
             occurrence = (Header_FooterOccurrence)nonDeletableInfo[0]; // cast to enum
        }
    }

    [Flags()]   // allows bitwise operations on the enum
    public enum Header_FooterOccurrence
    {
        odd = 1,
        even = 2,
        vertical = 4,
        noFullPageToDisplayWatermark = 8
    }

}
