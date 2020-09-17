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
    public partial class PassengerRepo : Form
    {
        public PassengerRepo()
        {
            InitializeComponent();
        }

        private void PassengerRepo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PiersDCSdatabaseDataSet3.Table_Vienna' table. You can move, or remove it, as needed.
            this.Table_ViennaTableAdapter.Fill(this.PiersDCSdatabaseDataSet3.Table_Vienna);
            // TODO: This line of code loads data into the 'PiersDCSdatabaseDataSet2.PassengerTable' table. You can move, or remove it, as needed.
            this.PassengerTableTableAdapter.Fill(this.PiersDCSdatabaseDataSet2.PassengerTable);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
