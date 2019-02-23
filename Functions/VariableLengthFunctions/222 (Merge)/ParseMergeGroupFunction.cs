using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public static class ParseMergeGroupFunction
    {
        public static MergeGroupFunction getFunction(WP6Document doc, int index)
        {

            WP6_FunctionKey key = new WP6_FunctionKey(doc.data[index], doc.data[index + 1]);
            if (WP6_FunctionNames.map.ContainsKey(key))
            {
                MergeGroup name = (MergeGroup)WP6_FunctionNames.map[key];
                switch (name)
                {
                    case MergeGroup.field_on:

                        break;
                    case MergeGroup.field_off:

                        break;

                    default:
                        return new MergeGroupFunction(doc, index);
                }

            }
            return new MergeGroupFunction(doc, index);   // return empty merge group function if not in name list
        }

    }
}
