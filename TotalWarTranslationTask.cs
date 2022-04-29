using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.google.translate.api;

namespace TotalWarTranslationTool
{
    public enum TotalWarTranslationTaskStatus
    {
        Stopped,
        Processing,
        Finished
    }

    public class TotalWarTranslationTask
    {
        private TotalWarTranslationTaskStatus status;
        private GoogleTranslateAPIRequest request;
        private string destLangID;
        private TotalWarString originaStr;
        private TotalWarString translatedStr;

        public TotalWarTranslationTaskStatus Status
        {
            get { return status; }
        }

        public TotalWarString TranslatedStr
        {
            get { return translatedStr; }
        }

        public string DestLangID
        {
            get { return destLangID; }
        }

        public TotalWarTranslationTask(TotalWarString totalWarString, string destLangID)
        {
            originaStr = totalWarString;
            this.destLangID = destLangID;
            request = new GoogleTranslateAPIRequest(destLangID);
            request.TranslateFinished += Request_TranslateFinished;
            status = TotalWarTranslationTaskStatus.Finished;
        }

        public void Start()
        {
            request.TranslateAsync(originaStr.Text, originaStr.Key);
            status = TotalWarTranslationTaskStatus.Processing;
        }

        private void Request_TranslateFinished(bool unused, string text, object keyObj)
        {
            translatedStr = new TotalWarString(keyObj.ToString(), text);
            status = TotalWarTranslationTaskStatus.Finished;
        }
    }
}
