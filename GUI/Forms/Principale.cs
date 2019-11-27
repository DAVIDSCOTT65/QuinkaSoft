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
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void articlesToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
