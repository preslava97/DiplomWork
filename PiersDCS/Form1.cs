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

        string connectionString = @"Data Source=ACER-575G\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True";

        public SignInForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piersDCSdatabaseDataSet2.LogInTable' table. You can move, or remove it, as needed.
            this.logInTableTableAdapter.Fill(this.piersDCSdatabaseDataSet2.LogInTable);

        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(connectionString);
            sqlcon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM LogInTable Where User=1 and Password=1", sqlcon);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
           // dataGridView1.DataSource = dt;

            // FlightdataGridView1.DataSource = dt;
            /*   SqlConnection sqlcon = new SqlConnection(connectionString);
               sqlcon.Open();
               string query = "Select * From LogInTable Where User=1 and Password=1";
              //string query = "Select * from LogInTable Where User= '" + txtUser.Text.Trim() + "' and Password='" + txtPassword.Text.Trim() + "' ";
              SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
               DataTable dt = new DataTable();

               sda.Fill(dt);

               if(dt.Rows.Count == 1)
               {


                   Flights flights = new Flights();
                   this.Hide();
                   flights.Show();
               }
               else
               {
                   MessageBox.Show("Check your Username and Password");
               }
               */

            /* try
             {
                 dbo.LogInTable = new SqlCommand("SELECT * FROM Registration WHERE Contact=@contact and Pas=@password", db.conGetInstance);
                 db.conGetInstance.Open();
                 db.cmdGetInstance.Parameters.AddWithValue("@contact", textBox1.Text);
                 db.cmdGetInstance.Parameters.AddWithValue("@password", ClientSHA256Factory.CalculateHashedPassword(textBox2.Text));
                 SqlDataReader dr = db.cmdGetInstance.ExecuteReader();
                 if (dr.HasRows == true)
                 {
                     MessageBox.Show("Corrected!!!");
                     db.conGetInstance.Close();
                     MenuLogBook frm = new MenuLogBook();
                     frm.Show();
                     this.Hide();
                 }
                 else
                 {
                     MessageBox.Show("Check username and password again!!!");
                     db.conGetInstance.Close();
                     textBox2.ResetText();
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 db.conGetInstance.Close();
             }*/
            // SqlConnection sqlcon = new SqlConnection(@"Data Source=ACER-575G\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True");


            /*string connectionString = @"Data Source=ACER-575G\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM LogInTable Where User= '" + txtUser.Text.Trim() + "' and Password='" + txtPassword.Text.Trim() + "'", sqlCon);
                //SqlDataReader dataReader = new SqlDataReader();

                DataTable dt = new DataTable();
                sqlDa.Fill(dt);

                if(sqlDa.Rows== true)
                {
                    Flights flights = new Flights();
                    this.Hide();
                    flights.Show();
                }

                

            }*/

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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
