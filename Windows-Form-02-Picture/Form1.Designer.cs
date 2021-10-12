namespace Windows_Form_02_Picture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.identityCardInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.messageInput = new System.Windows.Forms.TextBox();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 281);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(145, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "身份证号来显示图片";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(590, 458);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(198, 66);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "检查身份证";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // identityCardInput
            // 
            this.identityCardInput.Location = new System.Drawing.Point(136, 473);
            this.identityCardInput.Name = "identityCardInput";
            this.identityCardInput.Size = new System.Drawing.Size(410, 38);
            this.identityCardInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(181, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "请输入一句话，然后点击左右进行转换";
            // 
            // messageInput
            // 
            this.messageInput.Location = new System.Drawing.Point(280, 623);
            this.messageInput.Name = "messageInput";
            this.messageInput.Size = new System.Drawing.Size(230, 38);
            this.messageInput.TabIndex = 5;
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(164, 606);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(95, 80);
            this.leftButton.TabIndex = 6;
            this.leftButton.Text = "<";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(562, 606);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(98, 71);
            this.rightButton.TabIndex = 7;
            this.rightButton.Text = "<";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 810);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.messageInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.identityCardInput);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox messageInput;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button checkButton;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox identityCardInput;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}