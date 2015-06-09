using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class TopMarginSet: PageGroupFunction
    {
        public short topMargin { get; set; }  //measurement in WPUs
    
        public TopMarginSet(WP6Document doc, int index)
            : base(doc, index)
        {
            topMargin = BitConverter.ToInt16(nonDeletableInfo, 0);
        }
    }
}
