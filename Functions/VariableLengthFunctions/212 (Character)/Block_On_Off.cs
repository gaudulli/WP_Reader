using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class Block_On_Off: CharacterGroupFunction
    {

        public bool on { get; set; }

        public Block_On_Off()
        {

        }

        public Block_On_Off(WP6Document doc, int index)
            : base(doc, index)
        {
            on = nonDeletableInfo[0] > 0;
        }
    }
}
