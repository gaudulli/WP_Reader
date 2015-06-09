using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class RightMarginSet:ColumnGroupFunction
    {
        public short rightMargin {get; set;}  //measurement in WPUs

        public RightMarginSet(WP6Document doc, int index)
            : base(doc, index)
        {
            rightMargin = BitConverter.ToInt16(nonDeletableInfo, 0);
        }
    }
}
