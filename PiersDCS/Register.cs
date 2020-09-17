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


namespace PiersDCS
{
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string ConnectionString = (@"Data Source=ACER-575G\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True");
        public Register()
        {
            InitializeComponent();
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please fill the empty fields!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    cmd = new SqlCommand("RegisterUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@FirstName", textBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", textBox4.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Successful!", "Valid input", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                Clear();
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
                
                //string CommandText = "select * from [dbo].[Register] Where Username = @Username  Password = @Password FirstName=@FirstName and LastName=@LastName";
                //con.Open();
                //SqlCommand com = new SqlCommand(CommandText, con);
                //com.Parameters.AddWithValue("@Username", textBox1.Text.Trim());
                //com.Parameters.AddWithValue("@Password", textBox2.Text.Trim());
                //com.Parameters.AddWithValue("@FirstName", textBox3.Text.Trim());
                //com.Parameters.AddWithValue("@LastName", textBox4.Text.Trim());

                //SqlDataReader dr = com.ExecuteReader();
                //{
                //    if (dr.HasRows)
                //    {
                //        MessageBox.Show("Login Successful!", "Valid input", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //        this.Hide();
                //        Flights frm = new Flights("Welcome " + textBox1.Text);
                //        frm.Show();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Please input valid Username and Password!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //    }
                //}
                //con.Close();
            }
            void Clear()
            {
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
            
    

