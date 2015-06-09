using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class SingleByteFunction: Function
    {
        public SingleByteFunction(byte[] data, int index)
        {
            if (index < 180)
            {
                functionGroup = functionGroups.singleByte;
            }
            else
            {
                // assign EOL single byte functions to EOL group but not as a variable length function
                functionGroup = functionGroups.EOL;
            }
            WP6_FunctionKey key = new WP6_FunctionKey(data[index], 0);
            if (WP6_FunctionNames.map.ContainsKey(key))
            {
                name = WP6_FunctionNames.map[key];
            }
            else
            {
                name = functionGroups.none;
            }
        }
    }
}
