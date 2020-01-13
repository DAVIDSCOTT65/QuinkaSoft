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
using CreanceLibrary;

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

        private void UC_Remboursement_Load(object sender, EventArgs e)
        {
            SelectDatas(new Remboursement());
        }
        void SelectDatas(Remboursement rem)
        {
            dgRembb.DataSource = rem.AllDPayement();
        }

        private void serchTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search(new Remboursement());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Search(Remboursement art)
        {
            dgRembb.DataSource = art.Research(serchTxt.Text);
        }
    }
}
