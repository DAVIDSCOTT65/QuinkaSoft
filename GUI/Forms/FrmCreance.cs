using CreanceLibrary;
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
    public partial class FrmCreance : Form
    {
        int idCreance = 0;
        public int idEntete = 0;
        int idClient = 0;
        DynamicClasses dn = new DynamicClasses();
        public FrmCreance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmClient cli = new FrmClient();
            cli.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCreance_Load(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(clientCombo, "Noms", "SELECT_CLIENT_NOM");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Creance cr = new Creance();

            idCreance = cr.NewId();
            codeTxt.Text = "CRE00-" + idCreance;

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Creance cr = new Creance();

                cr.Id = idCreance;
                cr.Code = codeTxt.Text;
                cr.Montant = Convert.ToDouble(montantTxt.Text);
                cr.DatePaiement = Convert.ToDateTime(dateTxt.Text);
                cr.RefClient = dn.retourId("Id", "Client", "Noms", clientCombo.Text);
                cr.Observation = observCombo.Text;

                cr.Enregistrer(cr);

                MessageBox.Show("Enregistrement reussie");
            }
            catch (Exception ex)
            {


                MessageBox.Show("L'erreur suivant est survenue : "+ex.Message);
            }
        }
    }
}
