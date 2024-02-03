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
using System.Collections;

namespace testowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=WWO\SQLEXPRESS;Initial Catalog=WWO_SERVER;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
         
        private void LoginButton_Click(object sender, EventArgs e)
        {
            String username, user_password;

            try
            {
                String querry = "SELECT * FROM LoginBase WHERE UserName = '"+txt_login.Text+"' AND UserPasword = '"+txt_password.Text+"'";
                conn.Open();

                using (SqlCommand command = new SqlCommand(querry, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            username = txt_login.Text;
                            user_password = txt_password.Text;
                            string UserTenant = reader.GetString(2);
                            string UserData = reader.GetString(3);

                            // do wyświetlania drugiego okienka i przesyłania danych
                            SecondWindows form2 = new SecondWindows();
                            form2.Dane1 = UserTenant;
                            form2.Dane2 = UserData;
                            form2.Show();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Zły Login lub Hasło", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_login.Clear();
                            txt_password.Clear();
                        }
                    }
                }  
            }
            catch
            {
                MessageBox.Show("Zły Login lub Hasło");
            }
            finally
            {
                conn.Close();
            }
        }

        private void bTestWin3_Click(object sender, EventArgs e)
        {
            ThirdWindows form3 = new ThirdWindows();
            form3.Show();
        }
    }
}
