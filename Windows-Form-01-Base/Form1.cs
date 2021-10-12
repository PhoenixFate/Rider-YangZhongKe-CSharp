using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void changeButtonClick(object sender, EventArgs e)
        {
            String name = this.titleBox.Text;
            this.Text = String.Format("{0}你好", name);
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            String str1 = addNumber1.Text;
            String str2 = addNumber2.Text;
            int i1, i2;
            if (!int.TryParse(str1, out i1))
            {
                //错误
                MessageBox.Show("第一个数不是合法的正数");
            }

            if (!int.TryParse(str2, out i2))
            {
                MessageBox.Show("第二个不是合法的正数");
            }

            int i3 = i1 + i2;
            finalNumber.Text = Convert.ToString(i3);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            String email = emailInput.Text;
            String[] strs = email.Split('@');
            if (strs.Length != 2)
            {
                MessageBox.Show("请输入合法的邮箱地址！");
                return;
            }

            usernameInput.Text = strs[0];
            domainInput.Text = strs[1];
        }
    }
}