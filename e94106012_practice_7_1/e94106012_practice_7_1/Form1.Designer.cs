namespace e94106012_practice_7_1
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            檔案ToolStripMenuItem = new ToolStripMenuItem();
            AddNew = new ToolStripMenuItem();
            OpenOld = new ToolStripMenuItem();
            SaveText = new ToolStripMenuItem();
            SaveAsNew = new ToolStripMenuItem();
            Exit = new ToolStripMenuItem();
            功能ToolStripMenuItem = new ToolStripMenuItem();
            AddWord_MenuBar = new ToolStripMenuItem();
            SearchWord = new ToolStripMenuItem();
            WordTest = new ToolStripMenuItem();
            檢視ToolStripMenuItem = new ToolStripMenuItem();
            FontSize = new ToolStripMenuItem();
            ShowMarkingItem = new ToolStripMenuItem();
            ClearMarking = new ToolStripMenuItem();
            textBox1 = new TextBox();
            EnglishLabel = new Label();
            ChineseLabel = new Label();
            CategoryLabel = new Label();
            AddOrSearchBtn = new Button();
            EnglishCheckBox = new CheckBox();
            ChineseCheckBox = new CheckBox();
            CategoryCheckBox = new CheckBox();
            EnglishTextBox = new TextBox();
            ChineseTextBox = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            CategoryComboBox = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 檔案ToolStripMenuItem, 功能ToolStripMenuItem, 檢視ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(767, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            檔案ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddNew, OpenOld, SaveText, SaveAsNew, Exit });
            檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            檔案ToolStripMenuItem.Size = new Size(44, 21);
            檔案ToolStripMenuItem.Text = "檔案";
            // 
            // AddNew
            // 
            AddNew.Name = "AddNew";
            AddNew.Size = new Size(180, 22);
            AddNew.Text = "新增";
            AddNew.Click += AddNew_Click;
            // 
            // OpenOld
            // 
            OpenOld.Name = "OpenOld";
            OpenOld.Size = new Size(180, 22);
            OpenOld.Text = "開啟舊檔";
            OpenOld.Click += OpenOld_Click;
            // 
            // SaveText
            // 
            SaveText.Name = "SaveText";
            SaveText.Size = new Size(180, 22);
            SaveText.Text = "儲存";
            SaveText.Click += SaveText_Click;
            // 
            // SaveAsNew
            // 
            SaveAsNew.Name = "SaveAsNew";
            SaveAsNew.Size = new Size(180, 22);
            SaveAsNew.Text = "另存新檔";
            SaveAsNew.Click += SaveAsNew_Click;
            // 
            // Exit
            // 
            Exit.Name = "Exit";
            Exit.Size = new Size(180, 22);
            Exit.Text = "離開";
            Exit.Click += Exit_Click;
            // 
            // 功能ToolStripMenuItem
            // 
            功能ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddWord_MenuBar, SearchWord, WordTest });
            功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            功能ToolStripMenuItem.Size = new Size(44, 21);
            功能ToolStripMenuItem.Text = "功能";
            // 
            // AddWord_MenuBar
            // 
            AddWord_MenuBar.Name = "AddWord_MenuBar";
            AddWord_MenuBar.Size = new Size(124, 22);
            AddWord_MenuBar.Text = "新增單字";
            AddWord_MenuBar.Click += AddWord_MenuBar_Click;
            // 
            // SearchWord
            // 
            SearchWord.Name = "SearchWord";
            SearchWord.Size = new Size(124, 22);
            SearchWord.Text = "搜尋單字";
            SearchWord.Click += SearchWord_Click;
            // 
            // WordTest
            // 
            WordTest.Name = "WordTest";
            WordTest.Size = new Size(124, 22);
            WordTest.Text = "單字測驗";
            WordTest.Click += WordTest_Click;
            // 
            // 檢視ToolStripMenuItem
            // 
            檢視ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FontSize, ShowMarkingItem, ClearMarking });
            檢視ToolStripMenuItem.Name = "檢視ToolStripMenuItem";
            檢視ToolStripMenuItem.Size = new Size(44, 21);
            檢視ToolStripMenuItem.Text = "檢視";
            // 
            // FontSize
            // 
            FontSize.Name = "FontSize";
            FontSize.Size = new Size(160, 22);
            FontSize.Text = "字型大小";
            FontSize.Click += 字型大小ToolStripMenuItem_Click;
            // 
            // ShowMarkingItem
            // 
            ShowMarkingItem.Name = "ShowMarkingItem";
            ShowMarkingItem.Size = new Size(160, 22);
            ShowMarkingItem.Text = "只顯示標記單字";
            ShowMarkingItem.Click += ShowMarkingItem_Click;
            // 
            // ClearMarking
            // 
            ClearMarking.Name = "ClearMarking";
            ClearMarking.Size = new Size(160, 22);
            ClearMarking.Text = "清除標記";
            ClearMarking.Click += ClearMarking_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(585, 419);
            textBox1.TabIndex = 1;
            textBox1.WordWrap = false;
            // 
            // EnglishLabel
            // 
            EnglishLabel.AutoSize = true;
            EnglishLabel.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            EnglishLabel.Location = new Point(620, 78);
            EnglishLabel.Name = "EnglishLabel";
            EnglishLabel.Size = new Size(35, 19);
            EnglishLabel.TabIndex = 2;
            EnglishLabel.Text = "單字";
            // 
            // ChineseLabel
            // 
            ChineseLabel.AutoSize = true;
            ChineseLabel.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ChineseLabel.Location = new Point(620, 159);
            ChineseLabel.Name = "ChineseLabel";
            ChineseLabel.Size = new Size(35, 19);
            ChineseLabel.TabIndex = 4;
            ChineseLabel.Text = "中文";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryLabel.Location = new Point(620, 248);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(35, 19);
            CategoryLabel.TabIndex = 6;
            CategoryLabel.Text = "詞性";
            // 
            // AddOrSearchBtn
            // 
            AddOrSearchBtn.Location = new Point(677, 376);
            AddOrSearchBtn.Name = "AddOrSearchBtn";
            AddOrSearchBtn.Size = new Size(75, 23);
            AddOrSearchBtn.TabIndex = 8;
            AddOrSearchBtn.Text = "新增";
            AddOrSearchBtn.UseVisualStyleBackColor = true;
            AddOrSearchBtn.Click += AddOrSearchBtn_Click;
            // 
            // EnglishCheckBox
            // 
            EnglishCheckBox.AutoSize = true;
            EnglishCheckBox.Location = new Point(591, 104);
            EnglishCheckBox.Name = "EnglishCheckBox";
            EnglishCheckBox.Size = new Size(15, 14);
            EnglishCheckBox.TabIndex = 9;
            EnglishCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChineseCheckBox
            // 
            ChineseCheckBox.AutoSize = true;
            ChineseCheckBox.Location = new Point(591, 186);
            ChineseCheckBox.Name = "ChineseCheckBox";
            ChineseCheckBox.Size = new Size(15, 14);
            ChineseCheckBox.TabIndex = 10;
            ChineseCheckBox.UseVisualStyleBackColor = true;
            // 
            // CategoryCheckBox
            // 
            CategoryCheckBox.AutoSize = true;
            CategoryCheckBox.Location = new Point(591, 275);
            CategoryCheckBox.Name = "CategoryCheckBox";
            CategoryCheckBox.Size = new Size(15, 14);
            CategoryCheckBox.TabIndex = 11;
            CategoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // EnglishTextBox
            // 
            EnglishTextBox.Location = new Point(620, 99);
            EnglishTextBox.Name = "EnglishTextBox";
            EnglishTextBox.Size = new Size(132, 23);
            EnglishTextBox.TabIndex = 12;
            // 
            // ChineseTextBox
            // 
            ChineseTextBox.Location = new Point(623, 181);
            ChineseTextBox.Name = "ChineseTextBox";
            ChineseTextBox.Size = new Size(132, 23);
            ChineseTextBox.TabIndex = 13;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Items.AddRange(new object[] { "n.", "v.", "adj.", "adv.", "prep.", "conj.", "phr.", "abbr.", "pron.", "other" });
            CategoryComboBox.Location = new Point(620, 270);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(132, 25);
            CategoryComboBox.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 450);
            Controls.Add(CategoryComboBox);
            Controls.Add(ChineseTextBox);
            Controls.Add(EnglishTextBox);
            Controls.Add(CategoryCheckBox);
            Controls.Add(ChineseCheckBox);
            Controls.Add(EnglishCheckBox);
            Controls.Add(AddOrSearchBtn);
            Controls.Add(CategoryLabel);
            Controls.Add(ChineseLabel);
            Controls.Add(EnglishLabel);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 檔案ToolStripMenuItem;
        private ToolStripMenuItem AddNew;
        private ToolStripMenuItem OpenOld;
        private ToolStripMenuItem SaveText;
        private ToolStripMenuItem SaveAsNew;
        private ToolStripMenuItem Exit;
        private ToolStripMenuItem 功能ToolStripMenuItem;
        private ToolStripMenuItem AddWord_MenuBar;
        private ToolStripMenuItem SearchWord;
        private ToolStripMenuItem 檢視ToolStripMenuItem;
        private ToolStripMenuItem FontSize;
        private ToolStripMenuItem ShowMarkingItem;
        private ToolStripMenuItem ClearMarking;
        private TextBox textBox1;
        private Label EnglishLabel;
        private Label ChineseLabel;
        private Label CategoryLabel;
        private Button AddOrSearchBtn;
        private CheckBox EnglishCheckBox;
        private CheckBox ChineseCheckBox;
        private CheckBox CategoryCheckBox;
        private TextBox EnglishTextBox;
        private TextBox ChineseTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox CategoryComboBox;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem WordTest;
        public FontDialog fontDialog1;
    }
}