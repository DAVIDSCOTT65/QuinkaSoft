using GUI.Forms;
using GUI.Imprimer;
using ManageSingleConnexion;
using ParametreConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Classes
{
    public class DynamicClasses
    {
        SqlDataReader dr = null;
        SqlDataAdapter dt = null;

        public static DynamicClasses _intance = null;

        public static DynamicClasses GetInstance()
        {
            if (_intance == null)
                _intance = new DynamicClasses();
            return _intance;
        }

        public int loginTest(string nom, string password)
        {
            int count = 0;
            int id = 0;
            string username = "";
            string niveau = "";
            string fonction = "";
            string ability = "";
            string etat = "";
            string maison = "";
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "SP_Login";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@pseudo", 50, DbType.String, nom));
                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@pass", 200, DbType.String, password));
                    SqlCommand comande = (SqlCommand)cmd;
                    dr = comande.ExecuteReader();
                    while (dr.Read())
                    {
                        id = Convert.ToInt32(dr["Id"].ToString().Trim());
                        username = dr["noms"].ToString().Trim();
                        fonction = dr["fonction"].ToString().Trim();
                        maison = dr["Maison"].ToString().Trim();
                        count += 1;
                    }
                    if (count == 1)
                    {



                        UserSession.GetInstance().Id = id;
                        UserSession.GetInstance().UserName = username;
                        UserSession.GetInstance().Fonction = fonction;
                        UserSession.GetInstance().Maison = maison;


                    }
                    else
                    {
                        MessageBox.Show("Echec de Connexion.", "Message Serveur...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
            }
            return count;
        }
        public void chargeNomsCombo(ComboBox cmb, string nomChamp, string procedure)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();
                cmb.Items.Clear();

                while (rd.Read())
                {
                    string de = rd[nomChamp].ToString();
                    cmb.Items.Add(de);
                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
        }
        public int retourId(string champCode, string nomTable, string champCondition, string valeur)
        {
            int identifiant = 0;
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = @"select " + champCode + " from " + nomTable + " where " + champCondition + " = '" + valeur + "'";

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    identifiant = int.Parse(rd[champCode].ToString());
                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
            return identifiant;
        }
        public string retourCode(string designation)
        {
            string code = "";
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_CODE_ARTICLE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@designation", 100, DbType.String, designation));

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    code = rd["Code"].ToString();
                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
            return code;
        }
        public void retourInfoCredit(Label champ1, Label champ2, Label champ3, string valeur)
        {
            

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_DETAILS_CREANCE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@valeur", 200, DbType.String, valeur));

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    
                    champ1.Text = rd["Noms"].ToString();
                    champ2.Text = rd["Montant"].ToString();
                    champ3.Text = rd["Date_Paiement"].ToString();
                    

                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
            //return identifiant;

        }
        public double RetourPrixArticle(string valeur)
        {
            double pv = 0;

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_PVU";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@valeur", 200, DbType.String, valeur));

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {

                    pv = Convert.ToDouble(rd["PVu"].ToString());
                    


                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
            return pv;

        }
        public string RetourUniteArticle(string valeur, Label quantite)
        {
            string unite = "";

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_UNITE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@valeur", 200, DbType.String, valeur));

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    if (rd["Unite"] == DBNull.Value || rd["Quantite"]==DBNull.Value)
                    {
                        unite = "Pas d'unité";
                        quantite.Text = "0";
                    }
                        
                    else
                    {
                        unite = rd["Unite"].ToString();
                        quantite.Text = rd["Quantite"].ToString();
                    }
                        

                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
            return unite;

        }
        public void Sortie_Entree_Sortie()
        {
            try
            {
                FrmImpression frm = new FrmImpression();


                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT_ES";
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    DataSet ds = new DataSet();
                    SqlDataAdapter dscmd = new SqlDataAdapter((SqlCommand)cmd);
                    dscmd.Fill(ds, "Affichage_Details_ES");

                    CR_Entree_Sortie entree = new CR_Entree_Sortie();
                    entree.SetDataSource(ds);

                    frm.crystalReportViewer1.ReportSource = entree;
                    frm.crystalReportViewer1.Refresh();


                    frm.Visible = true;

                }




            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        public void Sortie_Fiche_Stock_Article(string code)
        {
            try
            {
                FrmImpression frm = new FrmImpression();


                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT_FICHE_STOCK_ARTICLE";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@code", 30, DbType.String, code));

                    DataSet ds = new DataSet();
                    SqlDataAdapter dscmd = new SqlDataAdapter((SqlCommand)cmd);
                    dscmd.Fill(ds, "Affichage_Details_Historique");

                    CR_Fiche_De_Stock entree = new CR_Fiche_De_Stock();
                    entree.SetDataSource(ds);

                    frm.crystalReportViewer1.ReportSource = entree;
                    frm.crystalReportViewer1.Refresh();


                    frm.Visible = true;

                }




            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
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

                    frm.crystalReportViewer1.ReportSource = entree;
                    frm.crystalReportViewer1.Refresh();


                    //frm.Visible = true;

                }




            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        public void retreivePhoto(string valeur, PictureBox photo, string procedure)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = procedure;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@id", 50, DbType.Int32, valeur));

                    dt = new SqlDataAdapter((SqlCommand)cmd);
                    Object resultat = cmd.ExecuteScalar();
                    if (DBNull.Value == (resultat))
                    {
                    }
                    else
                    {
                        //Byte[] buffer = (Byte[])resultat;
                        //MemoryStream ms = new MemoryStream(buffer);
                        //Image image = Image.FromStream(ms);
                        //photo.Image = image;

                        Byte[] buffer = (Byte[])resultat;
                        MemoryStream ms = new MemoryStream(buffer);
                        Image image = Image.FromStream(ms);
                        photo.Image = image;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cette erreur est survenue lors du chargement de la photo : " + ex.Message);
            }

        }
    }
}
