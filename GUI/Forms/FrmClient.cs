using CreanceLibrary;
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
    public partial class FrmClient : Form
    {
        int idClient = 0;
        string sexe;
        public FrmClient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client cli = new Client();
            idClient = cli.NewId();

            codeTxt.Text = "CLI00-" + idClient;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (idClient == 0)
                MessageBox.Show("Avant chaque opération cliquer d'abord sur le bouttoon nouveau");
            else if (codeTxt.Text == "" || identiteTxt.Text == "" || sexeCombo.Text == "" || initialTxt.Text == "" || phoneTxt.Text == "")
                MessageBox.Show("Veuillez completer tous les champs svp !!!");
            else
                SaveClient();
        }
        void SaveClient()
        {
            try
            {
                Client cli = new Client();
                cli.Id = idClient;
                cli.Code = codeTxt.Text;
                cli.Noms = identiteTxt.Text;
                cli.Telephone = initialTxt.Text + "" + phoneTxt.Text;
                cli.Sexe = sexe;

                cli.Enregistrer(cli);

                MessageBox.Show("Enregistrement reussie !!!");

                idClient = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

        private void sexeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sexeCombo.SelectedItem.ToString() == "Masculin")
                sexe = "M";
            else if (sexeCombo.SelectedItem.ToString() == "Féminin")
                sexe = "F";

        }
    }
}
