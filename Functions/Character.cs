using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class Character : WPToken
    {
        public string content { get; set; }     // some unicode characters have more than one char value

        public Character(byte[] data, int index)
        {
            functionGroup = functionGroups.textCharacter;
            name = functionGroups.none;
            content = ((char)data[index]).ToString();
        }

        public Character(string _content)
        {
            functionGroup = functionGroups.character;
            name = functionGroups.none;
            content = _content;
        }


    }
}
