using GUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilisateurLibrary;

namespace GUI.Forms
{
    public partial class FrmMaison : Form
    {
        public FrmMaison()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Maison m = new Maison();

            m.Nom = raisonTxt.Text;
            m.Adresse = siegeTxt.Text;
            m.Telephone1 = phoneTxt.Text;
            m.Telephone2 = phone2.Text;
            m.Telephone3 = phone3.Text;
            m.Mail = mailTxt.Text;
            m.Logo = logo.Image;
            m.Siteweb = siteTxt.Text;
            m.BoitePostal = boiteTxt.Text;
            m.Rccm = rccmTxt.Text;
            m.IdNat = idNatTxt.Text;
            m.NumImpot = numImpotTxt.Text;

            m.Enregistrer(m);

            SelectData(new Maison());

        }

        private void FrmMaison_Load(object sender, EventArgs e)
        {
            SelectData(new Maison());
        }
        private void SelectData(Maison cls)
        {
            dgMaison.DataSource = cls.Details();
        }
        void SelectionChanged()
        {
            try
            {
                int i;
                i = dgMaison.CurrentRow.Index;



                raisonTxt.Text = dgMaison["ColRaison", i].Value.ToString();
                siegeTxt.Text = dgMaison["ColSiege", i].Value.ToString();
                phoneTxt.Text = dgMaison["ColPhone", i].Value.ToString();
                phone2.Text = dgMaison["ColPhone2", i].Value.ToString();
                phone3.Text = dgMaison["ColPhone3", i].Value.ToString();
                mailTxt.Text = dgMaison["ColEmail", i].Value.ToString();
                siteTxt.Text = dgMaison["ColSite", i].Value.ToString();
                boiteTxt.Text = dgMaison["ColBoite", i].Value.ToString();
                rccmTxt.Text = dgMaison["ColRccm", i].Value.ToString();
                idNatTxt.Text = dgMaison["ColIdNat", i].Value.ToString();
                numImpotTxt.Text = dgMaison["ColNumImpot", i].Value.ToString();


                loadLogo(dgMaison["ColId", i].Value.ToString(), logo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        void loadLogo(string id, PictureBox pic)
        {
            DynamicClasses dn = new DynamicClasses();
            dn.retreivePhoto(id, pic, "SELECT_LOGO");
        }

        private void dgMaison_SelectionChanged(object sender, EventArgs e)
        {
            SelectionChanged();
        }

        private void btnParc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.ShowDialog();

            try
            {
                if (openDlg.FileName != null)
                {
                    // try to open the file
                    this.logo.Image = Bitmap.FromFile(openDlg.FileName);
                    //this.tbFileName.Text = openDlg.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("L'erreur suivant est survenue lors du chargement de la photo : " + ex.Message);
            }
        }
    }
}
