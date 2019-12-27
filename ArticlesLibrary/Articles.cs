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
        int i = 0;
        public int Num { get; set; }
        public int Id { get; set; }
        public string Designation { get; set; }
        public double Quantite { get; set; }
        public double PVu { get; set; }
        public string Unite { get; set; }
        public int RefCategorie { get; set; }
        public string Code { get; set; }
        public string Categorie { get; set; }
        public string CodeCateg { get; set; }
        public string QuantiteS { get; set; }
        public string PVt { get; set; }
        public DateTime DateAjout { get; set; }
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
        public int CountRuptureStock()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "COUNT_RUPTURE";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["NbreRupture"] == DBNull.Value)
                        Id = 0;
                    else
                        Id = Convert.ToInt32(dr["NbreRupture"].ToString());

                }
                dr.Dispose();
            }
            return Id;
        }
        public int CountRuptureSoon()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "COUNT_RUPTURE_SUN";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["NbrRupture"] == DBNull.Value)
                        Id = 0;
                    else
                        Id = Convert.ToInt32(dr["NbrRupture"].ToString());

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
        public List<Articles> ArticlesRuptures(string procedure)
        {
            List<Articles> lst = new List<Articles>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(RecuperationRuptures(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        private Articles RecuperationRuptures(IDataReader dr)
        {
            Articles art = new Articles();

            i = i + 1;
            art.Num = i;
            art.Code = dr["Code"].ToString();
            art.Designation = dr["Designation"].ToString();
            art.QuantiteS = dr["Quantite"].ToString();


            return art;
        }
        private Articles RecuperationArticles(IDataReader dr)
        {
            Articles art = new Articles();

            i = i + 1;
            art.Num = i;
            art.Id = Convert.ToInt32(dr["Id"].ToString());
            art.Code = dr["Code"].ToString();
            art.Designation = dr["Articles"].ToString();
            art.CodeCateg = dr["CodeCateg"].ToString();
            art.Categorie = dr["Categorie"].ToString();
            art.QuantiteS = dr["Quantite"].ToString();
            art.PVu = Convert.ToDouble(dr["PVu"].ToString());
            art.PVt = dr["PVT"].ToString();
            art.DateAjout = Convert.ToDateTime(dr["DateAjout"].ToString());
           

            return art;
        }
    }
}
