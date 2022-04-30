using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalWarTranslationTool
{
    public class TotalWarTextParser
    {
        private List<string> originalTextContent;

        public TotalWarTextParser(List<string> textContent)
        {
            originalTextContent = textContent;
        }

        public List<TotalWarTextObject> Parse()
        {
            List<TotalWarTextObject> textObjects = new List<TotalWarTextObject>();

            List<string> strArr = null;

            for (int i = 0; i < originalTextContent.Count; i++)
            {
                string str = originalTextContent[i];

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
                        strArr.Add(str);
                    }
                    else
                    {
                        strArr.Add(str);
                    }
                }

                if (i == originalTextContent.Count - 1)
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
