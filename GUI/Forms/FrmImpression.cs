using GUI.Classes;
using GUI.Imprimer;
using ManageSingleConnexion;
using ParametreConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class FrmImpression : Form
    {
        DynamicClasses dn = new DynamicClasses();
        string code;
        public FrmImpression()
        {
            InitializeComponent();
        }

        private void FrmImpression_Load(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(aticleCombo, "Designation", "SELECT_ARTICLE");
            dn.chargeNomsCombo(monthCombo, "Mois", "SELECT_MONTH");
            dn.chargeNomsCombo(yearCombo, "Annee", "SELECT_YEAR");
        }
        public void Sortie_Fiche_Stock_Article(string code, string mois, string annee)
        {
            try
            {
                


                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT_FICHE_STOCK_ARTICLE";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@code", 30, DbType.String, code));
                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@mois", 30, DbType.String, mois));
                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@annee", 30, DbType.String, annee));

                    DataSet ds = new DataSet();
                    SqlDataAdapter dscmd = new SqlDataAdapter((SqlCommand)cmd);
                    dscmd.Fill(ds, "Affichage_Details_Historique");

                    CR_Fiche_De_Stock entree = new CR_Fiche_De_Stock();
                    entree.SetDataSource(ds);

                    crystalReportViewer1.ReportSource = entree;
                    crystalReportViewer1.Refresh();


                    

                }




            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        public void Sortie_Liste_Dette_Client(int code)
        {
            try
            {



                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT_DETTE_CLIENT";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@id", 30, DbType.Int32, code));

                    DataSet ds = new DataSet();
                    SqlDataAdapter dscmd = new SqlDataAdapter((SqlCommand)cmd);
                    dscmd.Fill(ds, "Affichage_Details_Dette");

                    CR_Liste_Dette entree = new CR_Liste_Dette();
                    entree.SetDataSource(ds);

                    crystalReportViewer1.ReportSource = entree;
                    crystalReportViewer1.Refresh();




                }




            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        public void Sortie_Facture_Vente(int code)
        {
            try
            {



                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT_FACTURE";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@id", 30, DbType.Int32, code));

                    DataSet ds = new DataSet();
                    SqlDataAdapter dscmd = new SqlDataAdapter((SqlCommand)cmd);
                    dscmd.Fill(ds, "Affichage_Details_Sortie");

                    CR_Facture entree = new CR_Facture();
                    entree.SetDataSource(ds);

                    crystalReportViewer1.ReportSource = entree;
                    crystalReportViewer1.Refresh();




                }




            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        private void yearCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtnLivre.Checked == true)
            {
                if (aticleCombo.Text != "" && monthCombo.Text != "")
                {
                    Sortie_Livre_Caisse_Article(dn.retourCode(aticleCombo.Text), monthCombo.Text, yearCombo.Text);
                }

            }
            else if (rbtnFiche.Checked == true)
            {
                if (aticleCombo.Text != "" && monthCombo.Text != "")
                {
                    Sortie_Fiche_Stock_Article(dn.retourCode(aticleCombo.Text), monthCombo.Text, yearCombo.Text);
                }
            }

        }
        public void Sortie_Livre_Caisse_Article(string code, string mois, string annee)
        {
            try
            {
                FrmImpression frm = new FrmImpression();


                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT_LIVRE_CAISSE";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@code", 30, DbType.String, code));
                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@mois", 30, DbType.String, mois));
                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@annee", 30, DbType.String, annee));

                    DataSet ds = new DataSet();
                    SqlDataAdapter dscmd = new SqlDataAdapter((SqlCommand)cmd);
                    dscmd.Fill(ds, "Affichage_Livre_de_Caisse");

                    CR_Livre_Caisse entree = new CR_Livre_Caisse();
                    entree.SetDataSource(ds);

                    crystalReportViewer1.ReportSource = entree;
                    crystalReportViewer1.Refresh();


                    //frm.Visible = true;

                }




            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

        private void aticleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtnLivre.Checked == true)
            {
                code = dn.retourCode(aticleCombo.Text);
                if (monthCombo.Text != "" && yearCombo.Text != "")
                    Sortie_Livre_Caisse_Article(code, monthCombo.Text, yearCombo.Text);
            }
            else if (rbtnFiche.Checked == true)
            {
                if (monthCombo.Text != "" && yearCombo.Text != "")
                    Sortie_Fiche_Stock_Article(dn.retourCode(aticleCombo.Text), monthCombo.Text, yearCombo.Text);
            }

        }

        private void monthCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtnLivre.Checked == true)
            {
                if (aticleCombo.Text != "" && yearCombo.Text != "")
                    Sortie_Livre_Caisse_Article(dn.retourCode(aticleCombo.Text), monthCombo.Text, yearCombo.Text);
            }
            else if (rbtnFiche.Checked == true)
            {
                if (aticleCombo.Text != "" && yearCombo.Text != "")
                    Sortie_Fiche_Stock_Article(dn.retourCode(aticleCombo.Text), monthCombo.Text, yearCombo.Text);
            }

        }

        private void rbtnLivre_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnLivre.Checked==true)
            {
                if (aticleCombo.Text != "" && yearCombo.Text != "" && monthCombo.Text != "")
                    Sortie_Livre_Caisse_Article(dn.retourCode(aticleCombo.Text), monthCombo.Text, yearCombo.Text);
            }
        }

        private void rbtnFiche_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnFiche.Checked==true)
            {
                if (aticleCombo.Text != "" && yearCombo.Text != "" && monthCombo.Text != "")
                    Sortie_Fiche_Stock_Article(dn.retourCode(aticleCombo.Text), monthCombo.Text, yearCombo.Text);
            }
                
        }
    }
}
