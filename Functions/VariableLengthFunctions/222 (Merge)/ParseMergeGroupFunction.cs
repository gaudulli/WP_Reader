using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    class ParseMergeGroupFunction
    {
        public static MergeGroupFunction getFunction(WP6Document doc, int index)
        {

            WP6_FunctionKey key = new WP6_FunctionKey(doc.data[index], doc.data[index + 1]);
            if (WP6_FunctionNames.map.ContainsKey(key))
            {
                MergeGroup name = (MergeGroup)WP6_FunctionNames.map[key];
                switch (name)
                {


                    default:
                        return new MergeGroupFunction(doc, index);
                }

            }
            return new MergeGroupFunction(doc, index);   // return empty page group function if not in name list
        }

    }
}
