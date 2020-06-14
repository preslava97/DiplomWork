using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiersDCS
{
    public partial class Preview : Form
    {
        private List<Passenger> foundPassengers;
        public Passenger passenger;
        private string viewMode;
        public bool isOperationCancelled;

        public Preview(string viewMode)
        {
            InitializeComponent();
            foundPassengers = SeatMap.passengers;
            passenger = new Passenger();
            isOperationCancelled = false;
            this.viewMode = viewMode;
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piersDCSdatabaseDataSet3.PassengerTable' table. You can move, or remove it, as needed.
            this.passengerTableTableAdapter.Fill(this.piersDCSdatabaseDataSet3.PassengerTable);

            foundPassengers = foundPassengers.OrderBy(c => c.SeatColumn).OrderBy(r => r.SeatRow).ToList();
            dgvPreview.DataSource = foundPassengers;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isOperationCancelled = true;
            this.Close();

        }

        private void dgvPreview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(viewMode!= "view")
            {
                passenger = (Passenger)dgvPreview.CurrentRow.DataBoundItem;
                Hide();
            }
        }
    }
}
