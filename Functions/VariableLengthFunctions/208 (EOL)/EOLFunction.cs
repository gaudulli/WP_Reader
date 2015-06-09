using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class EOLFunction: VariableLengthFunction
    {

        /// <summary>
        /// Returns a basic EOL. If needed, the embedded 
        /// subfunctions and cell info. data PIDs can be filled in.
        /// All EOL functions have the same format, so no need to 
        /// create separate subfunctions for each type.
        /// </summary>
        /// <param name="original"></param>
        public EOLFunction(WP6Document doc, int index): base (doc, index)
        {
            // No special coding needed yet for EOL functions
        }

    }
}
