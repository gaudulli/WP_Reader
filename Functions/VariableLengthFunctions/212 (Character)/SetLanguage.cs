using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class SetLanguage: CharacterGroupFunction
    {
        public Language language { get; set; }


        public SetLanguage()
        {

        }
         public SetLanguage(WP6Document doc, int index)
            : base(doc, index)
        {
            string languageCode = ((char)nonDeletableInfo[0]).ToString() + ((char)nonDeletableInfo[1]).ToString();
            if (Languages.map.ContainsKey(languageCode))
            {
                language = Languages.map[languageCode];
            }
        }

    }



    public static class Languages
    {
        public static Dictionary<string, Language> map;

        static Languages()
        {
            map = new Dictionary<string, Language>();

            map.Add("??", Language.Unknown);
            map.Add("AF", Language.Afrikaans);
            map.Add("CA", Language.Catalan);
            map.Add("CZ", Language.Czech);
            map.Add("HR", Language.Croatian);
            map.Add("DK", Language.Danish);
            map.Add("NL", Language.Dutch);
            map.Add("EN", Language.English);
            map.Add("US", Language.English);
            map.Add("OZ", Language.English_Australia);
            map.Add("CE", Language.English_Canada);
            map.Add("UK", Language.English_UK);
            map.Add("SU", Language.Finnish);
            map.Add("LF", Language.French_Canada);
            map.Add("FR", Language.French_National);
            map.Add("GA", Language.Galician);
            map.Add("DE", Language.German_National);
            map.Add("SD", Language.German_Switzerland);
            map.Add("GR", Language.Greek);
            map.Add("MA", Language.Hungarian);
            map.Add("IS", Language.Icelandic);
            map.Add("IT", Language.Italian);
            map.Add("JP", Language.Japanese);
            map.Add("NO", Language.Norwegian);
            map.Add("PL", Language.Polish);
            map.Add("BR", Language.Portuguese_Brazil);
            map.Add("PO", Language.Portuguese_Portugal);
            map.Add("RU", Language.Russian);
            map.Add("SL", Language.Slovak);
            map.Add("SO", Language.Slovenian);
            map.Add("ES", Language.Spanish);
            map.Add("SV", Language.Swedish);
            map.Add("TR", Language.Turkish);
            map.Add("YK", Language.Ukrainian);
               
        }
    }

    public enum Language
    {
        Unknown,
        Afrikaans,
        Catalan,
        Czech,
        Croatian,
        Danish,
        Dutch,
        English,
        English_Australia,
        English_Canada,
        English_UK,
        Finnish,
        French_Canada,
        French_National,
        Galician,
        German_National,
        German_Switzerland,
        Greek,
        Hungarian,
        Icelandic,
        Italian,
        Japanese,
        Norwegian,
        Polish,
        Portuguese_Brazil,
        Portuguese_Portugal,
        Russian,
        Slovak,
        Slovenian,
        Spanish,
        Swedish,
        Turkish,
        Ukrainian
    }


}
