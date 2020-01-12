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
    public class Creance
    {
        public int Id { get; set; }
        public double Montant { get; set; }
        public DateTime DatePaiement { get; set; }
        public string Code { get; set; }
        public int RefClient { get; set; }
        public int RefEntete { get; set; }
        public string Observation { get; set; }
        public int NewId()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd=ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(Id) AS LastId FROM Creance";

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["LastId"] == DBNull.Value) Id = 1;
                    else Id = Convert.ToInt32(dr["LastId"].ToString()) + 1;
                }
                dr.Dispose();
            }

            return Id;
        }
        public void Enregistrer(Creance cr)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_CREANCE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@id", 5, DbType.Int32, cr.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@montant", 10, DbType.Double, cr.Montant));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@date", 20, DbType.Date, cr.DatePaiement));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refcli", 5, DbType.Int32, cr.RefClient));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@observation", 100, DbType.String, cr.Observation));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@code", 100, DbType.String, cr.Code));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refcre", 5, DbType.Int32, cr.RefEntete));

                cmd.ExecuteNonQuery();

            }
        }
        public List<Creance> AllCreance()
        {
            List<Creance> lst = new List<Creance>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetCreances(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        private Creance GetCreances(IDataReader dr)
        {
            Creance cr = new Creance();



            return cr;
        }
    }
}
