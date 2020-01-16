using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Classes;
using System.Threading;
using System.Drawing.Printing;

namespace GUI.UserControls
{
    public partial class UC_Historique : UserControl
    {
        public UC_Historique()
        {
            InitializeComponent();
        }

        private void UC_Historique_Load(object sender, EventArgs e)
        {
            SelectHisto(new HistoriqueES());
        }
        void SelectHisto(HistoriqueES H)
        {
            dgHistorique.DataSource = H.Historiques();
        }

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPrinter printer = new DGVPrinter();
                
                printer.Title = "Historique Entrées et sorties";
                printer.SubTitle = string.Format("Date :{0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = true;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Go down";
                printer.FooterSpacing = 15;

                printer.PageSize = new PaperSize("Custom", 5100, 6600);
                
                printer.PrintDataGridView(dgHistorique);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur " + ex.Message);
            }
        }
        struct DataParameter
        {
            public int progress;
            public int delay;
        }
        private DataParameter _inputparameter;
        private void button3_Click(object sender, EventArgs e)
        {

            try
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
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }

        }
        private void copyAlltoClipboard()
        {
            //to remove the first blank column from datagridview
            dgHistorique.RowHeadersVisible = false;
            dgHistorique.SelectAll();
            DataObject dataObj = dgHistorique.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //int progress = ((DataParameter)e.Argument).progress;
            //int delay = ((DataParameter)e.Argument).delay;
            //int idex = 1;
            //try
            //{
            //    for (int i = 0; i < progress; i++)
            //    {
            //        backgroundWorker1.ReportProgress(idex++ * 100 / progress, string.Format("Progress data {0}", i));
            //        Thread.Sleep(delay);
            //    }
            //    ExportExcel();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        void ExportExcel()
        {
            DataTable dt = new DataTable();
            while (dt.Columns.Count < dgHistorique.Columns.Count)
            {
                foreach (DataGridViewColumn col in dgHistorique.Columns)
                {
                    dt.Columns.Add(col.HeaderText.ToString());
                }
            }

            foreach (DataGridViewRow row in dgHistorique.Rows)
            {
                DataRow drow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    drow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(drow);
            }
            string ExcelPath = "Historique_ES.xlsx";
            dt.ExportToExcel(ExcelPath);
        }

        private void dgHistorique_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DynamicClasses.GetInstance().Sortie_Entree_Sortie();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void serchTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search(new HistoriqueES());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Search(HistoriqueES art)
        {
            dgHistorique.DataSource = art.Research(serchTxt.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
