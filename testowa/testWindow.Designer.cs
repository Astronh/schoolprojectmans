namespace testowa
{
    partial class testWindow
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
            this.company = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Location = new System.Drawing.Point(144, 50);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(35, 13);
            this.company.TabIndex = 0;
            this.company.Text = "label1";
            this.company.Click += new System.EventHandler(this.company_Click);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(144, 103);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(35, 13);
            this.User.TabIndex = 0;
            this.User.Text = "label1";
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // testWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.User);
            this.Controls.Add(this.company);
            this.Name = "testWindow";
            this.Text = "testWindow";
            this.Load += new System.EventHandler(this.testWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label company;
        private System.Windows.Forms.Label User;
    }
}