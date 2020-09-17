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
    public partial class Boarding : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ACER-575G\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True");
      
        public Boarding()
        {
            InitializeComponent();
        }
        
        private void Boarding_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piersDCSdatabaseDataSet1.PassengerTable' table. You can move, or remove it, as needed.
            this.passengerTableTableAdapter.Fill(this.piersDCSdatabaseDataSet1.PassengerTable);

            string mainconn = ConfigurationManager.ConnectionStrings["PiersDCS.Properties.Settings.PiersDCSdatabaseConnectionString"].ConnectionString;

            SqlConnection con = new SqlConnection(mainconn);
            string sqlquery = "Select City from [dbo].[FlightTable]";
            SqlCommand cmd = new SqlCommand(sqlquery,con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            comboBox1.DisplayMember = "City";
            comboBox1.DataSource = dt;

            con.Close();

            DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
            check.HeaderText = "Select";
            check.Width = 25;
            check.Name = "dgvCheckb";
            check.DefaultCellStyle.BackColor = Color.LavenderBlush;
            dgvNonBoarded.Columns.Insert(0,check);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Flights fs = new Flights();
            this.Close();
            fs.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["PiersDCS.Properties.Settings.PiersDCSdatabaseConnectionString"].ConnectionString;

            SqlConnection con = new SqlConnection(mainconn);
            string sqlquery = "Select * from [dbo].[PassengerTable] where Destination = '"+comboBox1.Text.ToString()+"' ";
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvNonBoarded.DataSource = dt;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Destination");
            dt.Columns.Add("Name");
            dt.Columns.Add("Seat");

            foreach(DataGridViewRow drv in dgvNonBoarded.Rows)
            {
                bool checkselect = Convert.ToBoolean(drv.Cells["dgvCheckb"].Value);
                if (checkselect)
                {
                    dt.Rows.Add(drv.Cells[1].Value, drv.Cells[2].Value, drv.Cells[3].Value);
                    drv.DefaultCellStyle.BackColor = Color.Gray;
                    drv.DefaultCellStyle.ForeColor = Color.SkyBlue;
                }
                dataGridView2.DataSource = dt;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            FlightReport reportfl = new FlightReport();
            reportfl.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PassengerRepo pasr = new PassengerRepo();
            pasr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormRepoMos mos = new FormRepoMos();
            mos.Show();
        }
    }
}
