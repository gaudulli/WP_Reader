using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    /// <summary>
    /// 0x d3 00 (211 00)
    /// </summary>
    public class SetLineHeight:ParagraphGroupFunction
    {
        public short linesPerInch {get; set;}  //measurement in WPUs
        public short? minimumLinesPerInch { get; set; }  //measurement in WPUs

        public SetLineHeight(WP6Document doc, int index)
            : base(doc, index)
        {
            linesPerInch = BitConverter.ToInt16(nonDeletableInfo, 0);
            if (nonDeletableInfo.Length > 2)
            {
                minimumLinesPerInch = BitConverter.ToInt16(nonDeletableInfo, 2);
            }
        }
    }
}
