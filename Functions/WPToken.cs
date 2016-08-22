using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class WPToken
    {
        public Enum name { get; set; }
        public functionGroups functionGroup { get; set; }
        public int codeValue { get; set; }    // value of function group and subgroup (inversed, because that's what PerfectScript does!)
        public bool hasTextContent { get; set; }

        public WPToken(WP6Document doc, int index)
        {

        }
        public WPToken()
        {

        }


    }
}
