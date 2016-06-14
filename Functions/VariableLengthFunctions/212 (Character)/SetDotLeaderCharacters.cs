using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class SetDotLeaderCharacters : CharacterGroupFunction
    {
        public string dotLeaderCharacter { get; set; }
        public int numSpacesBetweenCharacters { get; set; }


        public SetDotLeaderCharacters(WP6Document document, int prefixID) :
            base(document, prefixID)
         {
             if (nonDeletableInfo[1] > 0) 
             { 
             dotLeaderCharacter = new ExtendedCharacter(nonDeletableInfo[1], nonDeletableInfo[0]).content;
             }
             else
             {
                 dotLeaderCharacter = ((char)nonDeletableInfo[0]).ToString();
             }
             numSpacesBetweenCharacters = nonDeletableInfo[2];
         }

    }
}
