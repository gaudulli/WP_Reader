using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class Color: CharacterGroupFunction
    {
        public double red { get; set; } // % of each color: 255 = 100%
        public double green {get; set;}
        public double blue { get; set; }

        public Color(WP6Document doc, int index)
            : base(doc, index)
        {
            red = (double)nonDeletableInfo[0] / 255;
            green = (double)nonDeletableInfo[1] / 255;
            blue = (double)nonDeletableInfo[2] / 255;
        }

    }
}
