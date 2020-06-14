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
    public partial class SeatMap : Form
    {
        public static List<Passenger> passengers;
        private Passenger passenger;
        public SeatMap()
        {
            InitializeComponent();
            passenger = new Passenger();
            passengers = new List<Passenger>();

        }

      

        private void SeatMap_Load(object sender, EventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {

        }

        private void btnDEL_Click(object sender, EventArgs e)
        {

        }

        private void btnSHOW_Click(object sender, EventArgs e)
        {

        }
    }
}
