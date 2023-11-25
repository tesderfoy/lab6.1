using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6._1
{
    public partial class AbonentRegForm : Form
    {
        public AbonentRegForm()
        {
            InitializeComponent();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            var name = nameBox.Text;
            var midlleName = midlleNameBox.Text;
            var post = "Абонент";
            var login = loginBox.Text;


            var password = passwordBox.Text;
            var passwordTwo = passwordTwoBox.Text;



            if (IsLogin(login))
            {
                MessageBox.Show("Пользователь с логином: \'" + login + "\' уже существует");
            }
            else
            {
                string connectionString = "Data Source=LAPTOP-L71DPBIQ;Initial Catalog=regaut;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {


                    if (password.Equals(passwordTwo))
                    {
                        password = ComputeHash(password);


                        using (SqlCommand command = new SqlCommand("insert into [user] (name, f_name, login, password, role) values (@uName, @uFName, @login, @password, @role)", connection))
                        {

                            command.Parameters.AddWithValue("@uName", name.ToString());
                            command.Parameters.AddWithValue("@uFName", midlleName.ToString());
                            command.Parameters.AddWithValue("@login", login.ToString());
                            command.Parameters.AddWithValue("@password", password.ToString());
                            command.Parameters.AddWithValue("@role", post.ToString());

                            try
                            {
                                connection.Open();
                                int result = command.ExecuteNonQuery();
                                if (result > 0)
                                {

                                    this.Hide();
                                    LogForm lg = new LogForm();
                                    lg.ShowDialog();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка регистрации: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают");

                    }
                }
            }
        }


        private bool IsLogin(string username)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-L71DPBIQ;Initial Catalog=regaut; Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM [user] WHERE login = @login";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", username);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        public static string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashedBytes = sha256.ComputeHash(inputBytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
