using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class Function : WPToken
    {
        public Enum name { get; set; }

        public Function(WP6Document doc, int index)
            : base(doc, index)
        {

        }

        public Function()
        {

        }


    }
}
