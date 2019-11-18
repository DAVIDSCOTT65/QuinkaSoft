using ManageSingleConnexion;
using ParametreConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticlesLibrary
{
    public class Articles
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public double Quantite { get; set; }
        public double PVu { get; set; }
        public string Unite { get; set; }
        public int RefCategorie { get; set; }
        public string Code { get; set; }
        public string Categorie { get; set; }
        public int NewId()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(Id) as LastId FROM Articles";
                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["LastId"] == DBNull.Value)
                        Id = 1;
                    else
                        Id = Convert.ToInt32(dr["LastId"].ToString()) + 1;

                }
                dr.Dispose();
            }
            return Id;
        }
        public void Enregistrer(Articles art)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_ARTICLE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@id", 5, DbType.Int32, art.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@designation", 100, DbType.String, art.Designation));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@pv", 20, DbType.Double, art.PVu));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@unite", 100, DbType.String, art.Unite));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refcateg", 5, DbType.Int32, art.RefCategorie));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@code", 50, DbType.String, art.Code));

                cmd.ExecuteNonQuery();
            }
        }
        public List<Articles> AllArticlesInStock()
        {
            List<Articles> lst = new List<Articles>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_ARTICLES";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(RecuperationArticles(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        private Articles RecuperationArticles(IDataReader dr)
        {
            Articles art = new Articles();

            art.Id = Convert.ToInt32(dr["Id"].ToString());
            art.Code = dr["Code"].ToString();
            art.Designation = dr["Designation"].ToString();
            art.Quantite = Convert.ToDouble(dr["Quantite"].ToString());
            art.PVu = Convert.ToDouble(dr["PVu"].ToString());
            art.Unite = dr["Unite"].ToString();
            art.Categorie = dr["Categorie"].ToString();

            return art;
        }
    }
}
