using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class StyleFunction :VariableLengthFunction
    {
        public StyleFunction(WP6Document doc, int index)
            : base(doc, index)
        {
            // No special coding needed yet for style functions
        }
    }
}
