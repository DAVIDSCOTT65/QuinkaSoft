using ManageSingleConnexion;
using ParametreConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovisionnementLibrary
{
    public class Detail_Approvisionnement
    {
        public int Id { get; set; }
        public double Quantite { get; set; }
        public double PAu { get; set; }
        public int RefArticle { get; set; }
        public int RefApprov { get; set; }
        public int NewId()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(Id) AS LastId FROM Detail_Approvisionnement";
                

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
        public void Enregistrer(Detail_Approvisionnement det)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_DETAIL_APPROV";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@id", 5, DbType.Int32, det.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@quantite", 10, DbType.Double, det.Quantite));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@pa", 10, DbType.Double, det.PAu));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refarticle", 5, DbType.String, det.RefArticle));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refapprov", 5, DbType.String, det.RefApprov));

                cmd.ExecuteNonQuery();

            }
        }
        public List<Detail_Approvisionnement> AllApprovisionnement()
        {
            List<Detail_Approvisionnement> lst = new List<Detail_Approvisionnement>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "";
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
        private Detail_Approvisionnement GetDetails(IDataReader dr)
        {
            Detail_Approvisionnement da = new Detail_Approvisionnement();

            


            return da;
        }
    }
}
