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
    public partial class FlightReport : Form
    {
        public FlightReport()
        {
            InitializeComponent();
        }

       // private bool firstFound = false;

        private void FlightReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PiersDCSdatabaseDataSet2.PassengerTable' table. You can move, or remove it, as needed.
            this.PassengerTableTableAdapter.Fill(this.PiersDCSdatabaseDataSet2.PassengerTable);


            this.reportViewer1.RefreshReport();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (firstFound)
            //    this.reportViewer1.FindNext();
            //else if (this.reportViewer1.Find(textBox1.Text, 1) >= 0)
            //    firstFound = true;

        }
    }
}
