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
    public partial class UC_Sortie : UserControl
    {
        public UC_Sortie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSortie frm = new FrmSortie();
            frm.ShowDialog();
        }
    }
}
