using ManageSingleConnexion;
using ParametreConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreanceLibrary
{
    public class Remboursement
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public double Montant { get; set; }
        public DateTime DateRemboursement { get; set; }
        public string Observation { get; set; }
        public int RefCredit { get; set; }
        public int NewId()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(Id) AS LastId FROM Remboursement";
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
        public void Enregistrer(Remboursement remb)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_REMBOURSEMENT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@id", 5, DbType.Int32, remb.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@code", 20, DbType.String, remb.Code));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@montant", 50, DbType.Double, remb.Montant));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@observation", 50, DbType.String, remb.Observation));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refcredit", 5, DbType.Int32, remb.RefCredit));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@date", 20, DbType.Date, remb.DateRemboursement));

                cmd.ExecuteNonQuery();
            }
        }
    }
}
