using GUI.Classes;
using SortieLibrary;
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
    public partial class FrmSortie : Form
    {
        DynamicClasses dn = new DynamicClasses();
        int idDetail = 0;
        int idEntete = 0;
        public FrmSortie()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCreance cr = new FrmCreance();
            cr.ShowDialog();
        }

        private void FrmSortie_Load(object sender, EventArgs e)
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
                Detail_Sortie det = new Detail_Sortie();
                int rowCount;
                if (idDetail == 0)
                    MessageBox.Show("Cliquez d'abord sur le boutton sur le +", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (articleCombo.Text == "" || quantiteTxt.Text == "" || pauTxt.Text == "")
                    MessageBox.Show("Completez tous les champs svp !!!", "Champs Obligatiore", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                else
                {
                    rowCount = dgManyCotisation.Rows.Count;

                    if (rowCount == 0)
                    {
                        idDetail = det.NewId();
                        dgManyCotisation.Rows.Add(idDetail, articleCombo.Text, quantiteTxt.Text, pauTxt.Text, dn.retourId("Id", "Articles", "Designation", articleCombo.Text), Convert.ToDouble(quantiteTxt.Text) * Convert.ToDouble(pauTxt.Text));

                        lblTotal.Text = (Convert.ToDouble(quantiteTxt.Text) * Convert.ToDouble(pauTxt.Text)).ToString();
                    }
                    else if (rowCount > 0)
                    {
                        idDetail = idDetail + 1;
                        dgManyCotisation.Rows.Add(idDetail, articleCombo.Text, quantiteTxt.Text, pauTxt.Text, dn.retourId("Id", "Articles", "Designation", articleCombo.Text), Convert.ToDouble(quantiteTxt.Text) * Convert.ToDouble(pauTxt.Text));
                        lblTotal.Text = (Convert.ToDouble(lblTotal.Text) + Convert.ToDouble(quantiteTxt.Text) * Convert.ToDouble(pauTxt.Text)).ToString();
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
            Detail_Sortie det = new Detail_Sortie();
            Entete_Sortie ent = new Entete_Sortie();

            idEntete = ent.NewId();
            idDetail = det.NewId();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (idEntete == 0)
                MessageBox.Show("Cliquer d'abord sur le boutton nouveau");
            else
                SaveDatas();
        }
        void SaveEntete()
        {
            try
            {
                Entete_Sortie ent = new Entete_Sortie();

                ent.Id = idEntete;
                ent.UserSession = UserSession.GetInstance().UserName;

                ent.Enregistrer(ent);
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : "+ex.Message);
            }
        }
        void SaveDatas()
        {
            SaveEntete();
            try
            {
                Detail_Sortie det = new Detail_Sortie();

                int rowCount = dgManyCotisation.Rows.Count;

                if (rowCount <= 0)
                    MessageBox.Show("Rien à enregistrés");
                else
                {
                    for (int i = 0; i < (dgManyCotisation.Rows.Count); i++)
                    {
                        det.Id = Convert.ToInt32(dgManyCotisation[0, i].Value.ToString()); 
                        det.Quantite = Convert.ToDouble(dgManyCotisation[2, i].Value.ToString());
                        det.PVu = Convert.ToDouble(dgManyCotisation[3, i].Value.ToString());
                        det.RefArticle = Convert.ToInt32(dgManyCotisation[4, i].Value.ToString());
                        det.RefEntete = Convert.ToInt32(idEntete);

                        det.Enreistrer(det);

                        MessageBox.Show("Enregistrements reussies");

                        idDetail = 0;
                        idEntete = 0;
                        dgManyCotisation.Rows.Clear();
                        lblTotal.Text = "0,00";
                    }
                }
                   

               

            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
    }
}
