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
    public partial class FrmRemboursement : Form
    {
        DynamicClasses dn = new DynamicClasses();
        int idRemb = 0;
        public FrmRemboursement()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Remboursement cr = new Remboursement();
                idRemb = cr.NewId();

                codeTxt.Text = "REM00-" + idRemb;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lerreur suivant est survenue : " + ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (idRemb == 0)
                MessageBox.Show("Cliquez d'abords sur le boutton nouveau (+) au coin supérieur gauche");
            else if (codeTxt.Text == "" || creanceCombo.Text == "" || montantTxt.Text == "" || observCombo.Text == "" || dateTxt.Text == "")
                MessageBox.Show("Completez tous les champs svp");
            else
                SaveDatas();

        }
        void SaveDatas()
        {
            try
            {
                Remboursement remb = new Remboursement();

                remb.Id = idRemb;
                remb.Code = codeTxt.Text;
                remb.Montant = Convert.ToDouble(montantTxt.Text);
                remb.Observation = observCombo.Text;
                remb.RefCredit = dn.retourId("Id", "Affichage_Details_Creance", "Client_Credit", creanceCombo.Text);
                remb.DateRemboursement = Convert.ToDateTime(dateTxt.Text);

                remb.Enregistrer(remb);

                MessageBox.Show("Enregistrement reussi");

            }
            catch (Exception ex)
            {


                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

        private void FrmRemboursement_Load(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(creanceCombo, "Client_Credit", "SELECT_CLIENT_CREDIT");
        }

        private void creanceCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dn.retourInfoCredit(lblCli, lblDette, lblDate, creanceCombo.Text);
            if (creanceCombo.Text != "")
                montantTxt.Enabled = true;

        }

        private void montantTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                resteTxt.Text = (Convert.ToDouble(lblDette.Text) - Convert.ToDouble(montantTxt.Text)).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
           
        }

        private void resteTxt_TextChanged(object sender, EventArgs e)
        {
            if(resteTxt.Text != "" || resteTxt.Text != "0")
            {
                lblRecou.Visible = true;
                dateTxt.Visible = true;
            }
            else
            {
                lblRecou.Visible = false;
                dateTxt.Visible = false;
            }
        }
    }
}
