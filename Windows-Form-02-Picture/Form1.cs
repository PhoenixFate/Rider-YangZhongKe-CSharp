using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_02_Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            //检验身份证，大于18岁，则显示图片
            String identityCard = identityCardInput.Text;
            if (identityCard.Length != 18)
            {
                MessageBox.Show("请输入正确的身份证号");
                return;
            }

            String strYear = identityCard.Substring(6, 4);
            int intYear = Convert.ToInt32(strYear);
            if (DateTime.Now.Year - intYear < 18)
            {
                //未满18岁
                MessageBox.Show("未满18岁，不显示图片");
                pictureBox1.Visible = false;
                return;
            }

            pictureBox1.Visible = true;
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            String message = messageInput.Text;
            if (message == null || message.Length == 0)
            {
                return;
            }

            char last = message[message.Length - 1];
            String left = message.Substring(0, message.Length - 1);
            messageInput.Text = last + left;
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            String message = messageInput.Text;
            if (message == null || message.Length == 0)
            {
                return;
            }

            char first = message[0];
            String left = message.Substring(1);
            messageInput.Text = left + first;
        }
    }
}