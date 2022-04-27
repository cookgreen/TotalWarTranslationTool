using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TotalWarTranslationTool
{
    public class GoogleTranslationDic
    {
        private Dictionary<string, string> dic = new Dictionary<string, string>();

        public GoogleTranslationDic(string googleIniFile)
        {
            dic = new Dictionary<string, string>();
            parseGoogleINI(googleIniFile);
        }

        private void parseGoogleINI(string googleIniFile)
        {
            StreamReader reader = new StreamReader(googleIniFile);
            while (reader.Peek() > -1)
            {
                string line = reader.ReadLine();
                string[] tokens = line.Split('=');
                dic.Add(tokens[0].Trim(), tokens[1].Trim());
            }
            reader.Close();
        }

        public string GetGoogleTranslationID(string readableName)
        {
            return dic[readableName];
        }

        public List<string> GetAllTranslationNames()
        {
            return dic.Keys.ToList();
        }
    }
}
