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
    public partial class PassengerInfo : Form
    {
        public static List<Passenger> passengers;
        public static List<Passenger> foundPassengers;
        private Passenger passenger;
        public PassengerInfo()
        {
            InitializeComponent();
            passenger = new Passenger();
            passengers = new List<Passenger>();
        }

        private void PassengerInfo_Load(object sender, EventArgs e)
        {

        }


        private void btnADD_Click(object sender, EventArgs e)
        {
           
            /*if (!passenger.IsValidPassenger(txtName.Text, mstxtseat1.Text, cmGender.Text, mstxtDoc.Text, txtNat.Text, mstxtBirth.Text, txtBagP.Text, txtBagW.Text))
            {
                MessageBox.Show(Passenger.ErrorMessage, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if input is correct, create a passenger object
            passenger = new Passenger(txtName.Text, mstxtseat1.Text,  cmGender.Text, mstxtDoc.Text, txtNat.Text, mstxtBirth.Text, txtBagP.Text, txtBagW.Text);

            if (passenger.NumberOfSeatedPassengers() == 90)
            {
                var msg = MessageBox.Show("The plane is full.Place passenger on the waiting list!", "Full plane", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (msg == DialogResult.Yes)
                    passenger.AddPassenger(new Passenger(passenger.Name, passenger.Gender, passenger.Document, passenger.Nationality, passenger.Birth, passenger.Remarks, true));
                return;
            }

            if (passenger.IsSeatTaken(passenger.SeatRow.ToString(), passenger.SeatColumn))
            {
                MessageBox.Show("Seat is taken. Please select a different seat", "Taken seat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            passenger.AddPassenger(passenger);*/

        }

        private void ClearForm()
        {
            txtDest.Text = "";
            txtName.Text = "";
            mstxtseat1.Text = "";
            cmGender.Text = "";
            mstxtDoc.Text = "";
            txtNat.Text = "";
            mstxtBirth.Text = "";
            txtBagP.Text = "";
            txtBagW.Text = "";
            gboxRemark.Text = "";
           
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        Passenger b = new Passenger();

        private void btnADD_Click_1(object sender, EventArgs e)
        {
            Passenger p = new Passenger();
            p.Destination = txtDest.Text;
            p.Seat = mstxtseat1.Text;
            p.Name = txtName.Text;
            p.Document = mstxtDoc.Text;
            p.Gender = cmGender.Text;
            p.Nationality = txtNat.Text;
            p.BaggagePiece = txtBagP.Text;
            p.BaggageWeight = txtBagW.Text;
            p.Remarks = gboxRemark.Text;
            b.AddPassenger(p);


            /*DataTable dataTable = b.SelectAll();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dgvPreview.DataSource = bindingSource;*/
        }

        private void mstxtseat1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
