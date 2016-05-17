using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class VerticalAdvanceTo_PagePosition: CharacterGroupFunction
    {

      public bool absolute { get; set; }
      public short adjustment { get; set; }

      public VerticalAdvanceTo_PagePosition(WP6Document doc, int index)
            : base(doc, index)
        {
            absolute = nonDeletableInfo[0] > 0;
            adjustment = BitConverter.ToInt16(nonDeletableInfo, 1);
        }

    }
}
