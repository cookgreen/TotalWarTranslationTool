using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalWarTranslationTool
{
    public enum TotalWarTextType
    {
        Comment,
        LocalizedString
    }

    public class TotalWarTextObject
    {
        protected TotalWarTextType type;

        public TotalWarTextType TextType
        {
            get { return type; }
        }

        public virtual string ToRawString()
        {
            return string.Empty;
        }
    }
}
