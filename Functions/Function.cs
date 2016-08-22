using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class Function : WPToken
    {
        protected  const int  PUA = 0xF0000;
        public int _startIndex;  // occasionally needed to get start index of function

        public Function(WP6Document doc, int index)
            : base(doc, index)
        {

        }

        public Function()
        {

        }


    }
}
