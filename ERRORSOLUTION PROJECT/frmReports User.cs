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
    public partial class frmReports_User : Form
    {
        public frmReports_User()
        {
            InitializeComponent();
        }
        BusinessLogicaLayer bll = new BusinessLogicaLayer();
        
        private void frmReports_User_Load(object sender, EventArgs e)
        {
           
        }

       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvUserReports.DataSource = bll.GetUser();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Search = txtSearch.Text;
            dgvUserReports.DataSource = bll.SearchUser(Search);
        }

        private void dgvUserReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
