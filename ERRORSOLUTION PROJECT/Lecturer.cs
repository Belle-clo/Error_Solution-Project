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
    public partial class Lecturer : Form
    {
        public Lecturer()
        {
            InitializeComponent();
        }
        
        BusinessLogicaLayer bll = new BusinessLogicaLayer();
        public static DataTable dt = Login.dtInf;
        public int LecturerID = int.Parse(dt.Rows[0]["UserID"].ToString());

        //need to add module cmb for solution and error forms


        private void Lecturer_Load(object sender, EventArgs e)
        {
             
            LoadError();
            LoadUser();
            Refresh();
            RefreshF();
            LoadErrorSolution();
        }

        public void LoadErrorSolution()
        {
            cmbErrorSolution.DataSource = bll.GetErrorSolution();
            cmbErrorSolution.ValueMember = "SolutionID";
            cmbErrorSolution.DisplayMember = "SolutionDescription";

        }

        public void LoadError()
        {
            cmbError.DataSource = bll.GetErrorID();
            cmbError.ValueMember = "ErrorID";
            cmbError.DisplayMember = "ErrorDescription";
        }

        public void LoadUser()
        {
           cmbName.DataSource = bll.Lecturercmb();
            cmbName.ValueMember = "UserID";
            cmbName.DisplayMember = "Name";
        }


        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSolutionDescription.Text))
            {
                errorProvider1.SetError(txtSolutionDescription, "Please do not leave field empty");
            }
            else
            {
                dt = new DataTable();
                dt = Login.dtInf;
                LecturerID = int.Parse(dt.Rows[0]["UserID"].ToString());

                Solution solution = new Solution();
                solution.SolutionDescription = txtSolutionDescription.Text;
                solution.LecturerID = LecturerID;
                solution.LecturerID = int.Parse(cmbName.SelectedValue.ToString());

                int z = bll.InsertSolution(solution);

                if (z > 0)
                {
                    MessageBox.Show(z + "Solution Added");
                    txtSolutionDescription.Clear();
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
            dgvSolutionDetails.DataSource = bll.GetSolution();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Solution update = new Solution();

            update.SolutionDescription = txtSolutionDescription.Text;
            update.LecturerID = int.Parse(cmbName.SelectedValue.ToString());
            update.SolutionID = int.Parse(dgvSolutionDetails.SelectedRows[0].Cells["SolutionID"].Value.ToString());

            int z = bll.UPDATE(update);

            if (z > 0)
            {
                MessageBox.Show(z + "Updated");
                txtSolutionDescription.Clear();
                this.Refresh();

            }
            else
            {
                MessageBox.Show(z + "Updated");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Solution Delete = new Solution();
            Delete.SolutionID = int.Parse(dgvSolutionDetails.SelectedRows[0].Cells["SolutionID"].Value.ToString());

            int x = bll.SolutionDelete(Delete);

            if (x > 0)
            {
                MessageBox.Show(x + "\t" + "Deleted");
                this.Refresh();
            }
            else
            {
                MessageBox.Show(x + "\t" + "Deleted");
            }
        }

        private void btnAdded_Click(object sender, EventArgs e)
        {
            ErrorSolution errorSolution = new ErrorSolution();
            
            errorSolution.ErrorID = int.Parse(cmbError.SelectedValue.ToString());
            errorSolution.SolutionID = int.Parse(cmbErrorSolution.SelectedValue.ToString());
            errorSolution.SolutionDate = dtp.Text;

            int z = bll.InsertErrorSolution(errorSolution);

            if (z > 0)
            {
                MessageBox.Show(z + " Added");
                this.RefreshF();

            }
            else
            {
                MessageBox.Show(z + "Added");
            }
        }

        public void RefreshF()
        {
            dgvErrorSolution.DataSource = bll.GetErrorSolutionDgvv();
        }

        private void btnDisplayed_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdated_Click(object sender, EventArgs e)
        {
            ErrorSolution updateErrorSolution = new ErrorSolution();

           
            updateErrorSolution.SolutionDate = dtp.Text;
            updateErrorSolution.ErrorID = int.Parse(cmbError.SelectedValue.ToString());
            updateErrorSolution.SolutionID = int.Parse(cmbErrorSolution.SelectedValue.ToString());

            updateErrorSolution.ErrorSolutionID = int.Parse(dgvErrorSolution.SelectedRows[0].Cells["ErrorSolutionID"].Value.ToString());


            int p = bll.UPDATEERRORSOLUTION(updateErrorSolution);

            if (p > 0)
            {
                MessageBox.Show(p + " Updated");
                this.RefreshF();
            }
            else
            {
                MessageBox.Show(p + "Updated");
            }
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {

            ErrorSolution DeleteES = new ErrorSolution();
            DeleteES.ErrorSolutionID = int.Parse(dgvErrorSolution.SelectedRows[0].Cells["ErrorSolutionID"].Value.ToString());

            int x = bll.DeleteErrorSolution(DeleteES);

            if (x > 0)
            {
                MessageBox.Show(x + "\t" + " Deleted");
                txtSolutionDescription.Clear();
                this.RefreshF();
            }
            else
            {
                MessageBox.Show(x + "\t" + " Deleted");
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            

        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvErrorSolution_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmReports_User user = new frmReports_User();
            user.Show();
            this.Hide();
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            frmReportTimetable TT = new frmReportTimetable();
            TT.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
