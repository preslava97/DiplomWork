using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace PiersDCS
{
   
   public class Passenger
    {
        SqlConnection connection;
        SqlCommand command;
        private void connectTo()
        {
            connection = new SqlConnection(@"Data Source=ACER-575G\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True");
            command = connection.CreateCommand();
        }
        public Passenger()
        {
            connectTo();
        }

        private bool v;
        public String Destination { get; set; }
        public String Name { get; set; }
        public String Seat { get; set; }
        public String Gender { get; set; }
        public String Document { get; set; }
        public String Nationality { get; set; }
        public String Birth { get; set; }
        public String BaggagePiece { get; set; }
        public String BaggageWeight { get; set; }
        public String Remarks { get; set; }
        public bool ISOnWaitingList { get; set; }
        public static String ErrorMessage { get; set; }

        public Passenger(string dest, string name, string seat, string gender, string document,
            string nationality, string birth, string bagpiece, string bagweight, string remark) {
            Destination = dest;
            Name = name;
            Seat = seat;
            Gender = gender;
            Document = document;
            Nationality = nationality;
            Birth = birth;
            BaggagePiece = bagpiece;
            BaggageWeight = bagweight;
            Remarks = remark;
        }

        public Passenger(String name, string seat)
        {
            Name = name;

        }

        public Passenger(String name, bool onWaitingList)
        {
            Name = name;
            ISOnWaitingList = onWaitingList;
        }

       /* public Passenger() { }

        public Passenger(string dest, string name, string seat, string document, string nationality, string birth, string remarks, bool v) : this(name, seatcolumn)
        {
            Document = document;
            Nationality = nationality;
            Birth = birth;
            Remarks = remarks;
         
        }*/

        public Passenger(string name)
        {
            Name = name;
        }

        public bool IsValidPassenger(String dest, String Name,String seat, String gender, String document, 
            String nationality, String birth, String bagPiece, String bagWeight, String remark )
        {
            if (Name.Trim().Equals(""))
            {
                ErrorMessage = "Name is Required!";
                return false;
            }
             
           /* int ValidRow;
            if(!int.TryParse(row,out ValidRow) || ValidRow < 1 || ValidRow > 15)
            {
                ErrorMessage = "Valid Seat Row is Required!";
                return false;
            }

            if(column.ToUpper() != "A" && column.ToUpper() !="B" && column.ToUpper() != "C" &&
                column.ToUpper() != "D" && column.ToUpper() != "E" && column.ToUpper() != "F")
            {
                ErrorMessage = "Valid Seat Column is Required! ";
                return false;

            }*/
            return true;
        }

        public bool IsSeatTaken(String seat)
        {
            var isTaken = SeatMap.passengers.Where(p => p.Seat.ToUpper() == seat.ToUpper()).Count();

            return isTaken == 0 ? false : true;
        }

        public List<Passenger> GetPassengersByName(string name)
        {
            return PassengerInfo.passengers.Where(p => p.Name == name).ToList();
        }

        public void AddPassenger(Passenger passenger)
        {
            PassengerInfo.passengers.Add(passenger);
        }
        public void UpdatePassenger(Passenger passenger)
        {
            
        }
        public void DeletePassenger(Passenger passenger)
        {
            Preview.passengers.Remove(passenger);
        }

        public int NumberOfSeatedPassengers()
        {
            return PassengerInfo.passengers.Where(p => p.ISOnWaitingList == false).Count();
        }

        public int NumberOfWaitingPassengers()
        {
            return SeatMap.passengers.Where(p => p.ISOnWaitingList == true).Count();
        }

        public void SelectAll()
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT* FROM PassengerTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
            }
            catch (Exception)
            {
               
                MessageBox.Show("Invalid data! Please, try again!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            return;
        }
    }
}
