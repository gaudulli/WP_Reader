using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WP_Reader {
    class Program {
        static void Main(string[] args) {

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string TestingURL = "\\\\lcsvs\\lcs\\LCS\\lcsshare\\NMLegisDrafter\\TestDocs\\";
            //string FileName = "\\TestDocs\\31-18-17.wpd";
            //string FileName = "\\TestDocs\\hyphentest.wpd";
            //string FileName = "\\TestDocs\\31-18-17.wpd";
            string FileName = "WPReaderTest.wpd";

            WP6Document doc = new WP6Document(TestingURL + FileName);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
             
        }
    }
}
