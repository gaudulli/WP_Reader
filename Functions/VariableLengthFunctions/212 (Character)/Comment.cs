using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Reader
{
    public class Comment: CharacterGroupFunction
    {
        public Comment_AnnotationPacket commentText { get; set; }

        public Comment(WP6Document doc, int index)
            : base(doc, index)
        {
            commentText = new Comment_AnnotationPacket(doc, prefixIds[0] - 1);
        }
    }
}
