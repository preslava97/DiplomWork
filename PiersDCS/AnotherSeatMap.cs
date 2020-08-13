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


            PassengerInfo form2 = new PassengerInfo();
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "01A";
            form2.Show();
        }

        private void btn1b_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo();
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "01B";
            form2.Show();
        }

        private void btn1c_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo();
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "01C";
            form2.Show();
        }

        private void btn1d_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo();
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


            PassengerInfo form2 = new PassengerInfo();
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "01E";
            form2.Show();
        }

        private void btn1f_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo();
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "01F";
            form2.Show();
        }

        private void btn2a_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo();
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "02A";
            form2.Show();
        }

        private void btn2b_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo();
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "02B";
            form2.Show();
        }

        private void btn2c_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo();
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "02C";
            form2.Show();
        }

        private void btn2d_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo();
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "02D";
            form2.Show();
        }

        private void btn2e_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo();
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "02E";
            form2.Show();
        }

        private void btn2f_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo();
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "02F";
            form2.Show();
        }

        private void btn3a_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo();
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "03A";
            form2.Show();
        }

        private void btn3b_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo();
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "03B";
            form2.Show();
        }

        private void btn3c_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo();
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "03C";
            form2.Show();
        }

        private void btn3d_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo();
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "03D";
            form2.Show();
        }

        private void btn3e_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo();
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "03E";
            form2.Show();
        }

        private void btn3f_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo();
            passAntText = txtAnotherDest.Text;
            form2.TextBoxValue = "01D";
            form2.Show();
        }

        private void btn4a_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Chartreuse;


            PassengerInfo form2 = new PassengerInfo();
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
            SecondPreview sp = new SecondPreview();
            sp.Show();
        }

        private void btnSHOW_Click(object sender, EventArgs e)
        {
            Preview frm = new Preview();
            frm.ShowDialog();
        }
    }
}
