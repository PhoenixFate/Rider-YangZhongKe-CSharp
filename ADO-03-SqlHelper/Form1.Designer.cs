namespace ADO_03_SqlHelper
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
            this.insertButton = new System.Windows.Forms.Button();
            this.totalCountButton = new System.Windows.Forms.Button();
            this.allDataButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(78, 59);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(284, 91);
            this.insertButton.TabIndex = 0;
            this.insertButton.Text = "插入数据";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // totalCountButton
            // 
            this.totalCountButton.Location = new System.Drawing.Point(88, 244);
            this.totalCountButton.Name = "totalCountButton";
            this.totalCountButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalCountButton.Size = new System.Drawing.Size(273, 105);
            this.totalCountButton.TabIndex = 1;
            this.totalCountButton.Text = "总条数";
            this.totalCountButton.UseVisualStyleBackColor = true;
            this.totalCountButton.Click += new System.EventHandler(this.totalCountButton_Click);
            // 
            // allDataButton
            // 
            this.allDataButton.Location = new System.Drawing.Point(99, 454);
            this.allDataButton.Name = "allDataButton";
            this.allDataButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.allDataButton.Size = new System.Drawing.Size(262, 102);
            this.allDataButton.TabIndex = 2;
            this.allDataButton.Text = "所有数据";
            this.allDataButton.UseVisualStyleBackColor = true;
            this.allDataButton.Click += new System.EventHandler(this.allDataButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(99, 624);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(590, 99);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "通过Adapter将整个结果集提交给数据库";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 1027);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.allDataButton);
            this.Controls.Add(this.totalCountButton);
            this.Controls.Add(this.insertButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button updateButton;

        private System.Windows.Forms.Button allDataButton;

        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button totalCountButton;

        #endregion
    }
}