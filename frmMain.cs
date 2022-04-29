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
        private List<Control> controlTexts;

        public frmMain()
        {
            InitializeComponent();

            controlTexts = new List<Control>();
            controlTexts.Add(this);
            controlTexts.Add(gbText);
            controlTexts.Add(gbTranslation);
            controlTexts.Add(btnTranslation);

            controlTexts.Add(btnBrowse);
            controlTexts.Add(gbFilePreview);
            controlTexts.Add(gbTranslation);
            controlTexts.Add(gbFileText);
            controlTexts.Add(gbSuggestion);

            controlTexts.Add(tabPage1);
            controlTexts.Add(tabPage2);

            googleTranslationDic = new GoogleTranslationDic("./settings//google.ini");

            translationSourceLangCombox.Items.Clear();
            translationDestCombox.Items.Clear();

            var translationNames = googleTranslationDic.GetAllTranslationNames();
            foreach(var translationName in translationNames)
            {
                translationSourceLangCombox.Items.Add(translationName);
                translationDestCombox.Items.Add(translationName);

                var newMenuItem = mnuSettings.DropDownItems.Add(translationName);
                newMenuItem.Click += (o, e) =>
                {
                    translateUI(newMenuItem.Text);
                };
            }

            translationSourceLangCombox.SelectedIndex = 0;
            translationDestCombox.SelectedIndex = 1;


            tasks = new List<TotalWarTranslationTask>();

            setButtonEnableDelegate = new SetButtonEnableDelegate(SetButtonEnableMethod);
            setRichTextBoxTextDelegate = new SetRichTextBoxTextDelegate(SetRichTextBoxTextMethod);
            setProgressBarStyleDelegate = new SetProgressBarStyleDelegate(SetProgressBarStyleMethod);
        }

        private void translateUI(string translationName)
        {
            string destLangID = googleTranslationDic.GetGoogleTranslationID(translationName);

            GoogleTranslateAPIRequest request = new GoogleTranslateAPIRequest(destLangID);
            foreach(var controlText in controlTexts)
            {
                request.TranslateAsync(controlText.Text, controlText);
                request.TranslateFinished += (o, e, e2) => {
                    (e2 as Control).Text = e;
                };
            }    
        }

        #region Tabpage - Text Translation

        private List<TotalWarTranslationTask> tasks;

        private delegate void SetButtonEnableDelegate(Button button, bool enable);
        private delegate void SetRichTextBoxTextDelegate(RichTextBox textbox, string str);
        private delegate void SetProgressBarStyleDelegate(ProgressBar progressBar, ProgressBarStyle progressBarStyle);
        private SetButtonEnableDelegate setButtonEnableDelegate;
        private SetRichTextBoxTextDelegate setRichTextBoxTextDelegate;
        private SetProgressBarStyleDelegate setProgressBarStyleDelegate;

        private void SetButtonEnableMethod(Button button, bool enable)
        {
            if (button.InvokeRequired)
            {
                button.Invoke(setButtonEnableDelegate, button, enable);
            }
            else
            {
                button.Enabled = enable;
            }
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
            if(string.IsNullOrEmpty(txtOrginalText.Text))
            {
                MessageBox.Show("Please input something!");
                return;
            }

            string destLangID = googleTranslationDic.GetGoogleTranslationID(
                    translationDestCombox.SelectedItem.ToString());

            tasks.Clear();
            txtTranslatedText.Clear();

            /*
             * Since we don't want translate engine to translate the key
             * so we need to `extract` the text from the string line
             */


            TotalWarTextParser textParser = new TotalWarTextParser(txtOrginalText.Lines.ToList());
            List<TotalWarTextObject> textObjects = textParser.Parse();

            foreach (var textObject in textObjects)
            {
                if(textObject.TextType == TotalWarTextType.LocalizedString)
                {
                    TotalWarTextString totalWarStr = textObject as TotalWarTextString;
                    TotalWarTranslationTask newTask = new TotalWarTranslationTask(totalWarStr, destLangID);
                    newTask.Start();
                    tasks.Add(newTask);
                }
            }

            progressBarTranslation.Style = ProgressBarStyle.Marquee;

            btnTranslation.Enabled = false;
            Thread thread = new Thread(() =>
            {
                // All Finished

                while (tasks.Where(o=>o.Status == TotalWarTranslationTaskStatus.Finished).Count() != 
                tasks.Count) { }

                /*
                 * After we translate the text, we need to rebuild the string line
                 * with the key since total war needs it.
                 */

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < tasks.Count; i++)
                {
                    builder.Append(tasks[i].TranslatedStr.ToRawString());
                    builder.Append(Environment.NewLine);
                }
                SetButtonEnableMethod(btnTranslation, true);
                SetRichTextBoxTextMethod(txtTranslatedText, builder.ToString());
                SetProgressBarStyleMethod(progressBarTranslation, ProgressBarStyle.Continuous);
            });
            thread.Start();
        }

        #endregion

        #region Tabpage - File Translation

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Total War text file|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtTotalWarTextFile.Text = dialog.FileName;
            }
        }

        #endregion;

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
