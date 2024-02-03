using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace testowa
{
    public partial class testWindow : Form
    {
        public testWindow()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=WEROLAP\SQLEXPRESS;Initial Catalog=DataBaseTest1;Integrated Security=True");


        private void testWindow_Load(object sender, EventArgs e)
        {
            

        }

        private void company_Click(object sender, EventArgs e)
        {

        }

        private void User_Click(object sender, EventArgs e)
        {

        }
    }
}
