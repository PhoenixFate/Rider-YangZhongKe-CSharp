using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_03_TextBox
{
    public partial class Form1 : Form
    {
        private int errorTimes = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void addTimeButton_Click(object sender, EventArgs e)
        {
            multilineInput.AppendText(DateTime.Now.ToString() + "\n");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String username = usernameInput.Text.Trim();
            String password = passwordInput.Text;
            if (username.Equals("admin", StringComparison.OrdinalIgnoreCase)
                && password.Equals("123456"))
            {
                MessageBox.Show("登录成功！");
            }
            else
            {
                errorTimes++;
                if (errorTimes > 3)
                {
                    // 超过3次登录失败退出应用
                    MessageBox.Show("登录失败次数过多，即将退出程序");
                    Application.Exit();
                }
                MessageBox.Show("登录失败! ");
            }
        }
    }
}