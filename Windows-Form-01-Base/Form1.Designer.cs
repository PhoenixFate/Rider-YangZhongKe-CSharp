namespace Windows_Forms_01
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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.changeTitleButton = new System.Windows.Forms.Button();
            this.addNumber1 = new System.Windows.Forms.TextBox();
            this.addLabel = new System.Windows.Forms.Label();
            this.addNumber2 = new System.Windows.Forms.TextBox();
            this.equalButton = new System.Windows.Forms.Button();
            this.finalNumber = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.domainInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(84, 44);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(191, 38);
            this.titleBox.TabIndex = 0;
            // 
            // changeTitleButton
            // 
            this.changeTitleButton.Location = new System.Drawing.Point(315, 37);
            this.changeTitleButton.Name = "changeTitleButton";
            this.changeTitleButton.Size = new System.Drawing.Size(169, 51);
            this.changeTitleButton.TabIndex = 1;
            this.changeTitleButton.Text = "设置标题";
            this.changeTitleButton.UseVisualStyleBackColor = true;
            this.changeTitleButton.Click += new System.EventHandler(this.changeButtonClick);
            // 
            // addNumber1
            // 
            this.addNumber1.Location = new System.Drawing.Point(78, 143);
            this.addNumber1.Name = "addNumber1";
            this.addNumber1.Size = new System.Drawing.Size(167, 38);
            this.addNumber1.TabIndex = 2;
            // 
            // addLabel
            // 
            this.addLabel.Location = new System.Drawing.Point(289, 146);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(54, 39);
            this.addLabel.TabIndex = 3;
            this.addLabel.Text = "+";
            // 
            // addNumber2
            // 
            this.addNumber2.Location = new System.Drawing.Point(349, 146);
            this.addNumber2.Name = "addNumber2";
            this.addNumber2.Size = new System.Drawing.Size(153, 38);
            this.addNumber2.TabIndex = 4;
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(538, 141);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(63, 46);
            this.equalButton.TabIndex = 5;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // finalNumber
            // 
            this.finalNumber.Location = new System.Drawing.Point(651, 140);
            this.finalNumber.Name = "finalNumber";
            this.finalNumber.Size = new System.Drawing.Size(138, 38);
            this.finalNumber.TabIndex = 6;
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(82, 239);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(129, 41);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "邮箱";
            this.emailLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(201, 239);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(337, 38);
            this.emailInput.TabIndex = 8;
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(586, 234);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(174, 45);
            this.analyzeButton.TabIndex = 9;
            this.analyzeButton.Text = "分析";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(84, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 49);
            this.label1.TabIndex = 10;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(84, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 54);
            this.label2.TabIndex = 11;
            this.label2.Text = "域名";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(207, 319);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(351, 38);
            this.usernameInput.TabIndex = 12;
            // 
            // domainInput
            // 
            this.domainInput.Location = new System.Drawing.Point(193, 399);
            this.domainInput.Name = "domainInput";
            this.domainInput.Size = new System.Drawing.Size(381, 38);
            this.domainInput.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 578);
            this.Controls.Add(this.domainInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.finalNumber);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.addNumber2);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.addNumber1);
            this.Controls.Add(this.changeTitleButton);
            this.Controls.Add(this.titleBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox domainInput;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox finalNumber;

        private System.Windows.Forms.Button equalButton;

        private System.Windows.Forms.TextBox addNumber1;
        private System.Windows.Forms.TextBox addNumber2;
        private System.Windows.Forms.Label addLabel;

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Button changeTitleButton;

        #endregion
    }
}