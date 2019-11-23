using ManageSingleConnexion;
using ParametreConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Classes
{
    public class ClsMonitoring
    {
        int i = 0;
        public int Num { get; set; }
        public int Id { get; set; }
        public DateTime DateHeure { get; set; }
        public DateTime DateOperation { get; set; }
        public string Operation { get; set; }
        public int Ref_Agent { get; set; }
        public string Noms { get; set; }
        public string Fonction { get; set; }
        //public string UserSession { get; set; }
        public void Enregistrer(ClsMonitoring mon)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_MONITORING";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@operation", 50, DbType.String, mon.Operation));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refagent", 5, DbType.Int32, UserSession.GetInstance().Id));

                cmd.ExecuteNonQuery();
            }
        }
        public List<ClsMonitoring> AllMonitoringToday()
        {
            List<ClsMonitoring> lst = new List<ClsMonitoring>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_MONITORING";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetMonitoring(dr));
                }
                dr.Dispose();
            }

            return lst;
        }
        public List<ClsMonitoring> Research(string recherche)
        {
            List<ClsMonitoring> lst = new List<ClsMonitoring>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                DateTime dt = DateTime.Now;
                string now;
                now = dt.ToString("yyyy-MM-dd");
                cmd.CommandText = "SELECT * FROM Affichage_Details_Monitoring WHERE Date_Operation='" + now.ToString() + "' AND (Noms LIKE '%" + recherche + "%' OR Operation LIKE '" + recherche + "%')";
                //cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lst.Add(GetMonitoring(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        private ClsMonitoring GetMonitoring(IDataReader dr)
        {
            ClsMonitoring mon = new ClsMonitoring();

            i = i + 1;

            mon.Num = i;
            mon.Id = Convert.ToInt32(dr["Id"].ToString());
            mon.DateHeure = Convert.ToDateTime(dr["Date_Heure"].ToString());
            mon.DateOperation = Convert.ToDateTime(dr["Date_Operation"].ToString());
            mon.Operation = dr["Operation"].ToString();
            mon.Ref_Agent = Convert.ToInt32(dr["idagent"].ToString());
            mon.Noms = dr["Noms"].ToString();
            mon.Fonction = dr["Fonction"].ToString();

            return mon;
        }
    }

}
