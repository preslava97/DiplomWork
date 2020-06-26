﻿using System;
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
    public partial class Flights : Form
    {
        string connectionString = @"Data Source=ACER-575G\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True";

        public Flights()
        {
            InitializeComponent();
        }

       
        private void btnFlights_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM FlightTable", sqlCon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);


                FlightdataGridView1.DataSource = dt;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
             this.Hide();
             SeatMap frm = new SeatMap();
             frm.Show();
        }

        private void Flights_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piersDCSdatabaseDataSet.FlightTable' table. You can move, or remove it, as needed.
            this.flightTableTableAdapter1.Fill(this.piersDCSdatabaseDataSet.FlightTable);
            // TODO: This line of code loads data into the 'piersDCSdatabaseDataSet1.FlightTable' table. You can move, or remove it, as needed.

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            SignInForm ss = new SignInForm();
            ss.Show();
        }
    }
}
