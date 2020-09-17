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
using System.Configuration;

namespace PiersDCS
{
    public partial class Preview : Form
    {
        SqlConnection con = new SqlConnection();
        public static List<Passenger> passengers;
        public Passenger passenger;

        

        public Preview()
        {
            InitializeComponent();

            passenger = new Passenger();
            passengers = new List<Passenger>();


        }

        DataTable dt = new DataTable();

        private void Preview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piersDCSdatabaseDataSet2.PassengerTable' table. You can move, or remove it, as needed.
            this.passengerTableTableAdapter.Fill(this.piersDCSdatabaseDataSet2.PassengerTable);
           
            //  foundPassengers = foundPassengers.OrderBy(c => c.Seat).ToList();

            var select = "SELECT * FROM FlightTable";
            var c = new SqlConnection(@"Data Source=ACER-575G\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True");
            var dataAdapter = new SqlDataAdapter(select, c);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(dt);
            dgvPrevPassenger.DataSource = dt;

            string mainconn = ConfigurationManager.ConnectionStrings["PiersDCS.Properties.Settings.PiersDCSdatabaseConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(mainconn);
            string sqlquery = "Select City from [dbo].[FlightTable] ";
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
           // DataTable dt = new DataTable();
            sda.Fill(dt);

            comboBox1.DisplayMember = "City";
            comboBox1.DataSource = dt;
            con.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public Preview(DataTable dt)
        {

        }

        private void dgvPrevPassenger_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            /*if(e.RowIndex>=0)
           {
               DataGridViewRow row = this.dgvPreview.Rows[e.RowIndex];
               txtID.Text = row.Cells[0].Value.ToString();
               txtDest.Text = row.Cells[1].Value.ToString();
               mstxtseat1.Text = row.Cells[2].Value.ToString();
               txtName.Text= row.Cells[3].Value.ToString();
               cmGender.Text= row.Cells[4].Value.ToString();
               mstxtDoc.Text = row.Cells[5].Value.ToString();
               txtNat.Text = row.Cells[6].Value.ToString();
               mstxtBirth.Text= row.Cells[7].Value.ToString();
               txtbagP.Text= row.Cells[8].Value.ToString();
               txtbagW.Text = row.Cells[9].Value.ToString();
               txtbagP.Text = row.Cells[10].Value.ToString();
               gboxRemark.Text = row.Cells[11].Value.ToString();




           }*/
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string mainconn = ConfigurationManager.ConnectionStrings["PiersDCS.Properties.Settings.PiersDCSdatabaseConnectionString"].ConnectionString;

        //    SqlConnection con = new SqlConnection(mainconn);
        //    string sqlquery = "Select * from [dbo].[PassengerTable] where Destination = '" + comboBox1.Text.ToString() + "' ";
        //    SqlCommand cmd = new SqlCommand(sqlquery, con);
        //    con.Open();
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    dgvPrevPassenger.DataSource = dt;

        //    con.Close();
        //}

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["PiersDCS.Properties.Settings.PiersDCSdatabaseConnectionString"].ConnectionString;

            SqlConnection con = new SqlConnection(mainconn);
            string sqlquery = "Select * from [dbo].[PassengerTable] where Destination = '" + comboBox1.Text.ToString() + "' ";
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvPrevPassenger.DataSource = dt;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PassengerTable order by ID", con);
            con.Close();

            SqlCommandBuilder cb = new SqlCommandBuilder(sda);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvPrevPassenger.DataSource = dt;
            
        }

        private void dgvPrevPassenger_Click(object sender, EventArgs e)
        {
           

        }
    }
}
