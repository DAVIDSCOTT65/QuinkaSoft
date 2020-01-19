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
    public partial class Frm_Connection : Form
    {
        public Frm_Connection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (userTxt.Text == "" || passTxt.Text == "")
                    MessageBox.Show("Veuillez completez tout les champs svp !!!", "Erreur de connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    PubCon.testlog = DynamicClasses.GetInstance().loginTest(userTxt.Text, passTxt.Text);
                    
                    //Envoyer();
                    if (PubCon.testlog == 1)
                    {

                        ClsMonitoring mon = new ClsMonitoring();
                        mon.Operation = "Connexion";
                        mon.Enregistrer(mon);
                        MessageBox.Show("La connection a reussie !!!", "Message Serveur...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        

                        //frm.Show();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Connection_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
