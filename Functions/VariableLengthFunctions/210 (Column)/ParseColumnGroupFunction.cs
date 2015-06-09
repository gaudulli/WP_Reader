using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    class ParseColumnGroupFunction
    {

        public static ColumnGroupFunction getFunction(WP6Document doc, int index)
        {
            WP6_FunctionKey key = new WP6_FunctionKey(doc.data[index], doc.data[index + 1]);
            if (WP6_FunctionNames.map.ContainsKey(key))
            {
                ColumnGroup name = (ColumnGroup)WP6_FunctionNames.map[key];
                switch (name)
                {
                    case ColumnGroup.left_margin_set:
                        return new LeftMarginSet(doc, index);
                    case ColumnGroup.right_margin_set:
                        return new RightMarginSet(doc, index);

                    default:
                        return new ColumnGroupFunction(doc, index);
                }

            }
            return new ColumnGroupFunction(doc, index);  
        }
    }
}
