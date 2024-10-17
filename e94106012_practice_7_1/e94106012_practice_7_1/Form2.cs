using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace e94106012_practice_7_1
{
    public partial class Form2 : Form
    {
        private Form1 form1; // 用于存储Form1的引用

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1; // 将Form1的引用保存到成员变量中
        }
        int i = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                label1.Text = String.Format("單字:{0}", this.form1.English[i]);
                label2.Text = String.Format("中文:{0}", this.form1.Chinese[i]);
                label3.Text = String.Format("詞性:{0}", this.form1.Category[i]);
                label2.Visible = false;
                label3.Visible = false;
                if (this.form1.Marking[i] == "yes") { checkBox1.Checked = true; }
                else { checkBox1.Checked = false; }
                label1.Font = this.form1.fontDialog1.Font;
                label1.ForeColor = this.form1.fontDialog1.Color;
                label2.Font = this.form1.fontDialog1.Font;
                label2.ForeColor = this.form1.fontDialog1.Color;
                label3.Font = this.form1.fontDialog1.Font;
                label3.ForeColor = this.form1.fontDialog1.Color;
            }

            catch
            {
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label1.Font = this.form1.fontDialog1.Font;
                label1.ForeColor = this.form1.fontDialog1.Color;
                label2.Font = this.form1.fontDialog1.Font;
                label2.ForeColor = this.form1.fontDialog1.Color;
                label3.Font = this.form1.fontDialog1.Font;
                label3.ForeColor = this.form1.fontDialog1.Color;
            }

        }

        private void button1_Click(object sender, EventArgs e)//查看
        {
            if(label2.Visible == false)
            {
                label2.Visible = true;
                label3.Visible = true;
            }
            else
            {
                label2.Visible = false;
                label3.Visible = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)//下一個
        {
            Random rnd = new Random();
            i = rnd.Next(0, this.form1.English.Count);
            label1.Text = String.Format("單字:{0}", this.form1.English[i]);
            label2.Text = String.Format("中文:{0}", this.form1.Chinese[i]);
            label3.Text = String.Format("詞性:{0}", this.form1.Category[i]);
            if (this.form1.Marking[i] == "yes") { checkBox1.Checked = true; }
            else { checkBox1.Checked = false; }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.form1.Marking[i] = "yes";
            }
            else
            {
                this.form1.Marking[i] = "no";
            }
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            this.form1.Show();
        }
    }
}
