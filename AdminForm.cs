using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6._1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            Location = new Point(0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm reg = new RegForm();
            reg.StartPosition = FormStartPosition.CenterScreen;
            reg.ShowDialog();
        }
    }
}
