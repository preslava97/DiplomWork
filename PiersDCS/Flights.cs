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
    public partial class Flights : Form
    {
        string connectionString = @"Data Source=ACER-575G\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True";


        public Flights(string Username)
        {
            InitializeComponent();
            label1.Text = Username;
        }

        public Flights()
        {
        }

        private void btnFlights_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM FlightTable", sqlCon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);


                FlightdataGridView1.DataSource = dt;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
             this.Hide();
             SeatMap frm = new SeatMap();
             frm.Show();
        }

        private void Flights_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piersDCSdatabaseDataSet.FlightTable' table. You can move, or remove it, as needed.
            this.flightTableTableAdapter1.Fill(this.piersDCSdatabaseDataSet.FlightTable);
          
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
             string message = "Do you want to Log out ?";
            string title = "Log out";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            DialogResult res = MessageBox.Show(message, title, btn);
            if(res == DialogResult.Yes)
            {
                this.Close();
                LoginForm ss = new LoginForm();
                ss.Show();
            }
            else if(res == DialogResult.No)
            {

            }
        }

        private void FlightDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int RowIndex = FlightdataGridView1.CurrentRow.RowIndex;
            if (e.RowIndex == 0)
            {
                SeatMap frm = new SeatMap();
                frm.txtDestMap.Text = this.FlightdataGridView1.Rows[0].Cells[2].Value.ToString();
                frm.Show();
            }

            else if(e.RowIndex == 1)
            {
                AnotherSeatMap anr = new AnotherSeatMap();
                anr.txtAnotherDest.Text = this.FlightdataGridView1.Rows[1].Cells[2].Value.ToString();
                anr.Show();
            }
           

          
        }

        private void FlightdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             /**   if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = this.FlightdataGridView1.Rows[e.RowIndex];
                    txtDestMap.Text = row.Cells["Vienna"].Value.ToString();
                    txtAnotherDestMap.Text = row.Cells["Mosscow Domodedovo"].Value.ToString();
                    
                }*/



            }
    }
}
