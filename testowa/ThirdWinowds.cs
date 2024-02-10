using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testowa
{
    public partial class ThirdWindows : Form
    {
        public string Dane1 { get; set; }
        public string Dane2 { get; set; }

        public ThirdWindows()
        {
            InitializeComponent();
        }

        private void ThirdWindows_Load(object sender, EventArgs e)
        {
            if (Dane1 == "Admin")
            {
                this.zgloszeniaBase4TableAdapter.Fill(this.wWO_SERVERDataSet.ZgloszeniaBase4);
                reportButton.Text = "Edycja zgłoszenia";
            }
            else
            {
                this.zgloszeniaBase4TableAdapter.FillByNajemca1(this.wWO_SERVERDataSet.ZgloszeniaBase4, Dane1);
            }
            dane1ToolStripLabel.Visible = false;
            dane1ToolStripTextBox.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByNajemca1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.zgloszeniaBase4TableAdapter.FillByNajemca1(this.wWO_SERVERDataSet.ZgloszeniaBase4, dane1ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            SecondWindows form2 = new SecondWindows();
            form2.Dane1 = Dane1;
            form2.Dane2 = Dane2;
            form2.Show();
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void dane1ToolStripLabel_Click(object sender, EventArgs e)
        {

        }

        private void dane1ToolStripTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
