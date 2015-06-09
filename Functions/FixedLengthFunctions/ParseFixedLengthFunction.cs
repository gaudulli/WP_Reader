using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public static class ParseFixedLengthFunction
    {
        public static FixedLengthFunction getFunction(WP6Document doc, int index)
        {
            FixedLengthGroup _name = (FixedLengthGroup)Enum.Parse(typeof(FixedLengthGroup), doc.data[index].ToString());
            switch (_name)
            {
                case FixedLengthGroup.attribute_on:
                    return new AttributeOn(doc, index, 3);
                case FixedLengthGroup.attribute_off:
                    return new AttributeOff(doc, index, 3);
                case FixedLengthGroup.extended_character:
                    return new ExtendedCharacter(doc, index, 4);
                case FixedLengthGroup.undo:
                    return new Undo(doc, index, 5);
                case FixedLengthGroup.highlight_on:
                    return new HighlightOn(doc, index, 6);
                case FixedLengthGroup.highlight_off:
                    return new HighlightOff(doc, index, 6);                

                case FixedLengthGroup.reserved1:
                case FixedLengthGroup.reserved2:
                    return new FixedLengthFunction(doc, index, 3);  //return empty function
                case FixedLengthGroup.reserved3:
                case FixedLengthGroup.reserved4:
                case FixedLengthGroup.reserved5:
                    return new FixedLengthFunction(doc, index, 4);  //return empty function
                case FixedLengthGroup.reserved6:
                case FixedLengthGroup.reserved7:
                    return new FixedLengthFunction(doc, index, 5);  //return empty function
                case FixedLengthGroup.reserved8:
                case FixedLengthGroup.reserved9:
                    return new FixedLengthFunction(doc, index, 8);  //return empty function
            }

            return null;
        }
    }
}
