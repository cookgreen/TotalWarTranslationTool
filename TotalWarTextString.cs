using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalWarTranslationTool
{
    public class TotalWarTextString : TotalWarTextObject
    {
        private string key;
        private string text;

        public string Key
        {
            get { return key; }
        }

        public string Text
        {
            get { return text; }
        }

        public TotalWarTextString(string rawString)
        {
            type = TotalWarTextType.LocalizedString;
            if (rawString.StartsWith("{") && rawString.Contains("}"))
            {
                string[] tokens = rawString.Split('}');
                key = tokens[0].Trim().Substring(1);
                text = tokens[1].Trim();
            }
        }

        public TotalWarTextString(string key, string text)
        {
            type = TotalWarTextType.LocalizedString;
            this.key = key;
            this.text = text;
        }

        public override string ToRawString()
        {
            return "{" + key + "}" + text;
        }
    }
}
