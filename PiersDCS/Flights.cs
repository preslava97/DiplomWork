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
        public Flights()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=ACER-575G\\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True";

        private void btnFlights_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "Insert into Flights(ID,FlightNumber)"
            }
        }

        private void Flights_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piersDCSdatabaseDataSet.TableFlights' table. You can move, or remove it, as needed.
            this.tableFlightsTableAdapter.Fill(this.piersDCSdatabaseDataSet.TableFlights);

        }
    }
}
