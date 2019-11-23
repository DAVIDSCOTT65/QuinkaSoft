using ManageSingleConnexion;
using ParametreConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Classes
{
    public class DynamicClasses
    {
        SqlDataReader dr = null;

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
    }
}
