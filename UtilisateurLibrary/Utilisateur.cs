using ManageSingleConnexion;
using ParametreConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilisateurLibrary
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Noms { get; set; }
        public string Sexe { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Fonction { get; set; }
        public string Pseudo { get; set; }
        public string PassWord { get; set; }
        public Image Photo { get; set; }
        private byte[] ConverttoByteImage(Image img)
        {
            MemoryStream ms = new MemoryStream();
            Bitmap bmpImage = new Bitmap(img);
            byte[] bytImage;
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            bytImage = ms.ToArray();
            ms.Close();
            return bytImage;
        }
        public int NewId()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(Id) AS LastId FROM Utilisateur";

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
        public void Enreistrer(Utilisateur det)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_AGENT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@id", 5, DbType.Int32, det.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@noms", 100, DbType.String, det.Noms));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@sexe", 1, DbType.String, det.Sexe));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@adresse", 5, DbType.String, det.Adresse));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@contact", 20, DbType.String, det.Telephone));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@email", 20, DbType.String, det.Email));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@fonction", 50, DbType.String, det.Fonction));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@pseudo", 20, DbType.String, det.Pseudo));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@password", 100, DbType.String, det.PassWord));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@photo", int.MaxValue, DbType.Binary, ConverttoByteImage(det.Photo)));

                cmd.ExecuteNonQuery();
            }
        }
    }
}