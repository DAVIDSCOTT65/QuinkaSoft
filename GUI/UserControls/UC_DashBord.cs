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
using ManageSingleConnexion;
using System.Data.SqlClient;
using GUI.Classes;

namespace GUI.UserControls
{
    public partial class UC_DashBord : UserControl
    {
        DynamicClasses dn = new DynamicClasses();
        public UC_DashBord()
        {
            InitializeComponent();
            timer1.Start();
            loadPhoto(UserSession.GetInstance().Id.ToString(), avatarPic);
        }
        void loadPhoto(string id, PictureBox pic)
        {
            DynamicClasses dn = new DynamicClasses();
            dn.retreivePhoto(id, pic, "SELECT_PHOTO");
        }
        private void UC_DashBord_Load(object sender, EventArgs e)
        {
            lblNom.Text = UserSession.GetInstance().UserName +" Connecté(e)";
            lblFonction.Text = UserSession.GetInstance().Fonction;
            dn.chargeNomsCombo(yearCombo, "Annee", "SELECT_YEAR");
            yearCombo.SelectedIndex = 0;
            ArticleRuptures();
            ChartCotisation();

        }
        void ChartCotisation()
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT Mois,SUM(PVT) Montant  FROM Affichage_Details_Sortie WHERE Annee='" + yearCombo.Text.Trim() + "' GROUP BY Mois", (SqlConnection)ImplementeConnexion.Instance.Conn);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                chartWeek.DataSource = dt;




                chartWeek.ChartAreas["ChartAreas1"].AxisX.Title = "Montant";
                chartWeek.ChartAreas["ChartAreas1"].AxisX.Title = "Mois";

                chartWeek.Series["Variation"].XValueMember = "Mois";
                chartWeek.Series["Variation"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
                chartWeek.Series["Variation"].YValueMembers = "Montant";
                chartWeek.Series["Variation"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;


            }
            catch (Exception ex)
            {

                MessageBox.Show("Une erreur est survenue : " + ex.Message);
            }
        }
        private void ArticleRuptures()
        {
            Articles art = new Articles();
            Remboursement remb = new Remboursement();
            lblRupture.Text = art.CountRuptureStock().ToString() + " Articles en rupture";
            lblRuptSoon.Text = art.CountRuptureSoon().ToString() + " Articles";
            lblRecouvrement.Text = remb.CountRemboursementToday().ToString() + " Recouvrements";
            lblCredit.Text = remb.CountCredit().ToString() + " dettes";
            lblPop.Text = art.CountArticlesPop().ToString() + " Articles";
            lblDormant.Text = art.CountStockFixe().ToString() + " Articles";
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

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPopulaire frm = new FrmPopulaire();
            frm.procedure = "SELECT_ARTICLES_POPULAIRE";
            frm.ShowDialog();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPopulaire frm = new FrmPopulaire();
            frm.procedure = "SELECT_STOCK_FIX";
            frm.label3.Text = "Liste des articles jamais vendus";
            frm.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("dd/MM/yyyy HH:MM:ss");
        }

        private void yearCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChartCotisation();
        }
    }
}
