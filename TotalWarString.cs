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

        public TotalWarString(string str)
        {
            if (str.StartsWith("{") && str.Contains("}"))
            {
                string[] tokens = str.Split('}');
                key = tokens[0].Trim().Substring(1);
                text = tokens[1].Trim();
            }
        }

        public string ToRawString()
        {
            return "{" + key + "}" + text;
        }
    }
}
