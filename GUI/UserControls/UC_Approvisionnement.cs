using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Forms;
using ApprovisionnementLibrary;

namespace GUI.UserControls
{
    public partial class UC_Approvisionnement : UserControl
    {
        public UC_Approvisionnement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmApprovisionnement frm = new FrmApprovisionnement();

            frm.ShowDialog();
        }

        private void UC_Approvisionnement_Load(object sender, EventArgs e)
        {
            DataList(new Detail_Approvisionnement());
        }
        private void DataList(Detail_Approvisionnement da)
        {
            dgApprov.DataSource = da.AllApprovisionnement();
        }
    }
}
