using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WP_Reader
{
    public class WP6Document
    {
        public FileHeader fileHeader { get; set; }
        public IndexArea indexArea { get; set; }
        // Packet Data Area is parsed as needed for individual function calls
        public DocumentArea documentArea{ get; set; }
        public byte[] data { get; set; }    //byte stream of the file
      

        public WP6Document(string URL)
        {
           data = File.ReadAllBytes(URL);
           // writeToFile(data);
            fileHeader = new FileHeader(data);
            int startIndex = fileHeader.ptrIndexArea;
            indexArea = new IndexArea(data, startIndex);
            documentArea = new DocumentArea(this);

            //writeWPStreamToFile(documentArea.WPStream, URL);
            //writeMapToFile(WP6_FunctionNames.map);
            writeToFile(data);

        }

        private void writeToFile(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Index" + "\t" + "Hex" + "\t\t" + "Char" + "\t\t" + "Decimal");
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.AppendLine(i + "\t" + bytes[i].ToString("X2") + "\t\t" + Encoding.ASCII.GetString(bytes, i, 1) + "\t\t" + bytes[i]);
            }

            File.WriteAllText("C:/Users/ric.gaudet/documents/HexData2.txt", sb.ToString());
        }

        private void writeMapToFile(Dictionary<WP6_FunctionKey, string> map)
        {
            StringBuilder sb = new StringBuilder();
            //foreach (KeyValuePair<WP6_FunctionKey, string> entry in map)
            foreach ( WP6_FunctionKey entry in map.Keys)
            {
                sb.AppendLine(entry.group + ", " +  entry.subgroup +  "\t\t" + map[entry]);

            }
            File.WriteAllText("C:/WPCodesMap2.txt", sb.ToString());
        }

        private void writeWPStreamToFile(List<WPToken> WPStream, string URL)
        {

            StringBuilder sb = new StringBuilder();
            foreach (WPToken t in WPStream)
            {
                Type itype = t.GetType();
                if (itype == typeof(Character))
                {
                    Character ch = (Character)t;
                    sb.Append(ch.content.ToString());
                }
                else
                {
                    Function f = (Function)t;
                    string str = " [" + f.name.ToString() + "] ";
                    sb.Append(str);
                }
            }
          
           File.WriteAllText(URL + "WPStream.txt", sb.ToString());
        }


    }
}
