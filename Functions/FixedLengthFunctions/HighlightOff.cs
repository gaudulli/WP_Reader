using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class HighlightOff:FixedLengthFunction
    {
        public int redValue { get; set; }
        public int greenValue { get; set; }
        public int blueValue { get; set; }
        public int percentShading { get; set; }

        public HighlightOff()
        {

        }
        public HighlightOff(WP6Document doc, int index, int size)
            : base(doc, index, size)
        {

            redValue = functionData[0];
            greenValue = functionData[1];
            blueValue = functionData[2];
            percentShading = functionData[3];
            name = FixedLengthGroup.highlight_off;
        }
    }
}
