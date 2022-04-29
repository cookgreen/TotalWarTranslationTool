using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalWarTranslationTool
{
    public class TotalWarTextParser
    {
        private string originalTextContent;

        public TotalWarTextParser(string textContent)
        {
            originalTextContent = textContent;
        }

        public List<TotalWarTextObject> Parse()
        {
            List<TotalWarTextObject> textObjects = new List<TotalWarTextObject>();

            List<string> strArr = null;
            string[] arr = originalTextContent.Split(Environment.NewLine);

            for (int i = 0; i < arr.Length; i++)
            {
                string str = arr[i];

                if (string.IsNullOrEmpty(str)) //Pass the empty line
                    continue;

                if (str.StartsWith("{") && str.Contains("}"))
                {
                    if (strArr != null)
                    {
                        if (strArr[0].StartsWith("{"))
                        {
                            TotalWarTextString totalWarString = new TotalWarTextString(convertToStr(strArr));
                            textObjects.Add(totalWarString);
                        }
                        else if (strArr[0].StartsWith("¬"))
                        {
                            TotalWarTextComment totalWarTextComment = new TotalWarTextComment(convertToStr(strArr));
                            textObjects.Add(totalWarTextComment);
                        }
                    }

                    strArr = new List<string>();
                    strArr.Add(str);
                }
                else
                {
                    if (str.StartsWith("¬"))//Means that comment start
                    {
                        if (strArr != null)
                        {
                            if (strArr[0].StartsWith("{"))
                            {
                                TotalWarTextString totalWarString = new TotalWarTextString(convertToStr(strArr));
                                textObjects.Add(totalWarString);
                            }
                            else if (strArr[0].StartsWith("¬"))
                            {
                                TotalWarTextComment totalWarTextComment = new TotalWarTextComment(convertToStr(strArr));
                                textObjects.Add(totalWarTextComment);
                            }
                        }

                        strArr = new List<string>();
                        
                    }
                    else
                    {
                        strArr.Add(str);
                    }
                }
            }

            return textObjects;
        }

        private string convertToStr(List<string> strList)
        {
            StringBuilder builder = new StringBuilder();
            foreach(var str in strList)
            {
                builder.Append(str);
            }
            return builder.ToString();
        }
    }
}
