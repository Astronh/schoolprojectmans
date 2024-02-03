namespace testowa
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bTestWin3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(135, 70);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(191, 20);
            this.txt_login.TabIndex = 0;
            this.txt_login.TextChanged += new System.EventHandler(this.txt_login_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(135, 96);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(191, 20);
            this.txt_password.TabIndex = 1;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(190, 134);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // bTestWin3
            // 
            this.bTestWin3.Location = new System.Drawing.Point(338, 159);
            this.bTestWin3.Margin = new System.Windows.Forms.Padding(2);
            this.bTestWin3.Name = "bTestWin3";
            this.bTestWin3.Size = new System.Drawing.Size(56, 19);
            this.bTestWin3.TabIndex = 5;
            this.bTestWin3.Text = "Win3";
            this.bTestWin3.UseVisualStyleBackColor = true;
            this.bTestWin3.Click += new System.EventHandler(this.bTestWin3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 226);
            this.Controls.Add(this.bTestWin3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_login);
            this.Name = "Form1";
            this.Text = "Panel logowania";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bTestWin3;
    }
}

