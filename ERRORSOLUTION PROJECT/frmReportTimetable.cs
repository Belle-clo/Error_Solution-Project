using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace ERRORSOLUTION_PROJECT
{
    public partial class frmReportTimetable : Form
    {
        public frmReportTimetable()
        {
            InitializeComponent();
        }
        BusinessLogicaLayer bll = new BusinessLogicaLayer();
        private void frmReportTimetable_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            dgvTimetableReport.DataSource = bll.GetTimetable();
        }


        private void dgvTimetableReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login ll = new Login();
            ll.Show();
            this.Hide();
        }
    }
}
