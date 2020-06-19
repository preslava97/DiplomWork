using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiersDCS
{
   public class Passenger
    {
        private bool v;

        public String Name { get; set; }
        public String SeatRow { get; set; }
        public String SeatColumn { get; set; }
        public String Gender { get; set; }
        public String Document { get; set; }
        public String Nationality { get; set; }
        public String Birth { get; set; }
        public String BaggagePiece { get; set; }
        public String BaggageWeight { get; set; }
        public String Remarks { get; set; }
        public bool ISOnWaitingList { get; set; }
        public static String ErrorMessage { get; set; }

        public Passenger(string Name, string seatRow, string seatcolumn, string gender, string document, string nationality, string birth, string bagpiece, string bagweight, string remark) {
            Name = Name;
            SeatRow = Convert.ToInt32(seatRow);
            SeatColumn = seatcolumn;
            Gender = gender;
            Document = document;
            Nationality = nationality;
            Birth = birth;
            BaggagePiece = bagpiece;
            BaggageWeight = bagweight;
            Remarks = remark;
        }

        public Passenger(String name, string seatcolumn)
        {
            Name = name;

        }

        public Passenger(String name, bool onWaitingList)
        {
            Name = name;
            ISOnWaitingList = onWaitingList;
        }

        public Passenger() { }

        public Passenger(string name, string seatcolumn, string document, string nationality, string birth, string remarks, bool v) : this(name, seatcolumn)
        {
            Document = document;
            Nationality = nationality;
            Birth = birth;
            Remarks = remarks;
         
        }

        public bool IsValidPassenger(String Name,String seatrow, String seatcolumn, String gender, String document, 
            String nationality, String birth, String bagPiece, String bagWeight, String remark )
        {
            if (Name.Trim().Equals(""))
            {
                ErrorMessage = "Name is Required!";
                return false;
            }
            int ValidRow;
            if(!int.TryParse(seatrow,out ValidRow) || ValidRow < 1 || ValidRow > 15)
            {
                ErrorMessage = "Valid Seat Row is Required!";
                return false;
            }

            if(seatcolumn.ToUpper() != "A" && seatcolumn.ToUpper() !="B" && seatcolumn.ToUpper() != "C" &&
                seatcolumn.ToUpper() != "D" && seatcolumn.ToUpper() != "E" && seatcolumn.ToUpper() != "F")
            {
                ErrorMessage = "Valid Seat Column is Required! ";
                return false;

            }
            return true;
        }

        public bool IsSeatTaken(String seatRow, String seatColumn)
        {
            var isTaken = SeatMap.passengers.Where(p => p.SeatRow == Convert.ToInt32(seatRow) && p.SeatColumn.ToUpper()).Count();

            return isTaken == 0 ? false : true;
        }

        public List<Passenger> GetPassengersByName(string name)
        {
            return SeatMap.passengers.Where(p => p.Name == name).ToList();
        }

        public void AddPassenger(Passenger passenger)
        {
            SeatMap.passengers.Add(passenger);
        }
        public void DeletePassenger(Passenger passenger)
        {
            SeatMap.passengers.Remove(passenger);
        }

        public int NumberOfSeatedPassengers()
        {
            return SeatMap.passengers.Where(p => p.ISOnWaitingList == false).Count();
        }

        public int NumberOfWaitingPassengers()
        {
            return SeatMap.passengers.Where(p => p.ISOnWaitingList == true).Count();
        }
    }
}
