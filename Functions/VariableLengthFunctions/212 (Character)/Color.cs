using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class Color: CharacterGroupFunction
    {
        public RGB_Color color;


        public Color()
        {

        }
        public Color(WP6Document doc, int index)
            : base(doc, index)
        {
            color.red = (double)nonDeletableInfo[0] / 255;
            color.green = (double)nonDeletableInfo[1] / 255;
            color.blue = (double)nonDeletableInfo[2] / 255;
        }

    }
}
