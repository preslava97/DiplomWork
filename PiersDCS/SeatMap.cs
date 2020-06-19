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
            if (!passenger.IsValidPassenger(txtName.Text, mstxtseat1.Text, mstxtseat2.Text, cmGender.Text, mstxtDoc.Text, txtNat.Text, mstxtBirth.Text, txtBagP.Text, txtBagW.Text, cmSpec.Text))
            {
                MessageBox.Show(Passenger.ErrorMessage, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if input is correct, create a passenger object
            passenger = new Passenger(txtName.Text, mstxtseat1.Text, mstxtseat2.Text, cmGender.Text, mstxtDoc.Text, txtNat.Text, mstxtBirth.Text, txtBagP.Text, txtBagW.Text, cmSpec.Text);

            if(passenger.NumberOfSeatedPassengers()== 90)
            {
                var msg = MessageBox.Show("The plane is full.Place passenger on the waiting list!","Full plane", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (msg == DialogResult.Yes)
                    passenger.AddPassenger(new Passenger(passenger.Name,passenger.Gender,passenger.Document, passenger.Nationality, passenger.Birth, passenger.Remarks, true));
                return;
            }

            if(passenger.IsSeatTaken(passenger.SeatRow.ToString(), passenger.SeatColumn))
            {
                MessageBox.Show("Seat is taken. Please select a different seat", "Taken seat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            passenger.AddPassenger(passenger);
            PopulateAirplane();
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {

        }

        private void btnSHOW_Click(object sender, EventArgs e)
        {
            Preview frm = new Preview("view");
            frm.ShowDialog();
        }

        private void ClearForm()
        {
            txtName.Text = "";
            mstxtseat1.Text = "";
            mstxtseat2.Text = "";
            cmGender.Text = "";
            mstxtDoc.Text = "";
            txtNat.Text = "";
            mstxtBirth.Text = "";
            txtBagP.Text = "";
            txtBagW.Text = "";
            cmSpec.Text = "";
        }

        private void PopulateAirplane()
        {
            lvseat.Items.Clear();
            passenger = new Passenger();

            string[,] sortedPassengers = new string[15, 6];

            for(int i = 0; i < 15; i++)
            {
                var output = "";
                var col = "";

                for(int c = 0; c < 6; c++)
                {
                    if (c == 0)
                        col = "A";
                    else if (c == 1)
                        col = "B";
                    else if (c == 2)
                        col = "c";
                    else if (c == 3)
                        col = "D";
                    else if (c == 4)
                        col = "E";
                    else
                        col = "F";

                    if (passenger.IsSeatTaken((i + 1).ToString(), col))
                    {
                        if (i + 1 < 15)
                            output += "0" + (i + 1).ToString() + col + "  ";
                        else
                            output += (i + 1).ToString() + col + "  ";
                    }

                    else
                        output += " X ";
                    output += (c == 1 ? "     " : "");
                }
                lvseat.Items.Add(output);
                lvseat.Items.Add("");
            }
        }
    }
}
