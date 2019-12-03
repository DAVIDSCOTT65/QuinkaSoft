using ArticlesLibrary;
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
    public partial class FrmArticle : Form
    {
        int idArticle = 0;
        DynamicClasses dn = new DynamicClasses();
        public FrmArticle()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategorie frm = new FrmCategorie();

            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Articles art = new Articles();
            idArticle = art.NewId();

            codeTxt.Text = "ART00-" + idArticle;

            
        }

        private void FrmArticle_Load(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(categCombo, "Designation", "SELECT_CATEGORIE");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(categCombo, "Designation", "SELECT_CATEGORIE");
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (idArticle == 0 || codeTxt.Text == "" || designationTxt.Text == "" || pvuTxt.Text == "0.00" || categCombo.Text == "")
                MessageBox.Show("Completer tous les champs svp !!!");
            else
                SaveData();
        }
        private void SaveData()
        {
            try
            {
                Articles art = new Articles();

                art.Id = idArticle;
                art.Code = codeTxt.Text;
                art.Designation = designationTxt.Text;
                art.PVu = Convert.ToDouble(pvuTxt.Text);
                art.Unite = uniteTxt.Text;
                art.RefCategorie = dn.retourId("Id", "Categorie", "Designation", categCombo.Text);

                art.Enregistrer(art);

                MessageBox.Show("Article enregistrer");

                Initialise();
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        private void Initialise()
        {
            idArticle = 0;
            codeTxt.Text = "";
            designationTxt.Text = "";
            pvuTxt.Text = "0.00";
            uniteTxt.Text = "";
            categCombo.Text = "";
        }
    }
}
