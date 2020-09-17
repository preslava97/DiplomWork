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
using System.Text.RegularExpressions;
using System.Globalization;

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


        public PassengerInfo(string Destination)
        {

            InitializeComponent();
            passenger = new Passenger();
            passengers = new List<Passenger>();

            label10.Text = Destination;

        }

        public PassengerInfo()
        {
        }

        string Special;
       

        private void PassengerInfo_Load(object sender, EventArgs e)
        {
            con.Open();
            string selectQuery = "SELECT MAX(ID) FROM PassengerTable";
            cmd = new SqlCommand(selectQuery,con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                int val = int.Parse(sdr[0].ToString()) + 1;
                txtID.Text = val.ToString();

                
            }

            con.Close();

        }

     /*   private void RetrieveID()
        {
            try
            {
                string query = " Select * from PassengerTable where ID=@ID ";

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int value = int.Parse(reader[0].ToString()) + 1;
                    txtID.Text = value.ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }*/


        public string TextBoxValue
        {
            get { return mstxtseat1.Text; }
            set { mstxtseat1.Text = value; }
        }

        public static string dateString { get; private set; }

        public Type ValidatingType { get; set; }

        private void ClearForm()
        {
            
           
        }



        Passenger b = new Passenger();

        private void btnADD_Click_1(object sender, EventArgs e)
        {   con.Open();

           if (txtID.Text == null) { MessageBox.Show("Please input identification number !"); }
           

            if (mstxtDoc.Text.Length == 8) { }
            else { MessageBox.Show("Please enter 8 digit Document Number"); }

           

           

            cmd = new SqlCommand(
                  @"insert into PassengerTable (ID, Destination, Name, Seat, Gender, DocumentNumber, Nationality, Birth, BagPieces, BagWeight, Special) 
            values('" + txtID.Text + "','" + label10.Text+ "', '" + txtName.Text + "', '" + mstxtseat1.Text + "', '" + cmGender.Text + "', '" + mstxtDoc.Text + "', '" +txtNat.Text+ "', '" + textBox1.Text+ "', '" + txtBagP.Text + "', '" + txtBagW.Text + "',  '"+Special+"')", con);
             int i = cmd.ExecuteNonQuery();
            if (i != 0) { MessageBox.Show("Data has saved in Data Base !"); }
            else {
                MessageBox.Show("Error !");
            }

            txtID.Text = "";
            txtName.Text = "";
            mstxtseat1.Text = "";
            cmGender.Text = "";
            mstxtDoc.Text = "";
            txtNat.Text = "";
            textBox1.Text = "";
            txtBagP.Text = "";
            txtBagW.Text = "";
            gboxRemark.Text = "";

            showdata();


            con.Close();
            
        }

       public void showdata()
        {
            sda = new SqlDataAdapter("Select * from PassengerTable", con);
            DataTable dt = new DataTable();

           
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

        

        private void txtDest_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void btnShAll_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

           var Destination = label10.Text;
             var Seat = mstxtseat1.Text;
             var Name = txtName.Text;
             var Gender = cmGender.Text;
             var Document = mstxtDoc.Text;
             var Nationality = txtNat.Text;
             var Birth = textBox1.Text;
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
        private void checkVisa_CheckedChanged(object sender, EventArgs e)
        {
            Special = "Visa";
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

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            
            /*if(txtID.Text != "")
            {

               // con.Open();
                cmd = new SqlCommand("Select Destination, Seat, Name, Gender, DocumentNumber, Nationality, Birth, BagPieces, BagWeight, Special from PassengerTable where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));

                
                SqlDataReader sda = cmd.ExecuteReader();
                 
                while (sda.Read())
                {
                    label10.Text = sda.GetValue(0).ToString();
                    mstxtseat1.Text = sda.GetValue(1).ToString();
                    txtName.Text = sda.GetValue(2).ToString();
                    cmGender.Text = sda.GetValue(3).ToString();
                    mstxtDoc.Text = sda.GetValue(4).ToString();
                    txtNat.Text = sda.GetValue(5).ToString();
                    textBox1.Text = sda.GetValue(6).ToString();
                    txtBagP.Text = sda.GetValue(7).ToString();
                    txtBagW.Text = sda.GetValue(8).ToString();
                    gboxRemark.Text = sda.GetValue(9).ToString();

                }

               
               
           }*/
            //con.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
           /* Regex regex = new Regex(@" (((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d)) $");
            bool isValid = regex.IsMatch(textBox1.Text.Trim());
            DateTime date;
           // DateTime date = DateTime.Parse(dateString);

            isValid = DateTime.TryParseExact(textBox1.Text, "dd/MM/yyyy", new CultureInfo("en"), DateTimeStyles.None, out date);
            if (!isValid) { MessageBox.Show("Valid date"); }
            else { MessageBox.Show("Invalid Date !"); }*/

            con.Open();
            cmd = new SqlCommand("UPDATE PassengerTable SET Destination= '"+label10.Text+ "', Name= '" + txtName.Text + "', Seat= '" + mstxtseat1.Text + "', Gender= '" + cmGender.Text + "', DocumentNumber= '" + mstxtDoc.Text + "', Nationality= '" + txtNat.Text + "', Birth= '" + textBox1.Text + "', BagPieces= '" + txtBagP.Text + "', BagWeight= '" + txtBagW.Text + "', Special= '" +Special+ "' where ID = '" + txtID.Text + "' ", con);

            if (mstxtDoc.Text.Length == 8) { }
            else { MessageBox.Show("Please enter 8 digit Document Number"); }

            

            cmd.ExecuteNonQuery();

            
            con.Close();
            MessageBox.Show("Data is Updated!");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            con.Open();
   

            string message = "Do you want to Delete Passenger ?";
            string title = "Delete";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            DialogResult res = MessageBox.Show(message, title, btn);
            if (res == DialogResult.Yes)
            {
                cmd = new SqlCommand("DELETE from PassengerTable where ID= '" + txtID.Text + "'", con);
                cmd.ExecuteNonQuery();
            }
            else if (res == DialogResult.No)
            {

            }
            con.Close();

            txtID.Text = "";
            label10.Text = "";
            txtName.Text = "";
            mstxtseat1.Text = "";
            cmGender.Text = "";
            mstxtDoc.Text = "";
            txtNat.Text = "";
            textBox1.Text = "";
            txtBagP.Text = "";
            txtBagW.Text = "";
            gboxRemark.Text = "";
        }

        private void mstxtDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow only digit !");
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(\d{1,2})/(\d{1,2})/(\d{4})$");
            Match m = regex.Match(textBox1.Text);
            if (m.Success)
            {
                int dd = int.Parse(m.Groups[1].Value);
                int mm = int.Parse(m.Groups[2].Value);
                int yyyy = int.Parse(m.Groups[3].Value);
                e.Cancel = dd < 1 || dd > 31 || mm < 1 || mm > 12 || yyyy < 1900 || yyyy > 2020;

            }
            else e.Cancel = true;
            if (e.Cancel)
            {
                if(MessageBox.Show("Wrong date format. The correct format is dd/mm/yyyy\n+ dd should be between 1 and 31.\n+ mm should be between 1 and 12.", "Invalid date", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    e.Cancel = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT * FROM PassengerTable WHERE ID = "+ int.Parse(txtID.Text);
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                label10.Text = (dr["Destination"].ToString());
                mstxtseat1.Text = (dr["Seat"].ToString());
                txtName.Text = (dr["Name"].ToString());
                cmGender.Text = (dr["Gender"].ToString());
                mstxtDoc.Text = (dr["DocumentNumber"].ToString());
                txtNat.Text = (dr["Nationality"].ToString());
                textBox1.Text = (dr["Birth"].ToString());
                txtBagP.Text = (dr["BagPieces"].ToString());
                txtBagW.Text = (dr["BagWeight"].ToString());
                gboxRemark.Text = (dr["Special"].ToString());
            }

            con.Close();
        }
    }
    }

