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
    public partial class FormRepoMos : Form
    {
        public FormRepoMos()
        {
            InitializeComponent();
        }

        private void FormRepoMos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PiersDCSdatabaseDataSet4.Table_Mosscow' table. You can move, or remove it, as needed.
            this.Table_MosscowTableAdapter.Fill(this.PiersDCSdatabaseDataSet4.Table_Mosscow);

            this.reportViewer1.RefreshReport();
        }
    }
}
