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
    public class Categorie
    {
        int i = 0;
        public int Num { get; set; }
        public int Id { get; set; }
        public string Designation { get; set; }
        public string Code { get; set; }
        public int NewId()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(Id) AS LastId from Categorie";

                IDataReader dr = cmd.ExecuteReader();

                if(dr.Read())
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
        public void Enregistrer(Categorie categ)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_CATEGORIE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@id", 5, DbType.Int32, categ.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@designation", 100,DbType.String, categ.Designation));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@code", 50, DbType.String, categ.Code));
                cmd.ExecuteNonQuery();

            }
        }
        public List<Categorie> AllCategorie()
        {
            List<Categorie> lst = new List<Categorie>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_ALL_CATEGORIE";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetDetails(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        private Categorie GetDetails(IDataReader dr)
        {
            Categorie rem = new Categorie();

            i = i + 1;

            rem.Num = i;
            rem.Id = Convert.ToInt32(dr["NbreArticles"].ToString());
            rem.Code = dr["CodeCateg"].ToString();
            rem.Designation = dr["Categorie"].ToString();

            return rem;
        }
    }
}
