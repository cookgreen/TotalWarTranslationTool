using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.google.translate.api;

namespace TotalWarTranslationTool
{
    public partial class frmMain : Form
    {
        private GoogleTranslationDic googleTranslationDic;
        private List<TotalWarString> totalWarStrings;
        private List<Tuple<string, string>> translatedStrings;

        private delegate void SetRichTextBoxTextDelegate(RichTextBox textbox, string str);
        private delegate void SetProgressBarStyleDelegate(ProgressBar progressBar, ProgressBarStyle progressBarStyle);
        private SetRichTextBoxTextDelegate setRichTextBoxTextDelegate;
        private SetProgressBarStyleDelegate setProgressBarStyleDelegate;

        public frmMain()
        {
            InitializeComponent();

            totalWarStrings = new List<TotalWarString>();
            translatedStrings = new List<Tuple<string, string>>();

            googleTranslationDic = new GoogleTranslationDic("./settings//google.ini");

            translationSourceLangCombox.Items.Clear();
            translationDestCombox.Items.Clear();

            var translationNames = googleTranslationDic.GetAllTranslationNames();
            foreach(var translationName in translationNames)
            {
                translationSourceLangCombox.Items.Add(translationName);
                translationDestCombox.Items.Add(translationName);
            }

            translationSourceLangCombox.SelectedIndex = 0;
            translationDestCombox.SelectedIndex = 1;

            setRichTextBoxTextDelegate = new SetRichTextBoxTextDelegate(SetRichTextBoxTextMethod);
            setProgressBarStyleDelegate = new SetProgressBarStyleDelegate(SetProgressBarStyleMethod);
        }

        private void SetProgressBarStyleMethod(ProgressBar progressBar, ProgressBarStyle progressBarStyle)
        {
            if(progressBar.InvokeRequired)
            {
                progressBar.Invoke(setProgressBarStyleDelegate, progressBar, progressBarStyle);
            }
            else
            {
                progressBar.Style = progressBarStyle;
            }
        }

        private void SetRichTextBoxTextMethod(RichTextBox textbox, string str)
        {
            if(textbox.InvokeRequired)
            {
                textbox.Invoke(setRichTextBoxTextDelegate, textbox, str);
            }
            else
            {
                textbox.Text = str;
            }
        }

        private void btnTranslation_Click(object sender, EventArgs e)
        {
            GoogleTranslateAPIRequest request = new GoogleTranslateAPIRequest(
                googleTranslationDic.GetGoogleTranslationID(
                    translationDestCombox.SelectedItem.ToString()));

            request.TranslateFinished += Request_TranslateFinished;

            totalWarStrings.Clear();
            translatedStrings.Clear();
            txtTranslatedText.Clear();

            /*
             * Since we don't want translate engine to translate the key
             * so we need to `extract` the text from the string line
             */

            StringBuilder stringBuilder = new StringBuilder();
            string[] arr = txtOrginalText.Lines;

            for (int i = 0; i < arr.Length; i++)
            {
                string str = arr[i];
                if (str.StartsWith("{") && str.Contains("}"))
                {
                    TotalWarString totalWarString = new TotalWarString(str);
                    totalWarStrings.Add(totalWarString);

                    request.TranslateAsync(totalWarString.Text, totalWarString.Key);
                }
            }

            progressBarTranslation.Style = ProgressBarStyle.Marquee;

            Thread thread = new Thread(() =>
            {
                // The translated text array count must be equal to the un-translated arrary

                while (translatedStrings.Count != totalWarStrings.Count) { }

                /*
                 * After we translate the text, we need to rebuild the string line
                 * with the key since total war needs it.
                 */

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < translatedStrings.Count; i++)
                {
                    builder.Append("{" + translatedStrings[i].Item1 + "}" + translatedStrings[i].Item2);
                    builder.Append(Environment.NewLine);
                }
                SetRichTextBoxTextMethod(txtTranslatedText, builder.ToString());
                SetProgressBarStyleMethod(progressBarTranslation, ProgressBarStyle.Continuous);
            });
            thread.Start();
        }

        private void Request_TranslateFinished(string text, object keyObj)
        {
            translatedStrings.Add(new Tuple<string, string>(keyObj.ToString(), text));
        }
    }
}
