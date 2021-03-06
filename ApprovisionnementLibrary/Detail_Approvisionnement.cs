﻿using ManageSingleConnexion;
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
        int i = 0;
        public int Num { get; set; }
        public int Id { get; set; }
        public double Quantite { get; set; }
        public double PAu { get; set; }
        public int RefArticle { get; set; }
        public int RefApprov { get; set; }
        public string Code { get; set; }
        public string Articles { get; set; }
        public string Categorie { get; set; }
        public string QuantiteA { get; set; }
        public DateTime DateApprov { get; set; }
        public string PAT { get; set; }
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
                cmd.CommandText = "SELECT_APPROVISIONNEMENT";
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
        public List<Detail_Approvisionnement> Research(string recherche)
        {
            List<Detail_Approvisionnement> lst = new List<Detail_Approvisionnement>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Affichage_Approvisionnement WHERE (Articles LIKE '%" + recherche + "%' OR Articles LIKE '%" + recherche + "' OR Articles LIKE '" + recherche + "%') ORDER By Id DESC";
                //cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lst.Add(GetDetails(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        private Detail_Approvisionnement GetDetails(IDataReader dr)
        {
            Detail_Approvisionnement da = new Detail_Approvisionnement();

            i = i + 1;

            da.Num = i;
            da.Code = dr["Code Article"].ToString();
            da.Articles = dr["Articles"].ToString();
            da.Categorie = dr["Catégorie"].ToString();
            da.QuantiteA = dr["Quantité en stock"].ToString();
            da.PAu = Convert.ToDouble(dr["PAu"].ToString());
            da.DateApprov = Convert.ToDateTime(dr["Date_Approv"].ToString());
            da.PAT = dr["PAt"].ToString();


            return da;
        }
    }
}
