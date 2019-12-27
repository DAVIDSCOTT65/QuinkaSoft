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
    public partial class FrmAllCategorie : Form
    {
        public FrmAllCategorie()
        {
            InitializeComponent();
        }

        private void FrmAllCategorie_Load(object sender, EventArgs e)
        {
            ReceiveDatas(new Categorie());
        }
        private void ReceiveDatas(Categorie categ)
        {
            dgCategorie.DataSource = categ.AllCategorie();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
