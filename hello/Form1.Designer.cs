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
            this.CustomMessageButton = new System.Windows.Forms.Button();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CustomMessageButton
            // 
            this.CustomMessageButton.Location = new System.Drawing.Point(505, 160);
            this.CustomMessageButton.Name = "CustomMessageButton";
            this.CustomMessageButton.Size = new System.Drawing.Size(75, 23);
            this.CustomMessageButton.TabIndex = 0;
            this.CustomMessageButton.Text = "custom";
            this.CustomMessageButton.UseVisualStyleBackColor = true;
            this.CustomMessageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtBxName
            // 
            this.TxtBxName.Location = new System.Drawing.Point(360, 162);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(100, 20);
            this.TxtBxName.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtBxName);
            this.Controls.Add(this.CustomMessageButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CustomMessageButton;
        private System.Windows.Forms.TextBox TxtBxName;
    }
}

