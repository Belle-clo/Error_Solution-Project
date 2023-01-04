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
    public partial class frmReport_ErrorSolution : Form
    {
        public frmReport_ErrorSolution()
        {
            InitializeComponent();
        }

        BusinessLogicaLayer bll = new BusinessLogicaLayer();

        private void frmReport_Error_Load(object sender, EventArgs e)
        {
            
        }

        public void GetDgv()
        {
            dgvErrorReports.DataSource = bll.GetErrorSolutionDgvv();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string Search = txtSearch.Text;
            dgvErrorReports.DataSource = bll.SearchError(Search);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetDgv();
        }

        private void txtSearchErrorProg_TextChanged(object sender, EventArgs e)
        {
            string SearchP = txtSearchErrorProg.Text;
            dgvErrorProg.DataSource = bll.SearchErrorProg(SearchP);
        }

        public void RefreshProg()
        {
            dgvErrorProg.DataSource = bll.GetStudent();
        }

        private void btnErrorProg_Click(object sender, EventArgs e)
        {
            RefreshProg();
        }

        private void dgvErrorReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tXTSearchT_TextChanged(object sender, EventArgs e)
        {
            string SearchT = txtSearchT.Text;
           dgvTopicError.DataSource = bll.SearchTopicError(SearchT);
        }

        private void btnSearchTopicError_Click(object sender, EventArgs e)
        {
            RefreshErrorTopic();
        }

        public void RefreshErrorTopic()
        {
            dgvTopicError.DataSource = bll.GetStudent();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login ll = new Login();
            ll.Show();
            this.Hide();
        }
    }
}
