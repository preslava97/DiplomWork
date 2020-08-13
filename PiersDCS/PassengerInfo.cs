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
    public partial class PassengerInfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ACER-575G\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;

        public static List<Passenger> passengers;
        public static List<Passenger> foundPassengers;
        private Passenger passenger;
        public PassengerInfo()
        {
            InitializeComponent();
            passenger = new Passenger();
            passengers = new List<Passenger>();
        }

        string Special;
       

        private void PassengerInfo_Load(object sender, EventArgs e)
        {
            if (txtDestMap.Text == "Vienna")
            {
                txtDest.Text = SeatMap.passText;

            }
            else if(txtAnotherDest.Text == "Mosscow Domodedovo") {
                txtDest.Text = AnotherSeatMap.passAntText;

            }


        }

        public string TextBoxValue
        {
            get { return mstxtseat1.Text; }
            set { mstxtseat1.Text = value; }
        }

        public static string dateString { get; private set; }

       // System.ComponentModel.Browsable(false)
        public Type ValidatingType { get; set; }

        private void ClearForm()
        {
            txtID.Text = "";
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


    //    DateTime date = DateTime.Parse(dateString);

        Passenger b = new Passenger();

        private void btnADD_Click_1(object sender, EventArgs e)
        {
           // Preview pp = new Preview();

            con.Open();

              cmd = new SqlCommand(
                  @"insert into PassengerTable (ID_passenger, Destination, Name, Seat, Gender, DocumentNumber, Nationality, Birth, BagPieces, BagWeight, Special) 
            values('" + txtID.Text + "','" + txtDest.Text+ "', '" + txtName.Text + "', '" + mstxtseat1.Text + "', '" + cmGender.Text + "', '" + mstxtDoc.Text + "', '" +txtNat.Text+ "', '" + mstxtBirth.Text + "', '" + txtBagP.Text + "', '" + txtBagW.Text + "',  '"+Special+"')", con);
             int i = cmd.ExecuteNonQuery();
            if (i != 0) { MessageBox.Show("Data has saved in DataBase !"); }
            else {
                MessageBox.Show("Error !");
            }

            /*  SqlConnection con = new SqlConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                con.ConnectionString = (@"Data Source=ACER-575G\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True");
                cmd.Connection = con; 
                cmd.CommandText = (@"INSERT INTO PassengerTable (Destination, Name, Seat, Gender, Document Number, Nationality, Date of birth, Bag Pieces, Bag Weight, Special) VALUES ('" + txtDest.Text + "', '" + txtName.Text + "', '" + mstxtseat1.Text + "', '" + cmGender.Text + "', '" + mstxtDoc.Text + "', '" + txtNat.Text + "','" + mstxtBirth.Text + "', '" + txtBagP.Text + "', '" + txtBagW.Text + "', '" + gboxRemark.Text + "');");
                cmd.ExecuteNonQuery();
                con.Close();*/
            //Adding passenger directly to listview

            ListViewItem list = new ListViewItem(txtID.Text);
            list.SubItems.Add(txtName.Text);
            list.SubItems.Add(mstxtseat1.Text);
            lvPrev.Items.Add(list);

            con.Close();
            showdata();
            
            
            //pp.ShowDialog();

           /* Passenger p = new Passenger();
             p.Destination = txtDest.Text;
             p.Seat = mstxtseat1.Text;
             p.Name = txtName.Text;
             p.Document = mstxtDoc.Text;
             p.Gender = cmGender.Text;
             p.Nationality = txtNat.Text;
             p.BaggagePiece = txtBagP.Text;
             p.BaggageWeight = txtBagW.Text;
             p.Remarks = gboxRemark.Text;
             b.AddPassenger(p);*/
            
          //  DataTable dataTable = b.SelectAll();
          //   BindingSource bindingSource = new BindingSource();
          //   bindingSource.DataSource = dataTable;
            // dgvPrevPassenger.DataSource = bindingSource;
             
        }

       public void showdata()
        {
            sda = new SqlDataAdapter("Select * from PassengerTable", con);
            DataTable dt = new DataTable();

           // sda.Fill(dt);
           // dgvPrevPassenger.DataSource = dt;
        }

        private void mstxtseat1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
           // SeatMap frm = new SeatMap();
           // frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
            b.UpdatePassenger(p);

          /*  DataTable dataTable = b.SelectAll();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dgvPrevPassenger.DataSource = bindingSource;*/

        }

        private void txtDest_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void btnShAll_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

           var Destination = txtDest.Text;
             var Seat = mstxtseat1.Text;
             var Name = txtName.Text;
             var Gender = cmGender.Text;
             var Document = mstxtDoc.Text;
             var Nationality = txtNat.Text;
             var Birth = mstxtBirth.Text;
             var BagPiece = txtBagP.Text;
             var BagWeight = txtBagW.Text;
             var Remark = gboxRemark.Text;


             dt.Columns.Add("Destination");
             dt.Columns.Add("Seat");
             dt.Columns.Add("Name");
             dt.Columns.Add("Gender");
             dt.Columns.Add("Document Number");
             dt.Columns.Add("Nationality");
             dt.Columns.Add("Date of birth");
             dt.Columns.Add("Bag Piece");
             dt.Columns.Add("Bag Weight");
             dt.Columns.Add("Special");

             DataRow dr = dt.NewRow();
             dr["Destination"] = Destination;
             dr["Seat"] = Seat;
             dr["Name"] = Name;
             dr["Gender"] = Gender;
             dr["Document Number"] = Document;
             dr["Nationality"] = Nationality;
             dr["Date of birth"] = Birth;
             dr["Bag Piece"] = BagPiece;
             dr["Bag Weight"] = BagWeight;
             dr["Special"] = Remark;

             dt.Rows.Add(dr);

             Preview frm = new Preview();
           //  frm.AddGridViewRows(Destination, Seat, Name, Gender, Document, Nationality, Birth, BagPiece, BagWeight, Remark);
             frm.Show();
             

            //Test test = new Test();
            //test.Show();
        }

       
        private void gboxRemark_Enter(object sender, EventArgs e)
        {

        }

        private void chUMNR_CheckedChanged(object sender, EventArgs e)
        {
            Special = "Unaccompanied Minor";
        }

        private void chPETS_CheckedChanged(object sender, EventArgs e)
        {
            Special = "PETS";
        }

        private void chMAAS_CheckedChanged(object sender, EventArgs e)
        {
            Special = "Assistance";
        }

        private void chBChair_CheckedChanged(object sender, EventArgs e)
        {
            Special = "Baby chair";
        }

        private void chWCHC_CheckedChanged(object sender, EventArgs e)
        {
            Special = "Wheelchair";
        }

        private void chBLIND_CheckedChanged(object sender, EventArgs e)
        {
            Special = "Blind";
        }

        private void chDEAF_CheckedChanged(object sender, EventArgs e)
        {
            Special = "Deaf";
        }

        private void mstxtBirth_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }

        private void lvPrev_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            Boarding frm = new Boarding();
            this.Close();
            frm.Show();
        }
    }
}
