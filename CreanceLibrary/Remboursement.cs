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
        //Ajout variables pour la recupération des données
        int i = 0;
        public int Num { get; set; }
        public string CodeCredit { get; set; }
        public string MontantR { get; set; }
        public string CodeClient { get; set; }
        public string Client { get; set; }
        public string Sexe { get; set; }
        public string Phone { get; set; }
        
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
        public int CountRemboursementToday()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_COUNT_RECOUVREMENT";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["NbrRecouvre"] == DBNull.Value)
                        Id = 0;
                    else
                        Id = Convert.ToInt32(dr["NbrRecouvre"].ToString());
                }
                dr.Dispose();
            }
            return Id;
        }
        public int CountCredit()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_COUNT_CREDIT";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["NbrRecouvre"] == DBNull.Value)
                        Id = 0;
                    else
                        Id = Convert.ToInt32(dr["NbrRecouvre"].ToString());
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
        public List<Remboursement> AllDPayement()
        {
            List<Remboursement> lst = new List<Remboursement>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_ALL_REMBOURSEMENT";
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
        public List<Remboursement> AllRecouvrement(string procedure)
        {
            List<Remboursement> lst = new List<Remboursement>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetDetailsRecouvrement(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        
        private Remboursement GetDetails(IDataReader dr)
        {
            Remboursement rem = new Remboursement();

            i = i + 1;

            rem.Num = i;
            rem.Id = Convert.ToInt32(dr["Id"].ToString());
            rem.Code = dr["Code"].ToString();
            rem.Montant = Convert.ToDouble(dr["Montant"].ToString());
            rem.DateRemboursement = Convert.ToDateTime(dr["Date_Remboursement"].ToString());
            rem.Observation = dr["Observation"].ToString();
            rem.CodeCredit = dr["Code_Credit"].ToString();
            rem.MontantR = dr["Montant_Restant"].ToString();
            rem.CodeClient = dr["Code_Client"].ToString();
            rem.Client = dr["Client"].ToString();
            rem.Sexe = dr["Sexe"].ToString();
            rem.Phone = dr["Telephone"].ToString();


            return rem;
        }
        private Remboursement GetDetailsRecouvrement(IDataReader dr)
        {
            Remboursement rem = new Remboursement();

            i = i + 1;

            rem.Num = i;
            rem.Code = dr["Code"].ToString();
            rem.Montant = Convert.ToDouble(dr["Montant"].ToString());
            rem.Client = dr["Noms"].ToString();
            rem.Sexe = dr["Sexe"].ToString();
            rem.Phone = dr["Telephone"].ToString();


            return rem;
        }
    }
}
