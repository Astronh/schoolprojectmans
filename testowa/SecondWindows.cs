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
using System.Collections;


namespace testowa
{
    
    public partial class SecondWindows : Form
    {

        public string Dane1 { get; set; }
        public string Dane2 { get; set; }

        string status_rb;

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
            this.zgloszeniaBase4TableAdapter1.Fill(this.wWO_SERVERDataSet.ZgloszeniaBase4);
            this.zgloszeniaBase4TableAdapter.Fill(this.wWO_SERVERDataSet1.ZgloszeniaBase4);

            
            if (Dane1 == "Admin")
            {
                priority.Visible = false;
                label1.Text = "Edycja zgłoszenia";
                send_button.Text = "Zapisz";

                txt_description.ReadOnly = true;
                branza_box.Enabled = false;
                txt_user.ReadOnly = true;
                txt_company.ReadOnly = true;
                txt_topic.ReadOnly = true;
                txt_Priority.ReadOnly = true;
                FileButton.Visible = false;
                textBox1.Visible = false;
                File.Visible = false;
            }
            else
            {
                IDList.Visible = false;
                txt_Priority.Visible = false;
                txt_company.Text = Dane1;
                txt_user.Text = Dane2;
                statusLabel.Visible = false;
                statusList.Visible = false;
            }
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

        private void txt_description_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sprawdź, czy TextBox jest w trybie tylko do odczytu
            if (txt_description.ReadOnly)
            {
                // Jeśli naciśnięty klawisz nie jest klawiszem backspace i nie jest to znak nowej linii
                if (e.KeyChar != (char)Keys.Back && e.KeyChar != '\r')
                {
                    // Dopisz wprowadzany znak na koniec istniejącego tekstu
                    txt_description.AppendText(e.KeyChar.ToString());

                    // Zatrzymaj zdarzenie, aby zapobiec domyślnej obsłudze
                    e.Handled = true;
                }
            }
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            string branza, opis, prioryty_RB, user, company, topic;
            int rowsAffected;

            DataRowView selectedRow = (DataRowView)IDList.SelectedItem;
            string selectedId = selectedRow["ID"].ToString();

            //ID = IDList;
            branza = branza_box.Text;
            opis = txt_description.Text;
            prioryty_RB = status_rb;
            user = txt_user.Text;
            company = txt_company.Text;
            topic = txt_topic.Text;


            if (Dane1 != "Admin")
            {
                if (txt_description.Text == "" || branza_box.Text == "" || txt_topic.Text == "")
                {
                    MessageBox.Show("Wypełnij puste pola.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!rb_hight.Checked && !rb_low.Checked && !rb_medium.Checked)
                {
                    MessageBox.Show("Zaznacz priorytet zgłoszenia.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
       
           

                try
                {
                    conn.Open();

                    if (Dane1 == "Admin")
                    {
                        string updateQuery = "UPDATE ZgloszeniaBase4 SET Opis = @NewOpis, Status = @NewStatus WHERE ID = @ID";

                        SqlCommand cmd = new SqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@NewOpis", txt_description.Text);
                        cmd.Parameters.AddWithValue("@NewStatus", statusList.Text);
                        cmd.Parameters.AddWithValue("@ID", selectedId);

                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(SelectedFileHolder.SelectedFilePath))
                        {
                            String insertQuery = "INSERT INTO ZgloszeniaBase4 (Branża, Opis, Priorytet, Najemca, Zgłaszający, Status, Plik, PlikName, TematZgłoszenia) VALUES (@Branża, @Opis, @Priorytet, @Najemca, @Zgłaszający, @Status, @Plik, @PlikName, @TematZgłoszenia)";

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

                            SqlCommand cmd = new SqlCommand(insertQuery, conn);
                            cmd.Parameters.AddWithValue("@Branża", branza_box.Text);
                            cmd.Parameters.AddWithValue("@Opis", txt_description.Text);
                            cmd.Parameters.AddWithValue("@Priorytet", status_rb);
                            cmd.Parameters.AddWithValue("@Najemca", txt_company.Text);
                            cmd.Parameters.AddWithValue("@Zgłaszający", txt_user.Text);
                            cmd.Parameters.AddWithValue("@Status", " Nowe ");
                            cmd.Parameters.AddWithValue("@TematZgłoszenia", txt_topic.Text);

                            rowsAffected = cmd.ExecuteNonQuery();
                        }
                    }
                    if (rowsAffected > 0)
                    {
                        if (Dane1 == "Admin")
                            MessageBox.Show("Zmiany zostały zapisane.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Dodano Twoje zgłoszenie do systemu.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ThirdWindows form3 = new ThirdWindows();
                        form3.Dane1 = Dane1;
                        form3.Dane2 = Dane2;
                        form3.Show();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Nie udało się dodać Twojego zgłoszenia.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch
                {
                    MessageBox.Show("Nie udało się dodać Twojego zgłoszenia.");
                }
                finally
                {
                    conn.Close();
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

        private void IDList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IDList.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)IDList.SelectedItem;
                string selectedId = selectedRow["ID"].ToString();
                string query = "SELECT Branża, Opis, Priorytet, Najemca, Zgłaszający, Status, TematZgłoszenia FROM ZgloszeniaBase4 WHERE ID = @ID";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", selectedId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txt_description.Text = reader["Opis"].ToString();
                        branza_box.Text = reader["Branża"].ToString();
                        txt_user.Text = reader["Zgłaszający"].ToString();
                        txt_company.Text = reader["Najemca"].ToString();
                        txt_topic.Text = reader["TematZgłoszenia"].ToString();
                        statusList.Text = reader["Status"].ToString();
                        txt_Priority.Text = reader["Priorytet"].ToString();
                    }
                     else
                     {
                        txt_description.Text = "Opis nie został znaleziony.";
                     }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas pobierania opisu: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }    
        }

        private void txt_Priority_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            ThirdWindows form3 = new ThirdWindows();
            form3.Dane1 = Dane1;
            form3.Dane2 = Dane2;
            form3.Show();
            this.Close();
        }
    }
    public static class SelectedFileHolder
    {
        public static string SelectedFilePath { get; set; }
        public static byte[] FileBytes { get; set; }
    }

}
