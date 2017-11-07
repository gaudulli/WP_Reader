using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class PageNumberFormat: PageGroupFunction
    {
        public PageNumberFormatStringPacket pageNumberFormat { get; set; }

        public PageNumberFormat(WP6Document doc, int index)
            : base(doc, index)
        {
            pageNumberFormat = new PageNumberFormatStringPacket(doc, prefixIds[0] - 1);
            
        }
    }
}
