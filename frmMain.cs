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

        public frmMain()
        {
            InitializeComponent();

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


            tasks = new List<TotalWarTranslationTask>();

            setRichTextBoxTextDelegate = new SetRichTextBoxTextDelegate(SetRichTextBoxTextMethod);
            setProgressBarStyleDelegate = new SetProgressBarStyleDelegate(SetProgressBarStyleMethod);
        }

        #region Tabpage - Text Translation

        private List<TotalWarTranslationTask> tasks;

        private delegate void SetRichTextBoxTextDelegate(RichTextBox textbox, string str);
        private delegate void SetProgressBarStyleDelegate(ProgressBar progressBar, ProgressBarStyle progressBarStyle);
        private SetRichTextBoxTextDelegate setRichTextBoxTextDelegate;
        private SetProgressBarStyleDelegate setProgressBarStyleDelegate;

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
            string destLangID = googleTranslationDic.GetGoogleTranslationID(
                    translationDestCombox.SelectedItem.ToString());

            tasks.Clear();
            txtTranslatedText.Clear();

            /*
             * Since we don't want translate engine to translate the key
             * so we need to `extract` the text from the string line
             */


            TotalWarTextParser textParser = new TotalWarTextParser(txtOrginalText.Text);
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
    }
}
