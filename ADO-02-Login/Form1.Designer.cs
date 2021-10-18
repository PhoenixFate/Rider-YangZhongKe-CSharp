namespace ADO_02_Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.importFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.exportFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(61, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(61, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(289, 24);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(391, 38);
            this.usernameInput.TabIndex = 2;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(284, 110);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(409, 38);
            this.passwordInput.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(187, 190);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(312, 64);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "登录";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(75, 370);
            this.importButton.Name = "importButton";
            this.importButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.importButton.Size = new System.Drawing.Size(318, 87);
            this.importButton.TabIndex = 5;
            this.importButton.Text = "导入";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(486, 370);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(330, 92);
            this.exportButton.TabIndex = 6;
            this.exportButton.Text = "导出";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // importFileDialog
            // 
            this.importFileDialog.FileName = "importFile";
            // 
            // exportFileDialog
            // 
            this.exportFileDialog.FileName = "exportFile";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(86, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(548, 50);
            this.label3.TabIndex = 7;
            this.label3.Text = "请选择本项目工程中的customer.txt来导入";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 738);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.OpenFileDialog importFileDialog;

        private System.Windows.Forms.OpenFileDialog exportFileDialog;

        private System.Windows.Forms.Button exportButton;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button importButton;

        #endregion
    }
}