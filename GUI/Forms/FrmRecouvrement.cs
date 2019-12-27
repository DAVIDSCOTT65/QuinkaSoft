﻿using CreanceLibrary;
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
    public partial class FrmRecouvrement : Form
    {
        public string procedure = "";
        public FrmRecouvrement()
        {
            InitializeComponent();
        }

        private void FrmRecouvrement_Load(object sender, EventArgs e)
        {
            ReceiveDatas(new Remboursement());
        }
        private void ReceiveDatas(Remboursement remb)
        {
            dgRecouvr.DataSource = remb.AllRecouvrement(procedure);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void copyAlltoClipboard()
        {
            //to remove the first blank column from datagridview
            dgRecouvr.RowHeadersVisible = false;
            dgRecouvr.SelectAll();
            DataObject dataObj = dgRecouvr.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
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
    }
}
