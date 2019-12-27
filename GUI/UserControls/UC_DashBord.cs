using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArticlesLibrary;
using GUI.Forms;
using CreanceLibrary;

namespace GUI.UserControls
{
    public partial class UC_DashBord : UserControl
    {
        public UC_DashBord()
        {
            InitializeComponent();
        }

        private void UC_DashBord_Load(object sender, EventArgs e)
        {
            ArticleRuptures();
        }
        private void ArticleRuptures()
        {
            Articles art = new Articles();
            Remboursement remb = new Remboursement();
            lblRupture.Text = art.CountRuptureStock().ToString() + " Articles en rupture";
            lblRuptSoon.Text = art.CountRuptureSoon().ToString() + " Articles";
            lblRecouvrement.Text = remb.CountRemboursementToday().ToString() + " Recouvrements";
            lblCredit.Text = remb.CountCredit().ToString() + " dettes";

        }
        private void lblCaisse_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRuptureStock frm = new FrmRuptureStock();
            frm.procedure = "SELECT_RUPTURES_STOCK";
            frm.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRuptureStock frm = new FrmRuptureStock();
            frm.procedure = "RUPTURE_STOCK_SOON";
            frm.label3.Text = "Articles en rupture bientot";
            frm.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRecouvrement frm = new FrmRecouvrement();
            frm.procedure = "SELECT_RECOUVREMENT";
            frm.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRecouvrement frm = new FrmRecouvrement();
            frm.procedure = "SELECT_CREDIT";
            frm.lblTitle.Text = "Toute les dettes";
            frm.ShowDialog();
        }
    }
}
