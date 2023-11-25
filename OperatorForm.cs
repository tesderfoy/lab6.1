using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab6._1
{
    public partial class OperatorForm : Form
    {

        
        
        public OperatorForm()
        {
            InitializeComponent();
            Location = new Point(0, 0);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void OperatorForm_Load(object sender, EventArgs e)
        {

            try
            {
                string connectionString = "Data Source=LAPTOP-L71DPBIQ;Initial Catalog=regaut;Integrated Security=True";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string command = "select u.[login], u.[name], r.poroblemText,dataRequest, statusRequest from [user] u, request r where r.id_user = u.id";
                    
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command, connection);
                     DataSet ds = new DataSet();

                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds;





                    
                        
                            
                        
                    
                    
                }


            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            


            




            
        }
    }
}
