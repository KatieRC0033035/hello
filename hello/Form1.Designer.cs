namespace hello
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
            this.HelloMessageButton = new System.Windows.Forms.Button();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.TxtBxName2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HelloMessageButton
            // 
            this.HelloMessageButton.Location = new System.Drawing.Point(505, 160);
            this.HelloMessageButton.Name = "HelloMessageButton";
            this.HelloMessageButton.Size = new System.Drawing.Size(75, 23);
            this.HelloMessageButton.TabIndex = 0;
            this.HelloMessageButton.Text = "hello";
            this.HelloMessageButton.UseVisualStyleBackColor = true;
            this.HelloMessageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtBxName
            // 
            this.TxtBxName.Location = new System.Drawing.Point(227, 162);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(100, 20);
            this.TxtBxName.TabIndex = 1;
            // 
            // TxtBxName2
            // 
            this.TxtBxName2.Location = new System.Drawing.Point(370, 162);
            this.TxtBxName2.Name = "TxtBxName2";
            this.TxtBxName2.Size = new System.Drawing.Size(100, 20);
            this.TxtBxName2.TabIndex = 2;
            this.TxtBxName2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtBxName2);
            this.Controls.Add(this.TxtBxName);
            this.Controls.Add(this.HelloMessageButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HelloMessageButton;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.TextBox TxtBxName2;
    }
}

