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
    public class Client
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Noms { get; set; }
        public string Sexe { get; set; }
        public string Telephone { get; set; }
        public int NewId()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(Id) AS LastId FROM Client";

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
        public void Enregistrer(Client cl)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_CLIENT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@id", 5, DbType.Int32, cl.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@code", 20, DbType.String,cl.Code));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@noms", 100, DbType.String, cl.Noms));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@sexe", 5, DbType.String, cl.Sexe));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@phone", 20, DbType.String, cl.Telephone));

                cmd.ExecuteNonQuery();

            }
        }
    }
}
