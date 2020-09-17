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
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();

        public LoginForm()
        {
            InitializeComponent();
            con.ConnectionString = (@"Data Source=ACER-575G\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True");

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
              string CommandText = "select * from [dbo].[Register] Where Username = @Username and Password = @Password";
            con.Open();
            SqlCommand com = new SqlCommand(CommandText, con);
            com.Parameters.AddWithValue("@Username", txtUser.Text.Trim());
            com.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

            SqlDataReader dr = com.ExecuteReader();
            {
                if (dr.HasRows)
                {
                    MessageBox.Show("Login Successful!", "Valid input", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Flights frm = new Flights("Welcome " +txtUser.Text);
                    frm.Show();
                } 
                else
                {
                    MessageBox.Show("Please input valid Username and Password!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            con.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register frm = new Register();
            frm.Show();
        }
    }
}
