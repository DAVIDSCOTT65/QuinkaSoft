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
using GUI.Classes;
using System.Threading;

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

        private void dgArticle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //try
            //{
            //    FrmImpression frm = new FrmImpression();
            //    int i;
            //    i = dgArticle.CurrentRow.Index;
                
            //DynamicClasses.GetInstance().Sortie_Fiche_Stock_Article(dgArticle["ColCode", i].Value.ToString());
            //    frm.aticleCombo.Text = dgArticle["ColArticle", i].Value.ToString();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        private void copyAlltoClipboard()
        {
            //to remove the first blank column from datagridview
            dgArticle.RowHeadersVisible = false;
            dgArticle.SelectAll();
            DataObject dataObj = dgArticle.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
        }

        private void serchTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search(new Articles());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        void Search(Articles art)
        {
            dgArticle.DataSource = art.Research(serchTxt.Text);
        }
    }
}
