using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class Undo: FixedLengthFunction
    {
        public UndoType undoType { get; set; }


        public Undo()
        {

        }
        public Undo(WP6Document doc, int index, int size)
            : base(doc, index, size)
        {
            undoType = (UndoType)Enum.Parse(typeof(UndoType), functionData[0].ToString());
            // bytes 1 and 2 are not useful for external applications
            name = FixedLengthGroup.undo;
        }
    }
}
