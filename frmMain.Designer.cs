
namespace TotalWarTranslationTool
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbText = new System.Windows.Forms.GroupBox();
            this.txtOrginalText = new System.Windows.Forms.RichTextBox();
            this.gbTranslation = new System.Windows.Forms.GroupBox();
            this.txtTranslatedText = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBarTranslation = new System.Windows.Forms.ProgressBar();
            this.btnTranslation = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTotalWarTextFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.gbFilePreview = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbFileText = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gbSuggestion = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.translationSourceLangCombox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.translationDestCombox = new System.Windows.Forms.ToolStripComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbText.SuspendLayout();
            this.gbTranslation.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.gbFilePreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbFileText.SuspendLayout();
            this.gbSuggestion.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1001, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(993, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Text Translation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbTranslation, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(987, 421);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbText
            // 
            this.gbText.Controls.Add(this.txtOrginalText);
            this.gbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbText.Location = new System.Drawing.Point(3, 3);
            this.gbText.Name = "gbText";
            this.gbText.Size = new System.Drawing.Size(487, 375);
            this.gbText.TabIndex = 1;
            this.gbText.TabStop = false;
            this.gbText.Text = "Text";
            // 
            // txtOrginalText
            // 
            this.txtOrginalText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOrginalText.Location = new System.Drawing.Point(3, 23);
            this.txtOrginalText.Name = "txtOrginalText";
            this.txtOrginalText.Size = new System.Drawing.Size(481, 349);
            this.txtOrginalText.TabIndex = 0;
            this.txtOrginalText.Text = "";
            // 
            // gbTranslation
            // 
            this.gbTranslation.Controls.Add(this.txtTranslatedText);
            this.gbTranslation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTranslation.Location = new System.Drawing.Point(496, 3);
            this.gbTranslation.Name = "gbTranslation";
            this.gbTranslation.Size = new System.Drawing.Size(488, 375);
            this.gbTranslation.TabIndex = 2;
            this.gbTranslation.TabStop = false;
            this.gbTranslation.Text = "Translation";
            // 
            // txtTranslatedText
            // 
            this.txtTranslatedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTranslatedText.Location = new System.Drawing.Point(3, 23);
            this.txtTranslatedText.Name = "txtTranslatedText";
            this.txtTranslatedText.ReadOnly = true;
            this.txtTranslatedText.Size = new System.Drawing.Size(482, 349);
            this.txtTranslatedText.TabIndex = 0;
            this.txtTranslatedText.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.Controls.Add(this.progressBarTranslation, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTranslation, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 384);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(981, 34);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // progressBarTranslation
            // 
            this.progressBarTranslation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarTranslation.Location = new System.Drawing.Point(3, 3);
            this.progressBarTranslation.Name = "progressBarTranslation";
            this.progressBarTranslation.Size = new System.Drawing.Size(855, 28);
            this.progressBarTranslation.TabIndex = 0;
            // 
            // btnTranslation
            // 
            this.btnTranslation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTranslation.Location = new System.Drawing.Point(864, 3);
            this.btnTranslation.Name = "btnTranslation";
            this.btnTranslation.Size = new System.Drawing.Size(114, 28);
            this.btnTranslation.TabIndex = 1;
            this.btnTranslation.Text = "Translation";
            this.btnTranslation.UseVisualStyleBackColor = true;
            this.btnTranslation.Click += new System.EventHandler(this.btnTranslation_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(993, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "File Translation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gbFilePreview, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.splitContainer1, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(987, 421);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.Controls.Add(this.txtTotalWarTextFile, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnBrowse, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(981, 34);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // txtTotalWarTextFile
            // 
            this.txtTotalWarTextFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalWarTextFile.Location = new System.Drawing.Point(3, 3);
            this.txtTotalWarTextFile.Name = "txtTotalWarTextFile";
            this.txtTotalWarTextFile.ReadOnly = true;
            this.txtTotalWarTextFile.Size = new System.Drawing.Size(875, 27);
            this.txtTotalWarTextFile.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowse.Location = new System.Drawing.Point(884, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 28);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // gbFilePreview
            // 
            this.gbFilePreview.Controls.Add(this.listBox1);
            this.gbFilePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFilePreview.Location = new System.Drawing.Point(3, 43);
            this.gbFilePreview.Name = "gbFilePreview";
            this.gbFilePreview.Size = new System.Drawing.Size(981, 195);
            this.gbFilePreview.TabIndex = 1;
            this.gbFilePreview.TabStop = false;
            this.gbFilePreview.Text = "File Preview";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(3, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(975, 169);
            this.listBox1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 244);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbFileText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbSuggestion);
            this.splitContainer1.Size = new System.Drawing.Size(981, 174);
            this.splitContainer1.SplitterDistance = 476;
            this.splitContainer1.TabIndex = 2;
            // 
            // gbFileText
            // 
            this.gbFileText.Controls.Add(this.richTextBox1);
            this.gbFileText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFileText.Location = new System.Drawing.Point(0, 0);
            this.gbFileText.Name = "gbFileText";
            this.gbFileText.Size = new System.Drawing.Size(476, 174);
            this.gbFileText.TabIndex = 0;
            this.gbFileText.TabStop = false;
            this.gbFileText.Text = "Text";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(470, 148);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // gbSuggestion
            // 
            this.gbSuggestion.Controls.Add(this.richTextBox2);
            this.gbSuggestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSuggestion.Location = new System.Drawing.Point(0, 0);
            this.gbSuggestion.Name = "gbSuggestion";
            this.gbSuggestion.Size = new System.Drawing.Size(501, 174);
            this.gbSuggestion.TabIndex = 0;
            this.gbSuggestion.TabStop = false;
            this.gbSuggestion.Text = "Suggestion";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 23);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(495, 148);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.translationSourceLangCombox,
            this.toolStripLabel1,
            this.translationDestCombox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1001, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // translationSourceLangCombox
            // 
            this.translationSourceLangCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.translationSourceLangCombox.Items.AddRange(new object[] {
            "English",
            "简体中文"});
            this.translationSourceLangCombox.Name = "translationSourceLangCombox";
            this.translationSourceLangCombox.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(26, 25);
            this.toolStripLabel1.Text = "->";
            // 
            // translationDestCombox
            // 
            this.translationDestCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.translationDestCombox.Items.AddRange(new object[] {
            "English",
            "简体中文"});
            this.translationDestCombox.Name = "translationDestCombox";
            this.translationDestCombox.Size = new System.Drawing.Size(121, 28);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 460);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(48, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(118, 26);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuSettings
            // 
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(83, 24);
            this.mnuSettings.Text = "Settings";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total War Translation Tool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbText.ResumeLayout(false);
            this.gbTranslation.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.gbFilePreview.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbFileText.ResumeLayout(false);
            this.gbSuggestion.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbText;
        private System.Windows.Forms.GroupBox gbTranslation;
        private System.Windows.Forms.RichTextBox txtOrginalText;
        private System.Windows.Forms.RichTextBox txtTranslatedText;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox translationSourceLangCombox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox translationDestCombox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ProgressBar progressBarTranslation;
        private System.Windows.Forms.Button btnTranslation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox gbFilePreview;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbFileText;
        private System.Windows.Forms.GroupBox gbSuggestion;
        private System.Windows.Forms.TextBox txtTotalWarTextFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}

