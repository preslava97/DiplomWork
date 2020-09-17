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
    public partial class AnotherSeatMap : Form
    {
        SqlConnection con = new SqlConnection();

        public static List<Passenger> passengers;
        public static List<Passenger> foundPassengers;

        private Passenger passenger;
        public static string passAntText;

        public AnotherSeatMap()
        {
            InitializeComponent();

            passenger = new Passenger();
            passengers = new List<Passenger>();
            con.ConnectionString = (@"Data Source=ACER-575G\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True");

        }

        private void btn1a_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "01A";
            form2.Show();
        }

        private void btn1b_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "01B";
            form2.Show();
        }

        private void btn1c_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "01C";
            form2.Show();
        }

        private void btn1d_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "01D";
            form2.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void btn1e_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "01E";
            form2.Show();
        }

        private void btn1f_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "01F";
            form2.Show();
        }

        private void btn2a_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "02A";
            form2.Show();
        }

        private void btn2b_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "02B";
            form2.Show();
        }

        private void btn2c_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "02C";
            form2.Show();
        }

        private void btn2d_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "02D";
            form2.Show();
        }

        private void btn2e_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "02E";
            form2.Show();
        }

        private void btn2f_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "02F";
            form2.Show();
        }

        private void btn3a_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "03A";
            form2.Show();
        }

        private void btn3b_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "03B";
            form2.Show();
        }

        private void btn3c_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "03C";
            form2.Show();
        }

        private void btn3d_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "03D";
            form2.Show();
        }

        private void btn3e_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "03E";
            form2.Show();
        }

        private void btn3f_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "01D";
            form2.Show();
        }

        private void btn4a_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "04A";
            form2.Show();
        }

        private void btnFlights_Click(object sender, EventArgs e)
        {
            this.Close();
            Flights ss = new Flights();
            ss.Show();
        }

        private void Preview_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Preview sp = new Preview();
            sp.Show();
        }

        private void btnSHOW_Click(object sender, EventArgs e)
        {
            Preview frm = new Preview();
            frm.ShowDialog();
        }

        private void btn_boarding_Click(object sender, EventArgs e)
        {
            Boarding frm = new Boarding();
            this.Close();
            frm.Show();
        }

        private void btn4b_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "04B";
            form2.Show();
        }

        private void btn4c_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "04C";
            form2.Show();
        }

        private void btn4d_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "04D";
            form2.Show();
        }

        private void btn4e_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "04E";
            form2.Show();
        }

        private void btn4f_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "04F";
            form2.Show();
        }

        private void btn5a_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "05A";
            form2.Show();
        }

        private void btn5b_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "05B";
            form2.Show();
        }

        private void btn5c_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "05C";
            form2.Show();
        }

        private void btn5d_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "05D";
            form2.Show();
        }

        private void btn5e_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "05E";
            form2.Show();
        }

        private void btn5f_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "05F";
            form2.Show();
        }

        private void btn6a_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "06A";
            form2.Show();
        }

        private void btn6b_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "06B";
            form2.Show();
        }

        private void btn6c_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "06C";
            form2.Show();
        }

        private void btn6d_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "06D";
            form2.Show();
        }

        private void btn6e_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "06E";
            form2.Show();
        }

        private void btn6f_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "06F";
            form2.Show();
        }

        private void btn7a_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "07A";
            form2.Show();
        }

        private void btn7b_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "07B";
            form2.Show();
        }

        private void btn7c_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "07C";
            form2.Show();
        }

        private void btn7d_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "07D";
            form2.Show();
        }

        private void btn7e_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "07E";
            form2.Show();
        }

        private void btn7f_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "07F";
            form2.Show();
        }

        private void btn8a_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "08A";
            form2.Show();
        }

        private void btn8b_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "08B";
            form2.Show();
        }

        private void btn8c_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "08C";
            form2.Show();
        }

        private void btn8d_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "08D";
            form2.Show();
        }

        private void btn8e_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "08E";
            form2.Show();
        }

        private void btn8f_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "08F";
            form2.Show();
        }

        private void btn9a_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "09A";
            form2.Show();
        }

        private void btn9b_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "09B";
            form2.Show();
        }

        private void btn9c_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "09C";
            form2.Show();
        }

        private void btn9d_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "09D";
            form2.Show();
        }

        private void btn9e_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "09E";
            form2.Show();
        }

        private void btn9f_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "09F";
            form2.Show();
        }

        private void btn10a_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "10A";
            form2.Show();
        }

        private void btn10b_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "10B";
            form2.Show();
        }

        private void btn10c_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "10C";
            form2.Show();
        }

        private void btn10d_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "10D";
            form2.Show();
        }

        private void btn10e_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "10E";
            form2.Show();
        }

        private void btn10f_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "10F";
            form2.Show();
        }

        private void btn11a_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "11A";
            form2.Show();
        }

        private void btn11b_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "11B";
            form2.Show();
        }

        private void btn11c_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "11C";
            form2.Show();
        }

        private void btn11d_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "11D";
            form2.Show();
        }

        private void btn11e_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "10B";
            form2.Show();
        }

        private void btn11f_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "11F";
            form2.Show();
        }

        private void btn12a_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "12A";
            form2.Show();
        }

        private void btn12b_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "12B";
            form2.Show();
        }

        private void btn12c_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "12C";
            form2.Show();
        }

        private void btn12d_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "12D";
            form2.Show();
        }

        private void btn12e_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "12E";
            form2.Show();
        }

        private void btn12f_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "12F";
            form2.Show();
        }

        private void btn13a_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "13A";
            form2.Show();
        }

        private void btn13b_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "13B";
            form2.Show();
        }

        private void btn13c_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "13C";
            form2.Show();
        }

        private void btn13d_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "13D";
            form2.Show();
        }

        private void btn13e_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "13E";
            form2.Show();
        }

        private void btn13f_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "13F";
            form2.Show();
        }

        private void btn14a_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "14A";
            form2.Show();
        }

        private void btn14b_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "14B";
            form2.Show();
        }

        private void btn14c_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "14C";
            form2.Show();
        }

        private void btn14d_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "14D";
            form2.Show();
        }

        private void btn14e_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "14E";
            form2.Show();
        }

        private void btn14f_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "14F";
            form2.Show();
        }

        private void btn15a_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "15A";
            form2.Show();
        }

        private void btn15b_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "15B";
            form2.Show();
        }

        private void btn15c_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "15C";
            form2.Show();
        }

        private void btn15d_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "15D";
            form2.Show();
        }

        private void btn15e_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "15E";
            form2.Show();
        }

        private void btn15f_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo("" + txtAnotherDest.Text);
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "15F";
            form2.Show();
        }
    }
}
