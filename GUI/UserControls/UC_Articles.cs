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
            try
            {
                int i;
                i = dgArticle.CurrentRow.Index;
                
                DynamicClasses.GetInstance().Sortie_Fiche_Stock_Article(dgArticle["ColCode", i].Value.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _inputparameter.delay = 10;
            _inputparameter.progress = 1200;
            backgroundWorker1.RunWorkerAsync(_inputparameter);
        }
        void ExportExcel()
        {
            DataTable dt = new DataTable();
            while (dt.Columns.Count < dgArticle.Columns.Count)
            {
                foreach (DataGridViewColumn col in dgArticle.Columns)
                {
                    dt.Columns.Add(col.HeaderText.ToString());
                }
            }

            foreach (DataGridViewRow row in dgArticle.Rows)
            {
                DataRow drow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    drow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(drow);
            }
            string ExcelPath = "Articles_Avec_Stock.xlsx";
            dt.ExportToExcel(ExcelPath);
        }
        struct DataParameter
        {
            public int progress;
            public int delay;
        }
        private DataParameter _inputparameter;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int progress = ((DataParameter)e.Argument).progress;
            int delay = ((DataParameter)e.Argument).delay;
            int idex = 1;
            try
            {
                for (int i = 0; i < progress; i++)
                {
                    backgroundWorker1.ReportProgress(idex++ * 100 / progress, string.Format("Progress data {0}", i));
                    System.Threading.Thread.Sleep(delay);
                }
                ExportExcel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            labStatus.Text = string.Format("Processing...{0}", e.ProgressPercentage);
            progressBar1.Update();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Thread.Sleep(100);
                labStatus.Text = "Your data has been successfully exported";
            }
        }
    }
}
