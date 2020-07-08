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
    public partial class Preview : Form
    {
        
        public static List<Passenger> passengers;
        private List<Passenger> foundPassengers;
        public Passenger passenger;
        private string viewMode;
        public bool isOperationCancelled;

        public Preview(string viewMode)
        {
            InitializeComponent();
            foundPassengers = viewMode == "delete" ? SeatMap.foundPassengers : SeatMap.passengers;
            passenger = new Passenger();
            passengers = new List<Passenger>();
            isOperationCancelled = false;
            this.viewMode = viewMode;
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piersDCSdatabaseDataSet4.PassengerTable' table. You can move, or remove it, as needed.
            this.passengerTableTableAdapter2.Fill(this.piersDCSdatabaseDataSet4.PassengerTable);
            // TODO: This line of code loads data into the 'piersDCSdatabaseDataSet3.PassengerTable' table. You can move, or remove it, as needed.
            //this.passengerTableTableAdapter1.Fill(this.piersDCSdatabaseDataSet3.PassengerTable);
            // TODO: This line of code loads data into the 'piersDCSdatabaseDataSet.PassengerTable' table. You can move, or remove it, as needed.
           // this.passengerTableTableAdapter.Fill(this.piersDCSdatabaseDataSet.PassengerTable);

            foundPassengers = foundPassengers.OrderBy(c => c.Seat).ToList();
            dgvPreview.DataSource = foundPassengers;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isOperationCancelled = true;
            this.Close();

        }

        private void dgvPreview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dgvPreview.Rows[e.RowIndex];
                txtDest.Text = row.Cells[0].Value.ToString();
                mstxtseat1.Text = row.Cells[1].Value.ToString();
                txtName.Text= row.Cells[2].Value.ToString();
                cmGender.Text= row.Cells[3].Value.ToString();
                mstxtDoc.Text = row.Cells[4].Value.ToString();
                txtNat.Text = row.Cells[5].Value.ToString();
                mstxtBirth.Text= row.Cells[6].Value.ToString();
                txtbagP.Text= row.Cells[7].Value.ToString();
                txtbagW.Text = row.Cells[8].Value.ToString();
                txtbagP.Text = row.Cells[9].Value.ToString();
                gboxRemark.Text = row.Cells[10].Value.ToString();




            }*/
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            
               /* var name = txtName.Text.Trim();
                if (name.Equals(""))
                {
                    MessageBox.Show("Please enter passenger's name!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var passenger = new Passenger(name);
                foundPassengers = passenger.GetPassengersByName(name);

                if (foundPassengers.Count() == 0)
                {
                    MessageBox.Show("Passenger" + name + "does not exist", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Preview frm = new Preview("delete");
                frm.ShowDialog();

                if (frm.isOperationCancelled) return;
                passenger = frm.passenger;
                txtName.Text = passenger.Name;
                mstxtseat1.Text = passenger.SeatRow.ToString();
                mstxtseat2.Text = passenger.SeatColumn;
                 cmGender.Text = passenger.Gender;
                 mstxtDoc.Text = passenger.Document;
                 txtNat.Text = passenger.Nationality;
                 mstxtBirth.Text = passenger.Birth;
                 txtBagP.Text = passenger.BaggagePiece;
                 txtBagW.Text = passenger.BaggageWeight;
                 cmSpec.Text = passenger.Remarks;
                var msg = MessageBox.Show("Delete passenger?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (msg == DialogResult.Yes)
                {
                    passenger.DeletePassenger(passenger);

                    if (passenger.NumberOfSeatedPassengers() == 89 &&
                        passenger.NumberOfWaitingPassengers() > 0)
                    {
                        var index = passengers.FindIndex(p => p.ISOnWaitingList == true);
                        passengers[index].SeatRow = Convert.ToInt32(mstxtseat1.Text);
                        passengers[index].SeatColumn = mstxtseat2.Text;

                        passengers[index].ISOnWaitingList = false;

                        MessageBox.Show("Passenger" + txtName.Text + "was removed from the list" + Environment.NewLine +
                            passengers[index].Name + "was moved from waiting list to the seat" + mstxtseat1.Text + mstxtseat2.Text,
                            "Passengers Removed/Moved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ClearForm();
                }*/
            

        }
    }
}
