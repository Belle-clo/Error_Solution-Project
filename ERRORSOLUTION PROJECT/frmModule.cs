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
    public partial class frmModule : Form
    {
        public frmModule()
        {
            InitializeComponent();
        }
        BusinessLogicaLayer bll = new BusinessLogicaLayer();
        private void dgvModuleDescription_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModuleDescription.Text))
            {
                errorProvider1.SetError(txtModuleDescription, "Please do not leave field empty");
            }
            else
            {


                Module module = new Module();
                module.ModuleDescription = txtModuleDescription.Text;

                module.YearID = int.Parse(cmbYear.SelectedValue.ToString());

                int z = bll.InsertModule(module);

                if (z > 0)
                {
                    MessageBox.Show(z + "Added");
                    txtModuleDescription.Clear();
                    this.Refresh();
                }
                else
                {
                    MessageBox.Show(z + "Added");
                }
            }

        }

        private void frmModule_Load(object sender, EventArgs e)
        {
            Loadcmb();
            Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Module update = new Module();

            update.ModuleDescription = txtModuleDescription.Text;
            update.YearID = int.Parse(cmbYear.SelectedValue.ToString());

            update.ModuleID = int.Parse(dgvModuleDescription.SelectedRows[0].Cells["ModuleID"].Value.ToString());

            int z = bll.UpdateModule(update);

            if (z > 0)
            {
                MessageBox.Show(z + "Updated");
                txtModuleDescription.Clear();
                this.Refresh();

            }
            else
            {
                MessageBox.Show(z + "Updated");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          Module delete= new Module();
            delete.ModuleID = int.Parse(dgvModuleDescription.SelectedRows[0].Cells["ModuleID"].Value.ToString());
            int a = bll.DeleteModule(delete);
            if (a > 0)
            {
                MessageBox.Show(a + "Deleted");
                this.Refresh();
            }
            else
            {
                MessageBox.Show(a + "Deleted");
            }
        }

        public void Loadcmb()
        {
            cmbYear.DataSource = bll.GetYearStudy();
            cmbYear.ValueMember = "YearID";
            cmbYear.DisplayMember = "YearDescription";
        }

        public void Refresh()
        {
            dgvModuleDescription.DataSource = bll.GetModule();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            frmRegistration rr = new frmRegistration();
            rr.Show();
            this.Hide();
        }
    }
}
