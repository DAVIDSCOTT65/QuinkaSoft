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

namespace GUI.UserControls
{
    public partial class UC_Remboursement : UserControl
    {
        public UC_Remboursement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRemboursement frm = new FrmRemboursement();

            frm.ShowDialog();
        }
    }
}
