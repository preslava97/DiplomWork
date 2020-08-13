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
    public partial class SecondPreview : Form
    {
        public SecondPreview()
        {
            InitializeComponent();
        }

        private void SecondPreview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piersDCSdatabaseDataSet5.AnotherPassngTable' table. You can move, or remove it, as needed.
            this.anotherPassngTableTableAdapter.Fill(this.piersDCSdatabaseDataSet5.AnotherPassngTable);

        }
    }
}
