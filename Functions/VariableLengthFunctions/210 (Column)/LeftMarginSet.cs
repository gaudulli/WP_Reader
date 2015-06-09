using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class LeftMarginSet:ColumnGroupFunction
    {
        public short leftMargin {get; set;}  //measurement in WPUs

        public LeftMarginSet(WP6Document doc, int index)
            : base(doc, index)
        {
            leftMargin = BitConverter.ToInt16(nonDeletableInfo, 0);
        }
    }
}
