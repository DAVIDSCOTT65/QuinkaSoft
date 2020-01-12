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
    public partial class FrmPopulaire : Form
    {
        public string procedure = "";
        public FrmPopulaire()
        {
            InitializeComponent();
        }

        private void panelRupture_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPopulaire_Load(object sender, EventArgs e)
        {
            ReceiveDatas(new Articles());
        }
        private void ReceiveDatas(Articles art)
        {
            dgArticle.DataSource = art.ArticlesPopulaires(procedure);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
