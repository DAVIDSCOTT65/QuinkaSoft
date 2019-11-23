using ApprovisionnementLibrary;
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

namespace GUI.Forms
{
    public partial class FrmApprovisionnement : Form
    {
        DynamicClasses dn = new DynamicClasses();
        int idDetail = 0;
        int idApprov = 0;
        int idArticle = 0;
        public FrmApprovisionnement()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmArticle frm = new FrmArticle();

            frm.ShowDialog();
        }

        private void FrmApprovisionnement_Load(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(articleCombo, "Designation", "SELECT_ARTICLE");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(articleCombo, "Designation", "SELECT_ARTICLE");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddToDataGrid();
        }
        private void AddToDataGrid()
        {
            try
            {
                Detail_Approvisionnement det = new Detail_Approvisionnement();
                int rowCount;
                if (idDetail==0)
                    MessageBox.Show("Cliquez d'abord sur le boutton sur le +", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if(articleCombo.Text=="" || quantiteTxt.Text=="" || pauTxt.Text=="")
                    MessageBox.Show("Completez tous les champs svp !!!", "Champs Obligatiore", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                else
                {
                    rowCount = dgManyCotisation.Rows.Count;

                    if (rowCount==0)
                    {
                        idDetail = det.NewId();
                        dgManyCotisation.Rows.Add(idDetail, articleCombo.Text, quantiteTxt.Text, pauTxt.Text, dn.retourId("Id","Articles","Designation",articleCombo.Text));
                    }
                    else if(rowCount > 0)
                    {
                        idDetail = idDetail + 1;
                        dgManyCotisation.Rows.Add(idDetail, articleCombo.Text, quantiteTxt.Text, pauTxt.Text, dn.retourId("Id", "Articles", "Designation", articleCombo.Text));
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Detail_Approvisionnement det = new Detail_Approvisionnement();
            Approvisionnement approv = new Approvisionnement();

            idDetail = det.NewId();
            idApprov = approv.NewId();

            button4.Enabled = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveDatas();
        }
        void SaveApprov()
        {
            Approvisionnement approv = new Approvisionnement();

            approv.Id = idApprov;
            approv.UserSession = UserSession.GetInstance().UserName;

            approv.Enregistrer(approv);
        }
        private void SaveDatas()
        {
            try
            {
                SaveApprov();
                Detail_Approvisionnement approv = new Detail_Approvisionnement();

                int rowCount = dgManyCotisation.Rows.Count;

                if(rowCount <= 0)
                    MessageBox.Show("Rien à enregistrés");
                else
                {
                    for (int i = 0; i < (dgManyCotisation.Rows.Count); i++)
                    {
                        approv.Id = Convert.ToInt32(dgManyCotisation[0, i].Value.ToString());
                        approv.Quantite = Convert.ToDouble(dgManyCotisation[2, i].Value.ToString());
                        approv.PAu = Convert.ToDouble(dgManyCotisation[3, i].Value.ToString());
                        approv.RefArticle = Convert.ToInt32(dgManyCotisation[4, i].Value.ToString());
                        approv.RefApprov = idApprov;

                        approv.Enregistrer(approv);
                    }
                    MessageBox.Show("Articles enregistrés avec succès");
                    dgManyCotisation.Rows.Clear();
                }

               
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
    }
}
