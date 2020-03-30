using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class TableOfAuthorityEntry: CharacterGroupFunction
    {

        TableOfAuthoritiesMarkPacket TOAPacket { get; set; }
        public string shortFormName { get; set; }

        public TableOfAuthorityEntry()
        {

        }
       public TableOfAuthorityEntry(WP6Document doc, int index)
            : base(doc, index)
        {
           if (flags.HasFlag(flagsByte.prefixID))
           {
               TOAPacket = new TableOfAuthoritiesMarkPacket(doc, prefixIds[0]);
               shortFormName = TOAPacket.shortFormName;
           }
           else
           {
               shortFormName = UtilityMethods.getWPWordString(doc.data, _startIndex, _startIndex + size - 1);
           }
        }
    }
}
