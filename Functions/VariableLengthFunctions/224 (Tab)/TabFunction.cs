using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class TabFunction:VariableLengthFunction
    {
        public TabFunction(WP6Document doc, int index)
            : base(doc, index)
        {

        }

        public override void getName()
        {
            int bitIndex = 2;
            int mask = 1 << bitIndex;
            subGroup &= (byte)~mask;
            WP6_FunctionKey key = new WP6_FunctionKey(group, subGroup);
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
