using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public static class WP_Parser
    {
        public static List<WPToken> GetWPStream(string URL)
        {
            WP6Document doc = new WP6Document(URL);
            return doc.documentArea.WPStream;
        }


    }



}
