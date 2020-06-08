using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PiersDCS
{
    public partial class SignInForm : Form
    {
       

        public SignInForm()
        {
            InitializeComponent();

        }
        public string conString = "Data Source=ACER-575G\\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {


            this.Hide();
            Flights frm = new Flights();
            frm.Show();
        }
    }
}
