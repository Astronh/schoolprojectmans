namespace testowa
{
    partial class SecondWindows
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
            this.branza_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.Button();
            this.rb_hight = new System.Windows.Forms.RadioButton();
            this.rb_medium = new System.Windows.Forms.RadioButton();
            this.rb_low = new System.Windows.Forms.RadioButton();
            this.priority = new System.Windows.Forms.GroupBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_company = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_company = new System.Windows.Forms.TextBox();
            this.File = new System.Windows.Forms.Label();
            this.FileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_topic = new System.Windows.Forms.TextBox();
            this.logout_button = new System.Windows.Forms.Button();
            this.priority.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodawanie zgłoszenia";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // branza_box
            // 
            this.branza_box.FormattingEnabled = true;
            this.branza_box.Items.AddRange(new object[] {
            "Elektryczna",
            "Budowlana",
            "Wentylacja",
            "Klimatyzacja",
            "Wod-Kan"});
            this.branza_box.Location = new System.Drawing.Point(124, 95);
            this.branza_box.Name = "branza_box";
            this.branza_box.Size = new System.Drawing.Size(121, 21);
            this.branza_box.TabIndex = 3;
            this.branza_box.SelectedIndexChanged += new System.EventHandler(this.branza_box_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Branża:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Opis zgłoszenia:";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(124, 151);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(279, 92);
            this.txt_description.TabIndex = 6;
            this.txt_description.TextChanged += new System.EventHandler(this.txt_description_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Priorytet:";
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(213, 439);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 23);
            this.send_button.TabIndex = 11;
            this.send_button.Text = "Wyślij";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // rb_hight
            // 
            this.rb_hight.AutoSize = true;
            this.rb_hight.Location = new System.Drawing.Point(6, 15);
            this.rb_hight.Name = "rb_hight";
            this.rb_hight.Size = new System.Drawing.Size(60, 17);
            this.rb_hight.TabIndex = 12;
            this.rb_hight.TabStop = true;
            this.rb_hight.Text = "Wysoki";
            this.rb_hight.UseVisualStyleBackColor = true;
            this.rb_hight.CheckedChanged += new System.EventHandler(this.rb_hight_CheckedChanged);
            // 
            // rb_medium
            // 
            this.rb_medium.AutoSize = true;
            this.rb_medium.Location = new System.Drawing.Point(6, 38);
            this.rb_medium.Name = "rb_medium";
            this.rb_medium.Size = new System.Drawing.Size(55, 17);
            this.rb_medium.TabIndex = 12;
            this.rb_medium.TabStop = true;
            this.rb_medium.Text = "Średni";
            this.rb_medium.UseVisualStyleBackColor = true;
            this.rb_medium.CheckedChanged += new System.EventHandler(this.rb_medium_CheckedChanged);
            // 
            // rb_low
            // 
            this.rb_low.AutoSize = true;
            this.rb_low.Location = new System.Drawing.Point(6, 61);
            this.rb_low.Name = "rb_low";
            this.rb_low.Size = new System.Drawing.Size(48, 17);
            this.rb_low.TabIndex = 12;
            this.rb_low.TabStop = true;
            this.rb_low.Text = "Niski";
            this.rb_low.UseVisualStyleBackColor = true;
            this.rb_low.CheckedChanged += new System.EventHandler(this.rb_low_CheckedChanged);
            // 
            // priority
            // 
            this.priority.BackColor = System.Drawing.SystemColors.Menu;
            this.priority.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.priority.Controls.Add(this.rb_hight);
            this.priority.Controls.Add(this.rb_low);
            this.priority.Controls.Add(this.rb_medium);
            this.priority.Location = new System.Drawing.Point(124, 248);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(115, 100);
            this.priority.TabIndex = 13;
            this.priority.TabStop = false;
            this.priority.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(18, 47);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(65, 13);
            this.lb_user.TabIndex = 14;
            this.lb_user.Text = "Użytkownik:";
            // 
            // lb_company
            // 
            this.lb_company.AutoSize = true;
            this.lb_company.Location = new System.Drawing.Point(19, 69);
            this.lb_company.Name = "lb_company";
            this.lb_company.Size = new System.Drawing.Size(35, 13);
            this.lb_company.TabIndex = 14;
            this.lb_company.Text = "Firma:";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(124, 47);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(165, 20);
            this.txt_user.TabIndex = 15;
            // 
            // txt_company
            // 
            this.txt_company.Location = new System.Drawing.Point(124, 69);
            this.txt_company.Name = "txt_company";
            this.txt_company.Size = new System.Drawing.Size(165, 20);
            this.txt_company.TabIndex = 15;
            this.txt_company.TextChanged += new System.EventHandler(this.txt_company_TextChanged);
            // 
            // File
            // 
            this.File.AutoSize = true;
            this.File.Location = new System.Drawing.Point(18, 357);
            this.File.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(58, 13);
            this.File.TabIndex = 16;
            this.File.Text = "Załącznik:";
            // 
            // FileButton
            // 
            this.FileButton.Location = new System.Drawing.Point(335, 357);
            this.FileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(66, 21);
            this.FileButton.TabIndex = 17;
            this.FileButton.Text = "Przeglądaj";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(124, 357);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Temat zgłoszenia:";
            // 
            // txt_topic
            // 
            this.txt_topic.Location = new System.Drawing.Point(124, 119);
            this.txt_topic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_topic.Name = "txt_topic";
            this.txt_topic.Size = new System.Drawing.Size(165, 20);
            this.txt_topic.TabIndex = 22;
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(325, 439);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(75, 23);
            this.logout_button.TabIndex = 23;
            this.logout_button.Text = "Cofnij";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // SecondWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 491);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.txt_topic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.File);
            this.Controls.Add(this.txt_company);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lb_company);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.branza_box);
            this.Controls.Add(this.label1);
            this.Name = "SecondWindows";
            this.Text = "Panel zgłoszenia";
            this.Load += new System.EventHandler(this.SecondWindows_Load);
            this.priority.ResumeLayout(false);
            this.priority.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox branza_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.RadioButton rb_hight;
        private System.Windows.Forms.RadioButton rb_medium;
        private System.Windows.Forms.RadioButton rb_low;
        private System.Windows.Forms.GroupBox priority;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_company;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_company;
        private System.Windows.Forms.Label File;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_topic;
        private System.Windows.Forms.Button logout_button;
    }
}