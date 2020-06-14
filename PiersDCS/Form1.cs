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

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.UserTableTableAdapter.Fill(this.piersDCSdatabaseDataSet1.UserTable);
        }

        
        private void button7_Click(object sender, EventArgs e)
        {
           
            SqlConnection sqlcon = new SqlConnection(@"Data Source=ACER-575G\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True");
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from UserTable where User= '" + txtUser.Text + "' and Password='" + txtPassword.Text + "'", sqlcon);
            DataTable dt = new DataTable();
            
            sda.Fill(dt);

            if(dt.Rows[0][0].ToString()=="1")
            {

               
                Flights flights = new Flights();
                this.Hide();
                flights.Show();
            }
            else
            {
                MessageBox.Show("Check your Username and Password");
            }
            
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flights frm = new Flights();
            this.Hide();
           frm.Show();
        }
    }
}
