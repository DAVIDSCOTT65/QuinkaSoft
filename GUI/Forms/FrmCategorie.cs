using ArticlesLibrary;
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
    public partial class FrmCategorie : Form
    {
        public int idCateg = 0;
        public FrmCategorie()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (idCateg == 0 || codeTxt.Text == "" || designationTxt.Text == "")
                MessageBox.Show("Completez tous les champs avant de cliquer ici ");
            else
                SaveCategorie();
        }
        public void SaveCategorie()
        {
            try
            {
                Categorie categ = new Categorie();

                categ.Id = idCateg;
                categ.Designation = designationTxt.Text;
                categ.Code = codeTxt.Text;

                categ.Enregistrer(categ);

                MessageBox.Show("Catégorie enregistrée");


            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Categorie categ = new Categorie();

            idCateg = categ.NewId();

            codeTxt.Text = "CATEG00-" + idCateg;

        }
    }
}
