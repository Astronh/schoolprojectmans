﻿namespace testowa
{
    partial class ThirdWindows
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zgloszeniaBase4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wWO_SERVERDataSet = new testowa.WWO_SERVERDataSet();
            this.fillByNajemca1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.zgloszeniaBase4TableAdapter = new testowa.WWO_SERVERDataSetTableAdapters.ZgloszeniaBase4TableAdapter();
            this.reportButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.dane1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dane1ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tematZgłoszeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorytetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.najemcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zgłaszającyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plikDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.branżaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgloszeniaBase4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wWO_SERVERDataSet)).BeginInit();
            this.fillByNajemca1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tematZgłoszeniaDataGridViewTextBoxColumn,
            this.priorytetDataGridViewTextBoxColumn,
            this.najemcaDataGridViewTextBoxColumn,
            this.zgłaszającyDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.plikDataGridViewImageColumn,
            this.branżaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zgloszeniaBase4BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(77, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1417, 356);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // zgloszeniaBase4BindingSource
            // 
            this.zgloszeniaBase4BindingSource.DataMember = "ZgloszeniaBase4";
            this.zgloszeniaBase4BindingSource.DataSource = this.wWO_SERVERDataSet;
            // 
            // wWO_SERVERDataSet
            // 
            this.wWO_SERVERDataSet.DataSetName = "WWO_SERVERDataSet";
            this.wWO_SERVERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByNajemca1ToolStrip
            // 
            this.fillByNajemca1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dane1ToolStripLabel,
            this.dane1ToolStripTextBox});
            this.fillByNajemca1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByNajemca1ToolStrip.Name = "fillByNajemca1ToolStrip";
            this.fillByNajemca1ToolStrip.Size = new System.Drawing.Size(1574, 25);
            this.fillByNajemca1ToolStrip.TabIndex = 2;
            this.fillByNajemca1ToolStrip.Text = "fillByNajemca1ToolStrip";
            // 
            // zgloszeniaBase4TableAdapter
            // 
            this.zgloszeniaBase4TableAdapter.ClearBeforeFill = true;
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(1354, 431);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(140, 23);
            this.reportButton.TabIndex = 3;
            this.reportButton.Text = "Nowe zgłoszenie";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(1234, 431);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(72, 23);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Wyloguj";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // dane1ToolStripLabel
            // 
            this.dane1ToolStripLabel.Name = "dane1ToolStripLabel";
            this.dane1ToolStripLabel.Size = new System.Drawing.Size(43, 22);
            this.dane1ToolStripLabel.Text = "Dane1:";
            this.dane1ToolStripLabel.Click += new System.EventHandler(this.dane1ToolStripLabel_Click);
            // 
            // dane1ToolStripTextBox
            // 
            this.dane1ToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dane1ToolStripTextBox.Name = "dane1ToolStripTextBox";
            this.dane1ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.dane1ToolStripTextBox.Click += new System.EventHandler(this.dane1ToolStripTextBox_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // tematZgłoszeniaDataGridViewTextBoxColumn
            // 
            this.tematZgłoszeniaDataGridViewTextBoxColumn.DataPropertyName = "TematZgłoszenia";
            this.tematZgłoszeniaDataGridViewTextBoxColumn.HeaderText = "TematZgłoszenia";
            this.tematZgłoszeniaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tematZgłoszeniaDataGridViewTextBoxColumn.Name = "tematZgłoszeniaDataGridViewTextBoxColumn";
            this.tematZgłoszeniaDataGridViewTextBoxColumn.Width = 150;
            // 
            // priorytetDataGridViewTextBoxColumn
            // 
            this.priorytetDataGridViewTextBoxColumn.DataPropertyName = "Priorytet";
            this.priorytetDataGridViewTextBoxColumn.HeaderText = "Priorytet";
            this.priorytetDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priorytetDataGridViewTextBoxColumn.Name = "priorytetDataGridViewTextBoxColumn";
            this.priorytetDataGridViewTextBoxColumn.Width = 150;
            // 
            // najemcaDataGridViewTextBoxColumn
            // 
            this.najemcaDataGridViewTextBoxColumn.DataPropertyName = "Najemca";
            this.najemcaDataGridViewTextBoxColumn.HeaderText = "Najemca";
            this.najemcaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.najemcaDataGridViewTextBoxColumn.Name = "najemcaDataGridViewTextBoxColumn";
            this.najemcaDataGridViewTextBoxColumn.Width = 150;
            // 
            // zgłaszającyDataGridViewTextBoxColumn
            // 
            this.zgłaszającyDataGridViewTextBoxColumn.DataPropertyName = "Zgłaszający";
            this.zgłaszającyDataGridViewTextBoxColumn.HeaderText = "Zgłaszający";
            this.zgłaszającyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.zgłaszającyDataGridViewTextBoxColumn.Name = "zgłaszającyDataGridViewTextBoxColumn";
            this.zgłaszającyDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.Width = 150;
            // 
            // plikDataGridViewImageColumn
            // 
            this.plikDataGridViewImageColumn.DataPropertyName = "Plik";
            this.plikDataGridViewImageColumn.HeaderText = "Plik";
            this.plikDataGridViewImageColumn.MinimumWidth = 8;
            this.plikDataGridViewImageColumn.Name = "plikDataGridViewImageColumn";
            this.plikDataGridViewImageColumn.Width = 150;
            // 
            // branżaDataGridViewTextBoxColumn
            // 
            this.branżaDataGridViewTextBoxColumn.DataPropertyName = "Branża";
            this.branżaDataGridViewTextBoxColumn.HeaderText = "Branża";
            this.branżaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.branżaDataGridViewTextBoxColumn.Name = "branżaDataGridViewTextBoxColumn";
            this.branżaDataGridViewTextBoxColumn.Width = 150;
            // 
            // ThirdWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 519);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.fillByNajemca1ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ThirdWindows";
            this.Text = "Status zgłoszeń";
            this.Load += new System.EventHandler(this.ThirdWindows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgloszeniaBase4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wWO_SERVERDataSet)).EndInit();
            this.fillByNajemca1ToolStrip.ResumeLayout(false);
            this.fillByNajemca1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WWO_SERVERDataSet wWO_SERVERDataSet;
        private System.Windows.Forms.BindingSource zgloszeniaBase4BindingSource;
        private WWO_SERVERDataSetTableAdapters.ZgloszeniaBase4TableAdapter zgloszeniaBase4TableAdapter;
        private System.Windows.Forms.ToolStrip fillByNajemca1ToolStrip;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ToolStripLabel dane1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dane1ToolStripTextBox;
        private System.Windows.Forms.DataGridViewButtonColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tematZgłoszeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorytetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn najemcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zgłaszającyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn plikDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branżaDataGridViewTextBoxColumn;
    }
}