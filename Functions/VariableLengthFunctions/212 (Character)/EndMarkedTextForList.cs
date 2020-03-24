using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class EndMarkedTextForList: CharacterGroupFunction
    {
        public string listName { get; set; }

        public EndMarkedTextForList()
        {

        }

        public EndMarkedTextForList(WP6Document doc, int index)
            : base(doc, index)
        {
            listName = getWPWordString(nonDeletableInfo, 0);          
        }

    }
}
