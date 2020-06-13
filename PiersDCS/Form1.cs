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
      //  public string conString = "Data Source=ACER-575G\\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True";

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
            
            SqlConnection sqlcon = new SqlConnection(@"Data Source=ACER-575G\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from UserTable where User= '" + txtUser.Text + "' and Password='" + txtPassword.Text + "'", sqlcon);
            DataTable dt = new DataTable();
            sqlcon.Open();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*           SqlConnection con = new SqlConnection("Data Source=ACER-575G\\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True");
                       con.Open();

                       SqlCommand cmd = new SqlCommand("Select User, Password from UserTable where ID =@ID", con);
            //           cmd.Parameters.AddWithValue("@ID", int.Parse(textBox3.Text));
                       SqlDataReader da = cmd.ExecuteReader();
                       while (da.Read())
                       {
                           textBox1.Text = da.GetValue(0).ToString();
                           textBox2.Text = da.GetValue(1).ToString();
                       }

                       con.Close();
                   */
        }

    }
}
