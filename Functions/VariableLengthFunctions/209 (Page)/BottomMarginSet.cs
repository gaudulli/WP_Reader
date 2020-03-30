using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class BottomMarginSet: PageGroupFunction
    {

       public short bottomMargin {get; set;}  //measurement in WPUs


        public BottomMarginSet()
        {

        }
       public BottomMarginSet(WP6Document doc, int index)
            : base(doc, index)
        {
            bottomMargin = BitConverter.ToInt16(nonDeletableInfo, 0);
        }
    }
}
