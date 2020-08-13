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
    public partial class Boarding : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=ACER-575G\SQL2019;Initial Catalog=PiersDCSdatabase;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter sda;
        DataSet ds;

        public Boarding()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {/*
            if (listView1.SelectedItems.Count < 1) return;
            var item = listView1.SelectedItems[0];
            listView2.Items.Add((ListViewItem)item.Clone());

            ListView sourceListView = new ListView();
            ListView destListView = new ListView();

            var selected = sourceListView.Items
                                          .Cast<ListViewItem>()
                                          .Where(x => x.Selected)
                                          .ToList();

            foreach (var item in selected)
            {
                sourceListView.Items.Remove(item);
                destListView.Items.Add(item);
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listPassengers.Columns.Add("ID_Board", 60);
            listPassengers.Columns.Add("Seat", 60, HorizontalAlignment.Center);
            listPassengers.Columns.Add("Name", 180, HorizontalAlignment.Center);
            listPassengers.Columns.Add("Status", 60, HorizontalAlignment.Center);

            listPassengers.View = View.Details;

            con.Open();
            cmd = new SqlCommand("select * from PassengerTable", con);
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds, "Boarding");
            con.Close();

            dt = ds.Tables["Boarding"];
            int i;
            for(i=0;i<=dt.Rows.Count - 1; i++)
            {
                listPassengers.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listPassengers.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listPassengers.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
              //  listPassengers.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
            }
        }
    }
}
