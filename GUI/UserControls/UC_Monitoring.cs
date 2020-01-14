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

namespace GUI.UserControls
{
    public partial class UC_Monitoring : UserControl
    {
        public UC_Monitoring()
        {
            InitializeComponent();
        }

        private void UC_Monitoring_Load(object sender, EventArgs e)
        {
            RefreshDatas(new ClsMonitoring());
        }
        private void RefreshDatas(ClsMonitoring cls)
        {
            dgMonitoring.DataSource = cls.AllMonitoringToday();
        }

        private void serchTxt_TextChanged(object sender, EventArgs e)
        {
            Search(new ClsMonitoring());
        }
        void Search(ClsMonitoring cot)
        {
            dgMonitoring.DataSource = cot.Research(serchTxt.Text);
        }
    }
}
