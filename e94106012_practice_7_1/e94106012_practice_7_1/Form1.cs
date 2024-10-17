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
        private void AddWord_Function_Reset()//�����������ǉK�^���[������
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

        private void AddNew_Click(object sender, EventArgs e)//�n��-����
        {
            textBox1.Text = "";
            UseOldFile = false;
            List<string> English = new List<string>();
            List<string> Chinese = new List<string>();
            List<string> Category = new List<string>();
            List<string> Marking = new List<string>();
            UseOldFile = false;
        }

        private void OpenOld_Click(object sender, EventArgs e)//�n��-�_���f�n
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
                    if (data == null || data == "") break;         // ���Y���xȡ�ꮅ�����xޒȦ
                    textBox1.Text += (data + "\r\n");
                    string[] words = data.Split(' '); // ʹ�ÿո�ָ��ı�
                    English.Add(words[0]);
                    Chinese.Add(words[1]);
                    Category.Add(words[2]);
                    Marking.Add("no");
                } while (true);
                sr.Close();

            }
        }

        private void SaveText_Click(object sender, EventArgs e)//�n��-����
        {
            FileInfo finfo = new FileInfo(openFileDialog1.FileName);

            if (!UseOldFile)// �z���Ƿ�ʹ���f�n����
            {
                SaveAsNew_Click(sender, e);
            }
            if (ShowMarkingItem.Text == "ֻ�@ʾ��ӛ����(v)")
            {
                MessageBox.Show("Ŀǰֻ����ȡ����ӛ�Ć����!", "֪ͨ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            StreamWriter sw = finfo.CreateText();
            sw.WriteLine(textBox1.Text);
            sw.Flush();
            sw.Close();
        }

        private void SaveAsNew_Click(object sender, EventArgs e)//�n��-����n
        {
            if (ShowMarkingItem.Text == "ֻ�@ʾ��ӛ����(v)")
            {
                MessageBox.Show("Ŀǰֻ����ȡ����ӛ�Ć����!", "֪ͨ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void AddWord_MenuBar_Click(object sender, EventArgs e)//����-��������
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
            AddWord_MenuBar.Text = "��������(v)";
            SearchWord.Text = "�ь�����";
            textBox1.Text = "";
            for (int i = 0; i < English.Count; i++)
            {
                textBox1.Text += String.Format("\r\n{0} {1} {2}", English[i], Chinese[i], Category[i]);
            }

        }

        private void SearchWord_Click(object sender, EventArgs e)//����-�ь�����
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
            AddOrSearchBtn.Text = "�ь�";
            AddWord_MenuBar.Text = "��������";
            SearchWord.Text = "�ь�����(v)";
        }

        private void AddOrSearchBtn_Click(object sender, EventArgs e)//���F�������ֻ����ь�����
        {
            if (AddOrSearchBtn.Text == "����" && !(EnglishTextBox.Text == "") && !(ChineseTextBox.Text == "") && !(CategoryComboBox.Text == ""))
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
            else if (AddOrSearchBtn.Text == "�ь�")
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

        public void ���ʹ�СToolStripMenuItem_Click(object sender, EventArgs e)//�zҕ-���ʹ�С
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {   //�ObtnDesign�����͌�Ԓ���K�O����������ͬ
                textBox1.Font = fontDialog1.Font;
                //�ObtnDesignǰ��ɫ�����͌�Ԓ���K�O����ɫ����ͬ
                textBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void WordTest_Click(object sender, EventArgs e)//�zҕ-���֜y�
        {
            this.Hide();
            Form2 frm2 = new Form2(this); // ��Form1��ʵ�����ݸ�Form2
            frm2.ShowDialog();             // �Ï��ƻؑ���Ԓ���K��ʽ���@ʾfrmPW���

        }

        private void ShowMarkingItem_Click(object sender, EventArgs e)//�zҕ-ֻ�@ʾ��ӛ����
        {
            if (ShowMarkingItem.Text == "ֻ�@ʾ��ӛ����")
            {
                textBox1.Text = "";
                for (int i = 0; i < English.Count; i++)
                {
                    if (Marking[i] == "yes")
                    {
                        textBox1.Text += String.Format("{0} {1} {2}\r\n", English[i], Chinese[i], Category[i]);
                    }
                }
                ShowMarkingItem.Text = "ֻ�@ʾ��ӛ����(v)";
            }
            else
            {
                textBox1.Text = "";
                ShowMarkingItem.Text = "ֻ�@ʾ��ӛ����";
                for (int i = 0; i < English.Count; i++)
                {
                    textBox1.Text += String.Format("{0} {1} {2}\r\n", English[i], Chinese[i], Category[i]);
                }

            }

        }

        private void ClearMarking_Click(object sender, EventArgs e)//�zҕ-�����ӛ
        {
            for (int i = 0; i < English.Count; i++)
            {
                Marking[i] = "no";
            }
        }

        private void Exit_Click(object sender, EventArgs e)//�n��-�x�_
        {
            System.Windows.Forms.Application.Exit(); // ��ȷʹ�� System.Windows.Forms.Application
        }
    }
}