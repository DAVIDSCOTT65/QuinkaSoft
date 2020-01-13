using ManageSingleConnexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Classes
{
    public class HistoriqueES
    {
        int i = 0;
        public int Num { get; set; }
        public int RefArticle { get; set; }
        public string Code { get; set; }
        public string Articles { get; set; }
        public string CodeCateg { get; set; }
        public string Categorie { get; set; }
        public string QteEntree { get; set; }
        public string QteSortie { get; set; }
        public string Stock { get; set; }
        public DateTime DateOperation { get; set; }
        public List<HistoriqueES> Historiques()
        {
            List<HistoriqueES> lst = new List<HistoriqueES>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_HISTORIQUES";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetHistori(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        public List<HistoriqueES> Research(string recherche)
        {
            List<HistoriqueES> lst = new List<HistoriqueES>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Affichage_Details_Historique WHERE (LIBELLE LIKE '%" + recherche + "%' OR LIBELLE LIKE '%" + recherche + "' OR LIBELLE LIKE '" + recherche + "%' OR Articles LIKE '%" + recherche + "%' OR Articles LIKE '%" + recherche + "' OR Articles LIKE '" + recherche + "%') ORDER By Id DESC";
                //cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lst.Add(GetHistori(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        private HistoriqueES GetHistori(IDataReader dr)
        {
            HistoriqueES h = new HistoriqueES();

            i = i + 1;

            h.Num = i;
            h.RefArticle = Convert.ToInt32(dr["RefArticle"].ToString());
            h.Code = dr["Code"].ToString();
            h.Articles = dr["Articles"].ToString();
            h.CodeCateg = dr["Code_Categ"].ToString();
            h.Categorie = dr["Categorie"].ToString();
            h.QteEntree = dr["QteEntree"].ToString();
            h.QteSortie = dr["QteSortie"].ToString();
            h.Stock = dr["Stock"].ToString();
            h.DateOperation = Convert.ToDateTime(dr["DateOperation"].ToString());



            return h;

        }
    }
}
