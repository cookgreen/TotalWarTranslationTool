using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalWarTranslationTool
{
    public class TotalWarTextFile
    {
        private TotalWarTextParser textParser;
        private List<TotalWarTextObject> textContent;

        public List<TotalWarTextObject> TextContent
        {
            get { return textContent; }
        }

        public TotalWarTextFile(string filePath)
        {
            parseFile(filePath);
        }

        private void parseFile(string filePath)
        {
            List<string> textContents = new List<string>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.Peek() > -1)
                {
                    textContents.Add(reader.ReadLine());
                }
            }
            textParser = new TotalWarTextParser(textContents);
            textContent = textParser.Parse();
        }
    }
}
