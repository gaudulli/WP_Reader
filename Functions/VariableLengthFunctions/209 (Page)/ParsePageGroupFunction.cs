using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public static class ParsePageGroupFunction
    {   
        public static PageGroupFunction getFunction(WP6Document doc, int index)
        {

            WP6_FunctionKey key = new WP6_FunctionKey(doc.data[index], doc.data[index+1]);
            if (WP6_FunctionNames.map.ContainsKey(key))
            {
                PageGroup name = (PageGroup)WP6_FunctionNames.map[key];
                switch (name)
                {
                    case PageGroup.top_margin_set:
                        return new TopMarginSet(doc, index);
                    case PageGroup.bottom_margin_set:
                        return new BottomMarginSet(doc, index);
                    case PageGroup.delayed_codes:
                        return new DelayedCodes(doc, index);
                    case PageGroup.page_number_position:
                        return new PageNumberPosition(doc, index);
                    case PageGroup.page_number_format:
                        return new PageNumberFormat(doc, index);
                    case PageGroup.start_of_delayed_codes:
                        return new StartOfDelayedCodes(doc, index);
                    case PageGroup.end_of_delayed_codes:
                        return new EndOfDelayedCodes(doc, index);
                    case PageGroup.suppress_page_characteristics:
                        return new SuppressPageCharacteristics(doc, index);

                    default:
                        return new PageGroupFunction(doc, index);
                }

            }
            return new PageGroupFunction(doc, index);   // return empty page group function if not in name list
        }


    }
}
