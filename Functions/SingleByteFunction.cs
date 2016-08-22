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
            _startIndex = index;
            if (data[index] < 180)
            {
                functionGroup = functionGroups.singleByte;
            }
            else
            {
                // assign EOL single byte functions to EOL group but not as a variable length function
                functionGroup = functionGroups.EOL;
                hasTextContent = true;
            }
            WP6_FunctionKey key = new WP6_FunctionKey(data[index], 0);
            if (WP6_FunctionNames.map.ContainsKey(key))
            {
                name = WP6_FunctionNames.map[key];
                codeValue = data[index] + PUA;
                if (functionGroup == functionGroups.singleByte)
                {
                    switch ((SingleByteGroup)name)
                    {
                        case SingleByteGroup.soft_space:
                        case SingleByteGroup.hard_space:
                        case SingleByteGroup.hard_hyphen_in_line:
                        case SingleByteGroup.dormant_hard_return:
                            {
                                hasTextContent = true;
                                break;
                            }
                    }
                }
            }
            else
            {
                name = functionGroups.none;
            }
        }
    }
}
