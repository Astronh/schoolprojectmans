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
        public ThirdWindows()
        {
            InitializeComponent();
        }

        private void ThirdWindows_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'wWO_SERVERDataSet.ZgloszeniaBase4' . Możesz go przenieść lub usunąć.
            this.zgloszeniaBase4TableAdapter.Fill(this.wWO_SERVERDataSet.ZgloszeniaBase4);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
