using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalWarTranslationTool
{
    public class TotalWarString
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

        public TotalWarString(string rawString)
        {
            if (rawString.StartsWith("{") && rawString.Contains("}"))
            {
                string[] tokens = rawString.Split('}');
                key = tokens[0].Trim().Substring(1);
                text = tokens[1].Trim();
            }
        }

        public TotalWarString(string key, string text)
        {
            this.key = key;
            this.text = text;
        }

        public string ToRawString()
        {
            return "{" + key + "}" + text;
        }
    }
}
