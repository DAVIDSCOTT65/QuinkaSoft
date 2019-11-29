using ManageSingleConnexion;
using ParametreConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortieLibrary
{
    public class Detail_Sortie
    {
        public int Id { get; set; }
        public double Quantite { get; set; }
        public double PVu { get; set; }
        public int RefArticle { get; set; }
        public int RefEntete { get; set; }
        //Declaration des variables de recuperation de données
        int i = 0;
        public int Num { get; set; }
        public string Code { get; set; }
        public string Designation { get; set; }
        public string CodeCteg { get; set; }
        public string Categorie { get; set; }
        public string QuantiteS { get; set; }
        public string PVt { get; set; }
        public DateTime DateSortie { get; set; }
        public int NewId()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(Id) AS LastId FROM Detail_Sortie";

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
        public void Enreistrer(Detail_Sortie det)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_DETAIL_SORTIE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@id", 5, DbType.Int32, det.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@quantite", 10, DbType.Double, det.Quantite));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@pv", 10, DbType.Double, det.PVu));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refarticle", 5, DbType.Int32, det.RefArticle));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refentete", 5, DbType.Int32, det.RefEntete));

                cmd.ExecuteNonQuery();
            }
        }
        public List<Detail_Sortie> AllSortie()
        {
            List<Detail_Sortie> lst = new List<Detail_Sortie>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_ALL_SORTIE";
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
        private Detail_Sortie GetDetails(IDataReader dr)
        {
            Detail_Sortie ds = new Detail_Sortie();

            i = i + 1;

            ds.Num = i;
            ds.Id = Convert.ToInt32(dr["Id"].ToString());
            ds.Code = dr["Code"].ToString();
            ds.Designation = dr["Designation"].ToString();
            ds.CodeCteg = dr["Code_Categ"].ToString();
            ds.Categorie = dr["Categorie"].ToString();
            ds.QuantiteS = dr["Quantite"].ToString();
            ds.PVu = Convert.ToDouble(dr["PVu"].ToString());
            ds.PVt = dr["PVt"].ToString();
            ds.DateSortie = Convert.ToDateTime(dr["Date_Sortie"].ToString());



            return ds;
        }
    }
}
