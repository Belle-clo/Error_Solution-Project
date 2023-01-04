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
    public partial class frmRole : Form
    {
        public frmRole()
        {
            InitializeComponent();
        }
        BusinessLogicaLayer bll = new BusinessLogicaLayer();
        private void frmRole_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRole.Text))
            {
                errorProvider1.SetError(txtRole, "Please do not leave field empty");
            }
            else
            {

                Role role = new Role();
                role.RoleDescription = txtRole.Text;
                //Add insertrole on you bll class and getrole by id as well
                int x = bll.InsertRoleDescription(role);

                if (x > 0)
                {
                    MessageBox.Show(x + " Role Added");
                    Refresh();
                }
                else
                {
                    MessageBox.Show(x + " Role Added");
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Role update = new Role();

            update.RoleDescription = txtRole.Text;
            update.RoleID = int.Parse(dgvRole.SelectedRows[0].Cells["RoleID"].Value.ToString());
           

            int z = bll.UpdateRoleDescription(update);

            if (z > 0)
            {
                MessageBox.Show(z + "Updated");
                txtRole.Clear();
                Refresh();

            }
            else
            {
                MessageBox.Show(z + "Updated");
            }
        }

        public void Refresh ()
        {
            dgvRole.DataSource = bll.GetRoleDescription();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            frmRegistration rr = new frmRegistration();
            rr.Show();
            this.Hide();
        }
    }
}
