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
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace lab6._1
{
    public partial class LogForm : Form
    {
       
        public LogForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm reg = new RegForm();
            reg.StartPosition = FormStartPosition.CenterScreen;
            reg.ShowDialog();
        }

        private void aotorization_Click(object sender, EventArgs e)
        {
            var login = loginBox.Text;
            var password = passwordBox.Text;

            password = ComputeHash(password);

            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-L71DPBIQ;Initial Catalog=regaut;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT login, password, role FROM [user] WHERE login = @uL AND password = @uP";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@uL", login.ToString());
                command.Parameters.AddWithValue("@uP", password.ToString());
               
                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {

                    reader.Close();
                    command.Dispose();
                    

                    string queryRole = "SELECT role FROM [user] WHERE login = @uL";
                    SqlCommand commandRole = new SqlCommand(queryRole, connection);
                    commandRole.Parameters.AddWithValue("@uL", login.ToString());

                    string role = commandRole.ExecuteScalar().ToString();


             
                    if (role.ToString().Equals("Администратор"))
                    {
                        this.Hide();
                        AdminForm adminForm = new AdminForm();
                        adminForm.StartPosition = FormStartPosition.CenterScreen;
                        adminForm.ShowDialog();

                    }
                    else if (role.ToString().Equals("Оператор")) 
                    {
                        this.Hide();
                        OperatorForm operatorForm = new OperatorForm();
                        operatorForm.StartPosition = FormStartPosition.CenterScreen;
                        operatorForm.ShowDialog();
                    }
                    else if (role.ToString().Equals("Абонент"))
                    {
                      
                        this.Hide();
                        
                        AbonentForm abonentForm = new AbonentForm();
                        abonentForm.LOGIN = login;
                        abonentForm.StartPosition = FormStartPosition.CenterScreen;
                        abonentForm.ShowDialog();

                    }
                    commandRole.Dispose();
                }
                else
                {
                    MessageBox.Show("Пароль или логин неверны!");
                }
                
               
                connection.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbonentRegForm abonentForm = new AbonentRegForm();
            abonentForm.StartPosition = FormStartPosition.CenterScreen;
            abonentForm.ShowDialog();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {

        }
    }
}
