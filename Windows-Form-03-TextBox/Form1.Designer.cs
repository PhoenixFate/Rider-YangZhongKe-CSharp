namespace Windows_Form_03_TextBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.multilineInput = new System.Windows.Forms.TextBox();
            this.addTimeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(82, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "普通输入框";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 38);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(82, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码输入框";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(333, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(365, 38);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(98, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "多行输入框";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // multilineInput
            // 
            this.multilineInput.Location = new System.Drawing.Point(351, 252);
            this.multilineInput.Multiline = true;
            this.multilineInput.Name = "multilineInput";
            this.multilineInput.Size = new System.Drawing.Size(347, 194);
            this.multilineInput.TabIndex = 6;
            // 
            // addTimeButton
            // 
            this.addTimeButton.Location = new System.Drawing.Point(751, 261);
            this.addTimeButton.Name = "addTimeButton";
            this.addTimeButton.Size = new System.Drawing.Size(175, 63);
            this.addTimeButton.TabIndex = 7;
            this.addTimeButton.Text = "多行添加";
            this.addTimeButton.UseVisualStyleBackColor = true;
            this.addTimeButton.Click += new System.EventHandler(this.addTimeButton_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(94, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 59);
            this.label4.TabIndex = 8;
            this.label4.Text = "用户名";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(297, 498);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(376, 38);
            this.usernameInput.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(104, 601);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 40);
            this.label5.TabIndex = 10;
            this.label5.Text = "密码";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(267, 599);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(420, 38);
            this.passwordInput.TabIndex = 11;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(298, 674);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(276, 41);
            this.loginButton.TabIndex = 12;
            this.loginButton.Text = "登录";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 774);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addTimeButton);
            this.Controls.Add(this.multilineInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button loginButton;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameInput;

        private System.Windows.Forms.Button addTimeButton;

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox multilineInput;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}