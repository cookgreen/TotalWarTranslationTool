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
            var content = File.ReadAllText(filePath);
            textParser = new TotalWarTextParser(content);
            textContent = textParser.Parse();
        }
    }
}
