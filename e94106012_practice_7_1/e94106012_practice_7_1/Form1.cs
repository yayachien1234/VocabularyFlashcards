using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
namespace e94106012_practice_7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool UseOldFile = false;
        public List<string> English = new List<string>();
        public List<string> Chinese = new List<string>();
        public List<string> Category = new List<string>();
        public List<string> Marking = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            AddWord_Function_Reset();
        }
        private void AddWord_Function_Reset()//將新增單字那塊區域隱藏起來
        {
            EnglishLabel.Visible = false;
            EnglishTextBox.Visible = false;
            EnglishCheckBox.Visible = false;
            ChineseLabel.Visible = false;
            ChineseTextBox.Visible = false;
            ChineseCheckBox.Visible = false;
            CategoryLabel.Visible = false;
            CategoryComboBox.Visible = false;
            CategoryCheckBox.Visible = false;
            AddOrSearchBtn.Visible = false;
        }

        private void AddNew_Click(object sender, EventArgs e)//檔案-新增
        {
            textBox1.Text = "";
            UseOldFile = false;
            List<string> English = new List<string>();
            List<string> Chinese = new List<string>();
            List<string> Category = new List<string>();
            List<string> Marking = new List<string>();
            UseOldFile = false;
        }

        private void OpenOld_Click(object sender, EventArgs e)//檔案-開啟舊檔
        {
            String stFilter = "All File(*.*)|*.*|Todo File(*.todo)|*.todo|Text File(*.txt)|*txt";
            openFileDialog1.Filter = stFilter;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                UseOldFile = true;
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string data;
                do
                {
                    data = sr.ReadLine();
                    if (data == null || data == "") break;         // 若資料讀取完畢，跳離迴圈
                    textBox1.Text += (data + "\r\n");
                    string[] words = data.Split(' '); // 使用空格分割文本
                    English.Add(words[0]);
                    Chinese.Add(words[1]);
                    Category.Add(words[2]);
                    Marking.Add("no");
                } while (true);
                sr.Close();

            }
        }

        private void SaveText_Click(object sender, EventArgs e)//檔案-儲存
        {
            FileInfo finfo = new FileInfo(openFileDialog1.FileName);

            if (!UseOldFile)// 檢查是否使用舊檔儲存
            {
                SaveAsNew_Click(sender, e);
            }
            if (ShowMarkingItem.Text == "只顯示標記單字(v)")
            {
                MessageBox.Show("目前只會存取被標記的單字喔!", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            StreamWriter sw = finfo.CreateText();
            sw.WriteLine(textBox1.Text);
            sw.Flush();
            sw.Close();
        }

        private void SaveAsNew_Click(object sender, EventArgs e)//檔案-另存新檔
        {
            if (ShowMarkingItem.Text == "只顯示標記單字(v)")
            {
                MessageBox.Show("目前只會存取被標記的單字喔!", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Todo File(*.todo)|*.todo|Text File(*.txt)|*txt|All File(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (FileStream fsOut = new FileStream(filePath, FileMode.Create))
                using (BinaryWriter bw = new BinaryWriter(fsOut))
                {
                    bw.Write(textBox1.Text);
                    bw.Flush();
                }
            }
        }

        private void AddWord_MenuBar_Click(object sender, EventArgs e)//功能-新增單字
        {
            EnglishLabel.Visible = true;
            EnglishTextBox.Visible = true;
            EnglishCheckBox.Visible = false;
            ChineseLabel.Visible = true;
            ChineseTextBox.Visible = true;
            ChineseCheckBox.Visible = false;
            CategoryLabel.Visible = true;
            CategoryComboBox.Visible = true;
            CategoryCheckBox.Visible = false;
            AddOrSearchBtn.Visible = true;
            AddWord_MenuBar.Text = "新增單字(v)";
            SearchWord.Text = "搜尋單字";
            textBox1.Text = "";
            for (int i = 0; i < English.Count; i++)
            {
                textBox1.Text += String.Format("\r\n{0} {1} {2}", English[i], Chinese[i], Category[i]);
            }

        }

        private void SearchWord_Click(object sender, EventArgs e)//功能-搜尋單字
        {
            textBox1.Text = "";
            EnglishLabel.Visible = true;
            EnglishTextBox.Visible = true;
            EnglishCheckBox.Visible = true;
            ChineseLabel.Visible = true;
            ChineseTextBox.Visible = true;
            ChineseCheckBox.Visible = true;
            CategoryLabel.Visible = true;
            CategoryComboBox.Visible = true;
            CategoryCheckBox.Visible = true;
            AddOrSearchBtn.Visible = true;
            AddOrSearchBtn.Text = "搜尋";
            AddWord_MenuBar.Text = "新增單字";
            SearchWord.Text = "搜尋單字(v)";
        }

        private void AddOrSearchBtn_Click(object sender, EventArgs e)//實現新增單字或是搜尋單字
        {
            if (AddOrSearchBtn.Text == "新增" && !(EnglishTextBox.Text == "") && !(ChineseTextBox.Text == "") && !(CategoryComboBox.Text == ""))
            {
                English.Add(EnglishTextBox.Text);
                Chinese.Add(ChineseTextBox.Text);
                Category.Add(CategoryComboBox.Text);
                Marking.Add("no");
                EnglishTextBox.Text = "";
                ChineseTextBox.Text = "";
                CategoryComboBox.Text = "";
                textBox1.Text = "";
                for (int i = 0; i < English.Count; i++)
                {
                    textBox1.Text += String.Format("\r\n{0} {1} {2}", English[i], Chinese[i], Category[i]);
                }
            }
            else if (AddOrSearchBtn.Text == "搜尋")
            {
                textBox1.Text = "";


                if (EnglishCheckBox.Checked && !ChineseCheckBox.Checked && !CategoryCheckBox.Checked)
                {
                    for (int i = 0; i < English.Count; i++)
                    {
                        if (English[i] == EnglishTextBox.Text)
                        {
                            textBox1.Text += String.Format("\r\n{0} {1} {2}", English[i], Chinese[i], Category[i]);
                        }
                    }
                }
                if (ChineseCheckBox.Checked && !EnglishCheckBox.Checked && !CategoryCheckBox.Checked)
                {
                    for (int i = 0; i < Chinese.Count; i++)
                    {
                        if (Chinese[i] == ChineseTextBox.Text)
                        {
                            textBox1.Text += String.Format("\r\n{0} {1} {2}", English[i], Chinese[i], Category[i]);
                        }
                    }
                }
                if (CategoryCheckBox.Checked && !EnglishCheckBox.Checked && !ChineseCheckBox.Checked)
                {
                    for (int i = 0; i < Category.Count; i++)
                    {
                        if (Category[i] == CategoryComboBox.Text)
                        {
                            textBox1.Text += String.Format("\r\n{0} {1} {2}", English[i], Chinese[i], Category[i]);
                        }
                    }
                }
                if (EnglishCheckBox.Checked && ChineseCheckBox.Checked && !CategoryCheckBox.Checked)
                {
                    for (int i = 0; i < English.Count; i++)
                    {
                        if (English[i] == EnglishTextBox.Text && Chinese[i] == ChineseTextBox.Text)
                        {
                            textBox1.Text += String.Format("\r\n{0} {1} {2}", English[i], Chinese[i], Category[i]);
                        }
                    }
                }
                if (EnglishCheckBox.Checked && CategoryCheckBox.Checked && !ChineseCheckBox.Checked)
                {
                    for (int i = 0; i < English.Count; i++)
                    {
                        if (English[i] == EnglishTextBox.Text && Category[i] == CategoryComboBox.Text)
                        {
                            textBox1.Text += String.Format("\r\n{0} {1} {2}", English[i], Chinese[i], Category[i]);
                        }
                    }
                }
                if (ChineseCheckBox.Checked && CategoryCheckBox.Checked && !EnglishCheckBox.Checked)
                {
                    for (int i = 0; i < English.Count; i++)
                    {
                        if (Chinese[i] == ChineseTextBox.Text && Category[i] == CategoryComboBox.Text)
                        {
                            textBox1.Text += String.Format("\r\n{0} {1} {2}", English[i], Chinese[i], Category[i]);
                        }
                    }
                }
                if (EnglishCheckBox.Checked && ChineseCheckBox.Checked && CategoryCheckBox.Checked)
                {
                    for (int i = 0; i < English.Count; i++)
                    {
                        if (English[i] == EnglishTextBox.Text && Chinese[i] == ChineseTextBox.Text && Category[i] == CategoryComboBox.Text)
                        {
                            textBox1.Text += String.Format("\r\n{0} {1} {2}", English[i], Chinese[i], Category[i]);
                        }
                    }
                }
            }
        }

        public void 字型大小ToolStripMenuItem_Click(object sender, EventArgs e)//檢視-字型大小
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {   //設btnDesign和字型對話方塊設定的字型相同
                textBox1.Font = fontDialog1.Font;
                //設btnDesign前景色和字型對話方塊設定的色彩相同
                textBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void WordTest_Click(object sender, EventArgs e)//檢視-單字測驗
        {
            this.Hide();
            Form2 frm2 = new Form2(this); // 将Form1的实例传递给Form2
            frm2.ShowDialog();             // 用強制回應對話方塊方式來顯示frmPW表單

        }

        private void ShowMarkingItem_Click(object sender, EventArgs e)//檢視-只顯示標記單字
        {
            if (ShowMarkingItem.Text == "只顯示標記單字")
            {
                textBox1.Text = "";
                for (int i = 0; i < English.Count; i++)
                {
                    if (Marking[i] == "yes")
                    {
                        textBox1.Text += String.Format("{0} {1} {2}\r\n", English[i], Chinese[i], Category[i]);
                    }
                }
                ShowMarkingItem.Text = "只顯示標記單字(v)";
            }
            else
            {
                textBox1.Text = "";
                ShowMarkingItem.Text = "只顯示標記單字";
                for (int i = 0; i < English.Count; i++)
                {
                    textBox1.Text += String.Format("{0} {1} {2}\r\n", English[i], Chinese[i], Category[i]);
                }

            }

        }

        private void ClearMarking_Click(object sender, EventArgs e)//檢視-清除標記
        {
            for (int i = 0; i < English.Count; i++)
            {
                Marking[i] = "no";
            }
        }

        private void Exit_Click(object sender, EventArgs e)//檔案-離開
        {
            System.Windows.Forms.Application.Exit(); // 明确使用 System.Windows.Forms.Application
        }
    }
}