using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalWarTranslationTool
{
    public class TotalWarTextComment : TotalWarTextObject
    {
        private string commentContent;

        public TotalWarTextComment(string commentContent)
        {
            this.commentContent = commentContent;
            type = TotalWarTextType.Comment;
        }

        public override string ToRawString()
        {
            return "¬" + commentContent;
        }
    }
}
