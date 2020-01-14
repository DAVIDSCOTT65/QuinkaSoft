using GUI.Classes;
using GUI.Forms;
using GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public int backUp = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CloseSoft();
        }
        private void CloseSoft()
        {
            FrmBackRestore frm = new FrmBackRestore();
            Deconnexion();
            frm.BackUpDefault();
            Application.Exit();
        }
        private void Deconnexion()
        {
            ClsMonitoring mon = new ClsMonitoring();
            mon.Operation = "Déconnexion";
            mon.Enregistrer(mon);
        }
        private void articlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmApprovisionnement frm = new FrmApprovisionnement();
            frm.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ChargerUser(UserControl userc)
        {
            try
            {
                userc.Dock = DockStyle.Fill;
                panel2.Controls.Clear();
                panel2.Controls.Add(userc);

            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

        private void catégorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Approvisionnement approv = new UC_Approvisionnement();
            ChargerUser(approv);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PubCon.testFile();
            var form = new Frm_Connection();
            form.ShowDialog();
            ChargerUser(new UC_DashBord());
        }

        private void toutesLesVentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Sortie sorti = new UC_Sortie();
            ChargerUser(sorti);
        }

        private void remboursementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Remboursement sorti = new UC_Remboursement();
            ChargerUser(sorti);
        }

        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void historiquesESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Historique sorti = new UC_Historique();
            ChargerUser(sorti);
        }

        private void stockToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void articlesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UC_Articles sorti = new UC_Articles();
            ChargerUser(sorti);
        }

        private void nouvelleVenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSortie frm = new FrmSortie();
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UC_DashBord frm = new UC_DashBord();
            ChargerUser(frm);
        }

        private void catégoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAllCategorie frm = new FrmAllCategorie();
            frm.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmMaison frm = new FrmMaison();
            frm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //UC_Utilisateur approv = new UC_Utilisateur();
            //ChargerUser(approv);
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Utilisateur approv = new UC_Utilisateur();
            ChargerUser(approv);
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseSoft();
        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void monitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Monitoring approv = new UC_Monitoring();
            ChargerUser(approv);
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBackRestore frm = new FrmBackRestore();
            frm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmApropos frm = new FrmApropos();
            frm.Show();
        }
    }
}
