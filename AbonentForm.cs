using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab6._1
{
    public partial class AbonentForm : Form



    {

        public string LOGIN;


        
        public AbonentForm()
        {

            InitializeComponent();
        }

        private void toSendButton_Click(object sender, EventArgs e)
        {

            var textRequest = textRequestBox.Text;
            string currentDate = DateTime.Now.Date.ToString();
            string status = "";


            if(radioButton1.Checked == true)
            {
                status = "Новый";
            }
            else if(radioButton2.Checked == true)
            {
                status = "Требует выезда";
            }
            else if(radioButton3.Checked == true)
            {
                status = "Срочно";
            }


            string connectionString = "Data Source=LAPTOP-L71DPBIQ;Initial Catalog=regaut;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand commandId = new SqlCommand("select id from [user] where login = @login", connection))
                {
                    connection.Open();
                    commandId.Parameters.AddWithValue("@login", LOGIN.ToString());
                    int id = Convert.ToInt32(commandId.ExecuteScalar());

                    commandId.Dispose();


                    using (SqlCommand command = new SqlCommand("insert into request (dataRequest, statusRequest, poroblemText, id_user) values (@data, @status, @text, @id)", connection))
                    {

                        command.Parameters.AddWithValue("@data", currentDate);
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@text", textRequest);
                        command.Parameters.AddWithValue("@id", id);
     

                        try
                        {
                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {

                                MessageBox.Show("Ваша заявка принята ожидайте");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка занисения: " + ex.Message);
                        }
                    }



                }

                connection.Close();
            }

           
                     
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogForm logForm = new LogForm();
            logForm.StartPosition = FormStartPosition.CenterScreen;
            logForm.ShowDialog();


        }

        private void AbonentForm_Load(object sender, EventArgs e)
        {
            nameUser.Text = LOGIN;

           
        }
    }
















}
    

