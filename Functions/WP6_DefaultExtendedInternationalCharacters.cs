using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public static class WP6_DefaultExtendedInternationalCharacters
    {
        public static Dictionary<WP6_FunctionKey, string> map;

       static WP6_DefaultExtendedInternationalCharacters()
        {
            map = new Dictionary<WP6_FunctionKey, string>();

            //Default extended international characters mapped to unicode value 
            //subgroup set to 0
            map.Add(new WP6_FunctionKey(0x01, 0), "\u00e5");
            map.Add(new WP6_FunctionKey(0x02, 0), "\u00c5");
            map.Add(new WP6_FunctionKey(0x03, 0), "\u00e6");
            map.Add(new WP6_FunctionKey(0x04, 0), "\u00c6");
            map.Add(new WP6_FunctionKey(0x05, 0), "\u00e4");
            map.Add(new WP6_FunctionKey(0x06, 0), "\u00c4");
            map.Add(new WP6_FunctionKey(0x07, 0), "\u00e1");
            map.Add(new WP6_FunctionKey(0x08, 0), "\u00e0");
            map.Add(new WP6_FunctionKey(0x09, 0), "\u00e2");
            map.Add(new WP6_FunctionKey(0x0A, 0), "\u00e3");
            map.Add(new WP6_FunctionKey(0x0B, 0), "\u00c3");
            map.Add(new WP6_FunctionKey(0x0C, 0), "\u00e7");
            map.Add(new WP6_FunctionKey(0x0D, 0), "\u00c7");
            map.Add(new WP6_FunctionKey(0x0E, 0), "\u00eb");
            map.Add(new WP6_FunctionKey(0x0F, 0), "\u00e9");
            map.Add(new WP6_FunctionKey(0x10, 0), "\u00c9");
            map.Add(new WP6_FunctionKey(0x11, 0), "\u00e8");
            map.Add(new WP6_FunctionKey(0x12, 0), "\u00ea");
            map.Add(new WP6_FunctionKey(0x13, 0), "\u00ed");
            map.Add(new WP6_FunctionKey(0x14, 0), "\u00f1");
            map.Add(new WP6_FunctionKey(0x15, 0), "\u00d1");
            map.Add(new WP6_FunctionKey(0x16, 0), "\u00f8");
            map.Add(new WP6_FunctionKey(0x17, 0), "\u00d8");
            map.Add(new WP6_FunctionKey(0x18, 0), "\u00f5");
            map.Add(new WP6_FunctionKey(0x19, 0), "\u00d5");
            map.Add(new WP6_FunctionKey(0x1A, 0), "\u00f6");
            map.Add(new WP6_FunctionKey(0x1B, 0), "\u00d6");
            map.Add(new WP6_FunctionKey(0x1C, 0), "\u00fc");
            map.Add(new WP6_FunctionKey(0x1D, 0), "\u00dc");
            map.Add(new WP6_FunctionKey(0x1E, 0), "\u00fa");
            map.Add(new WP6_FunctionKey(0x1F, 0), "\u00f9");
            map.Add(new WP6_FunctionKey(0x20, 0), "\u00df");
        }
    }
}
