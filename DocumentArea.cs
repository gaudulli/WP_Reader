using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WP_Reader
{



    public class DocumentArea
    {

        public List<WPToken> WPStream {get; set;}

        int index;
        WP6Document document;
        byte[] data;
        int length;
        int stop;


        public DocumentArea(WP6Document doc)
        {
            document = doc;
            data = document.data;
            index = document.fileHeader.ptrDocumentArea;
            stop= data.Length;
            WPStream = new List<WPToken>();
            parseDocumentArea();
        }

        /// <summary>
        /// Use this constructor to parse other data packets containing WP text
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="data"></param>
        /// <param name="index"></param>
        public DocumentArea(WP6Document doc, int index, int stop)
        {
            document = doc;
            data = document.data;
            this.index = index;
            this.stop = stop;
            WPStream = new List<WPToken>();
            parseDocumentArea();

        }

        public void parseDocumentArea()
        {
            while (index < stop)
            {
               if (data[index] > 0 && data[index] < 33)
               {
                   // parse default extended international characters
                   WP6_FunctionKey key = new WP6_FunctionKey(data[index], 0);
                   index++;
                   if (WP6_DefaultExtendedInternationalCharacters.map.ContainsKey(key))
                   {
                       WPStream.Add(new Character((WP6_DefaultExtendedInternationalCharacters.map[key]).ToString()));
                   }
               }
                // add ascii character
               else if (data[index] > 32 && data[index] < 127)
                {
                    WPStream.Add(new Character(data, index));
                    index++;
                }

                // parse single-byte function
                else if (data[index] > 127 && data[index] < 208)
                {
                    SingleByteFunction sbf = new SingleByteFunction(data, index);
                    if (!sbf.name.Equals(functionGroups.none))
                    {
                        WPStream.Add(sbf);
                    }
                    index++;
                }

                //parse variable-length multi-byte functions
                else if (data[index] > 207 && data[index] < 227)
                {
                    VariableLengthFunction function = ParseVariableLengthFunction.getfunction(document, index);
                    index += function.size;
                    if (!function.name.Equals(functionGroups.none))
                    {
                        WPStream.Add(function);
                    }
                }

                   // parse fixed-length functions
               else if (data[index] > 239 && data[index] <= 255)
               {
                   FixedLengthFunction function = ParseFixedLengthFunction.getFunction(document, index);
                   index += function.size;
                   if (!function.name.Equals(functionGroups.none))
                   {
                       WPStream.Add(function);
                   }
               }
               else
                {
                    index++;
                }
            }
        }


     }
}
