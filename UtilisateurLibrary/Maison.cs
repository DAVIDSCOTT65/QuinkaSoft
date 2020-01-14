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
    public class Maison
    {
        int _id;
        string _nom;
        string _adresse;
        string _telephone1;
        string _telephone2;
        string _telephone3;
        string _mail;
        Image _logo;
        string _siteweb;
        string _boitePostal;
        string _rccm;
        string _idNat;
        string _NumImpot;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        public string Adresse
        {
            get
            {
                return _adresse;
            }

            set
            {
                _adresse = value;
            }
        }

        public string Telephone1
        {
            get
            {
                return _telephone1;
            }

            set
            {
                _telephone1 = value;
            }
        }
        public string Telephone2
        {
            get
            {
                return _telephone2;
            }

            set
            {
                _telephone2 = value;
            }
        }
        public string Telephone3
        {
            get
            {
                return _telephone3;
            }

            set
            {
                _telephone3 = value;
            }
        }

        public string Mail
        {
            get
            {
                return _mail;
            }

            set
            {
                _mail = value;
            }
        }

        public Image Logo
        {
            get
            {
                return _logo;
            }

            set
            {
                _logo = value;
            }
        }

        public string Siteweb
        {
            get
            {
                return _siteweb;
            }

            set
            {
                _siteweb = value;
            }
        }

        public string BoitePostal
        {
            get
            {
                return _boitePostal;
            }

            set
            {
                _boitePostal = value;
            }
        }

        public string Rccm
        {
            get
            {
                return _rccm;
            }

            set
            {
                _rccm = value;
            }
        }

        public string IdNat
        {
            get
            {
                return _idNat;
            }

            set
            {
                _idNat = value;
            }
        }

        public string NumImpot
        {
            get
            {
                return _NumImpot;
            }

            set
            {
                _NumImpot = value;
            }
        }
        private byte[] converttoByteImage(Image img)
        {
            MemoryStream ms = new MemoryStream();
            Bitmap bmpImage = new Bitmap(img);
            byte[] bytImage;
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            bytImage = ms.ToArray();
            ms.Close();
            return bytImage;
        }
        public void Enregistrer(Maison tonti)
        {

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_MAISON";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@id", 4, DbType.Int32, Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@nom", 100, DbType.String, Nom.Trim()));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@adresse", 100, DbType.String, Adresse.Trim()));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@telephone", 20, DbType.String, Telephone1.Trim()));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@telephone2", 20, DbType.String, Telephone2.Trim()));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@telephone3", 20, DbType.String, Telephone3.Trim()));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@mail", 100, DbType.String, Mail.Trim()));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@logo", int.MaxValue, DbType.Binary, converttoByteImage(Logo)));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@siteweb", 100, DbType.String, Siteweb.Trim()));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@boitePostal", 100, DbType.String, BoitePostal.Trim()));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@rccm", 100, DbType.String, Rccm.Trim()));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@idNat", 100, DbType.String, IdNat.Trim()));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@NumImpot", 100, DbType.String, NumImpot.Trim()));

                cmd.ExecuteNonQuery();


            }

        }
        public List<Maison> Details()
        {
            List<Maison> lst = new List<Maison>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_MAISON";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetDatas(dr));
                }
                dr.Dispose();
                dr.Close();
            }
            return lst;
        }
        private Maison GetDatas(IDataReader dr)
        {
            Maison tont = new Maison();

            tont.Id = Convert.ToInt32(dr["Id"].ToString());
            tont.Nom = dr["Nom"].ToString();
            tont.Adresse = dr["Adresse"].ToString();
            tont.Telephone1 = dr["Telephone"].ToString();
            tont.Telephone2 = dr["Telephone2"].ToString();
            tont.Telephone3 = dr["Telephone3"].ToString();
            tont.Mail = dr["Mail"].ToString();
            tont.Siteweb = dr["Siteweb"].ToString();
            tont.BoitePostal = dr["BoitePostal"].ToString();
            tont.Rccm = dr["Rccm"].ToString();
            tont.IdNat = dr["IdNat"].ToString();
            tont.NumImpot = dr["NumImpot"].ToString();

            return tont;

        }
    }
}
