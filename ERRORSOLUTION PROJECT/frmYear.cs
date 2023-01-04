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
    public partial class frmYear : Form
    {
        public frmYear()
        {
            InitializeComponent();
        }
        DataAccessLayer dal = new DataAccessLayer();
        BusinessLogicaLayer bll = new BusinessLogicaLayer();

        public void Refresh()
        {
            dgvYear.DataSource = bll.GetYearStudy();
        }
        private void frmYear_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnAddYear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYearDesc.Text))
            {
                errorProvider1.SetError(txtYearDesc, "Please do not leave field empty");
            }
            else
            {
                Year year = new Year();
                year.YearDescription = txtYearDesc.Text;

                int x = bll.InsertYearStudy(year);
                if (x > 0)
                {
                    MessageBox.Show(x + " Added");
                    Refresh();
                }
                else
                {
                    MessageBox.Show(x + " Added");
                    Refresh();
                }
            }
        }

        private void btnSelectYear_Click(object sender, EventArgs e)
        {
            dgvYear.DataSource = bll.GetYearStudy();
        }

        private void btnUpdateYear_Click(object sender, EventArgs e)
        {
            Year year = new Year();
            year.YearDescription = txtYearDesc.Text;

            year.YearID = int.Parse(dgvYear.SelectedRows[0].Cells["YearID"].Value.ToString());
            

            int x = bll.UpdateYearStudy(year);
            if (x > 0)
            {
                MessageBox.Show(x + " Updated");
                Refresh();
            }
            else
            {
                MessageBox.Show(x + " Updated");
                Refresh();
            }

        }

        private void btnDeleteYear_Click(object sender, EventArgs e)
        {
            Year year = new Year();
            year.YearID = int.Parse(dgvYear.SelectedRows[0].Cells["YearID"].Value.ToString());

            int x = bll.DeleteYearStudy(year);
            if (x > 0)
            {
                MessageBox.Show(x + " Deleted");
                Refresh();
            }
            else
            {
                MessageBox.Show(x + " Deleted");
                Refresh();
            }

        }

        private void dgvYear_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvYear.SelectedRows.Count > 0)
            {
                txtYearDesc.Text = dgvYear.SelectedRows[0].Cells["YearDescription"].Value.ToString();
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            frmRegistration rr = new frmRegistration();
            rr.Show();
            this.Hide();
        }
    }
}
