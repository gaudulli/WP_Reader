using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class HypertextBeginOff : CharacterGroupFunction
    {
        /// <summary>
        /// paired function to match HypertextBeiginOn--but has no other real purpose
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="index"></param>
        public HypertextBeginOff(WP6Document doc, int index)
            : base(doc, index)
        {

        }

    }
}
