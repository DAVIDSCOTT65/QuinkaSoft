using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArticlesLibrary;
using GUI.Forms;

namespace GUI.UserControls
{
    public partial class UC_Articles : UserControl
    {
        public UC_Articles()
        {
            InitializeComponent();
        }

        private void UC_Articles_Load(object sender, EventArgs e)
        {
            SelectDatas(new Articles());
        }
        void SelectDatas(Articles art)
        {
            dgArticle.DataSource = art.AllArticlesInStock();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmArticle frm = new FrmArticle();

            frm.ShowDialog();
        }
    }
}
