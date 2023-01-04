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
    public partial class frmTimeTable : Form
    {
        public frmTimeTable()
        {
            InitializeComponent();
        }
        
        BusinessLogicaLayer bll = new BusinessLogicaLayer();

        private void frmTimeTable_Load(object sender, EventArgs e)
        {
            FillModuleID();
            FillYearID();
            Refresh();
        }

        public void FillModuleID()
        {
            cmbModule.DisplayMember = "ModuleDescription";
            cmbModule.ValueMember = "ModuleID";
            cmbModule.DataSource = bll.GetModule();
        }

        public void FillYearID()
        {
            cmbYear.DataSource = bll.GetYearStudy();
            cmbYear.ValueMember = "YearID";
            cmbYear.DisplayMember = "YearDescription";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOffice.Text))
            {
                errorProvider1.SetError(txtOffice, "Please do not leave field empty");
            }
            else
            {
              

               Office office = new Office();
                office.OfficeDescription = txtOffice.Text;
                office.Day = txtDay.Text;
                office.Time = txtTime.Text;
                office.YearID = int.Parse(cmbYear.SelectedValue.ToString());
                office.ModuleID = int.Parse(cmbModule.SelectedValue.ToString());

                int z = bll.InsertTime(office);

                if (z > 0)
                {
                    MessageBox.Show(z + "Solution Added");
                    txtOffice.Clear();
                    this.Refresh();
                }
                else
                {
                    MessageBox.Show(z + "Solution Added");
                }
            }           
        }

        public void Refresh()
        {
            dgvTimeTable.DataSource = bll.GetTimetable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Office office = new Office();

            office.OfficeDescription = txtOffice.Text;
            office.Day = txtDay.Text;
            office.Time = txtTime.Text;
            office.YearID = int.Parse(cmbYear.SelectedValue.ToString());
            office.ModuleID = int.Parse(cmbModule.SelectedValue.ToString());
            office.TimetableID = int.Parse(dgvTimeTable.SelectedRows[0].Cells["TimetableID"].Value.ToString());

            int z = bll.UpdateTime(office);

            if (z > 0)
            {
                MessageBox.Show(z + "Updated");
                txtOffice.Clear();
                this.Refresh();
            }
            else
            {
                MessageBox.Show(z + "Updated");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvTimeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTime_TextChanged(object sender, EventArgs e)
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
