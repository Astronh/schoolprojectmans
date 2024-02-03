using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.IO.File;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace testowa
{
    
    public partial class SecondWindows : Form
    {

        public string Dane1 { get; set; }
        public string Dane2 { get; set; }

        string status_rb;
        //string FileName = "";

        public SecondWindows()
        {
            InitializeComponent();
        }


        SqlConnection conn = new SqlConnection(@"Data Source=WWO\SQLEXPRESS;Initial Catalog=WWO_SERVER;Integrated Security=True");

        private void rb_hight_CheckedChanged(object sender, EventArgs e)
        {
            status_rb = "Wysoki";
        }

        private void rb_medium_CheckedChanged(object sender, EventArgs e)
        {
            status_rb = "Średni";
        }

        private void rb_low_CheckedChanged(object sender, EventArgs e)
        {
            status_rb = "Średni";
        }

        private void SecondWindows_Load(object sender, EventArgs e)
        {
            // Wyświetl dane w drugim oknie
            txt_company.Text = Dane1;
            txt_user.Text = Dane2;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void branza_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void send_button_Click(object sender, EventArgs e)
        {
            string branza, opis, prioryty_RB, user, company, topic;
            int rowsAffected;

            branza = branza_box.Text;
            opis = txt_description.Text;
            prioryty_RB = status_rb;
            user = txt_user.Text;
            company = txt_company.Text;
            topic = txt_topic.Text;

            if (txt_description.Text == "" || branza_box.Text == "" || txt_topic.Text == "")
            {
                MessageBox.Show("Wypełnij puste pola.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!rb_hight.Checked && !rb_low.Checked && !rb_medium.Checked)
            {
                MessageBox.Show("Zaznacz priorytet zgłoszenia.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                try
                {
                    conn.Open();

                    //String insertQuery = "INSERT INTO ZgloszeniaBase1 (Branża, Opis, Priorytet, Najemca, Zgłaszający) VALUES (@Branża, @Opis, @Priorytet, @Najemca, @Zgłaszający)";
                    //String insertQuery = "INSERT INTO ZgloszeniaBase2 (Branża, Opis, Priorytet, Najemca, Zgłaszający, Status, Plik, PlikName) VALUES (@Branża, @Opis, @Priorytet, @Najemca, @Zgłaszający, @Status, @Plik, @PlikName)";
                    //String insertQuery = "INSERT INTO ZgloszeniaBase3 (Branża, Opis, Priorytet, Najemca, Zgłaszający, Status, Plik, PlikName) VALUES (@Branża, @Opis, @Priorytet, @Najemca, @Zgłaszający, @Status, @Plik, @PlikName)";


                    if (!string.IsNullOrEmpty(SelectedFileHolder.SelectedFilePath))
                    {
                        String insertQuery = "INSERT INTO ZgloszeniaBase4 (Branża, Opis, Priorytet, Najemca, Zgłaszający, Status, Plik, PlikName, TematZgłoszenia) VALUES (@Branża, @Opis, @Priorytet, @Najemca, @Zgłaszający, @Status, @Plik, @PlikName, @TematZgłoszenia)";

                        // Jeśli jest załącznik, wstaw go do bazy
                        SqlCommand cmd = new SqlCommand(insertQuery, conn);
                        cmd.Parameters.AddWithValue("@Branża", branza_box.Text);
                        cmd.Parameters.AddWithValue("@Opis", txt_description.Text);
                        cmd.Parameters.AddWithValue("@Priorytet", status_rb);
                        cmd.Parameters.AddWithValue("@Najemca", txt_company.Text);
                        cmd.Parameters.AddWithValue("@Zgłaszający", txt_user.Text);
                        cmd.Parameters.AddWithValue("@Status", " Nowe ");
                        cmd.Parameters.AddWithValue("@Plik", SelectedFileHolder.FileBytes);
                        cmd.Parameters.AddWithValue("@PlikName", SelectedFileHolder.SelectedFilePath);
                        cmd.Parameters.AddWithValue("@TematZgłoszenia", txt_topic.Text);

                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        String insertQuery = "INSERT INTO ZgloszeniaBase4 (Branża, Opis, Priorytet, Najemca, Zgłaszający, Status, TematZgłoszenia) VALUES (@Branża, @Opis, @Priorytet, @Najemca, @Zgłaszający, @Status, @TematZgłoszenia)";
                        //String insertQuery = "INSERT INTO ZgloszeniaBase4 (Branża, Opis, Priorytet, Najemca, Zgłaszający, Status, Plik, PlikName) VALUES (@Branża, @Opis, @Priorytet, @Najemca, @Zgłaszający, @Status, @Plik, @PlikName)";

                        // Jeśli jest załącznik, wstaw go do bazy
                        SqlCommand cmd = new SqlCommand(insertQuery, conn);
                        cmd.Parameters.AddWithValue("@Branża", branza_box.Text);
                        cmd.Parameters.AddWithValue("@Opis", txt_description.Text);
                        cmd.Parameters.AddWithValue("@Priorytet", status_rb);
                        cmd.Parameters.AddWithValue("@Najemca", txt_company.Text);
                        cmd.Parameters.AddWithValue("@Zgłaszający", txt_user.Text);
                        cmd.Parameters.AddWithValue("@Status", " Nowe ");
                        cmd.Parameters.AddWithValue("@TematZgłoszenia", txt_topic.Text);
                        //cmd.Parameters.AddWithValue("@Plik", null);
                        //cmd.Parameters.AddWithValue("@PlikName", null);

                        rowsAffected = cmd.ExecuteNonQuery();
                    }

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dodano Twoje zgłoszenie do systemu.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Nie udało się dodać Twojego zgłoszenia.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_company_TextChanged(object sender, EventArgs e)
        {

        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedFileHolder.SelectedFilePath = openFileDialog.FileName;
                textBox1.Text = Path.GetFileName(SelectedFileHolder.SelectedFilePath);

                //Odczytanie pliku do tablicy bajtów
                SelectedFileHolder.FileBytes = ReadAllBytes(SelectedFileHolder.SelectedFilePath);
                SelectedFileHolder.SelectedFilePath = Path.GetFileName(openFileDialog.FileName);
            }

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
    public static class SelectedFileHolder
    {
        public static string SelectedFilePath { get; set; }
        public static byte[] FileBytes { get; set; }
    }

}
