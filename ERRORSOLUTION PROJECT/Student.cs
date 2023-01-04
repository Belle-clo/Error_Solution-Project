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
    public partial class Student : Form
    {
        BusinessLogicaLayer bll = new BusinessLogicaLayer();
        public static DataTable dt = Login.dtInf;
        public int StudentID = int.Parse(dt.Rows[0]["UserID"].ToString());
        public Student()
        {
            InitializeComponent();
        }
        public void GetUser()
        {
            cmbUser.DataSource = bll.Studentcmb();           
            cmbUser.DisplayMember ="Name";
            cmbUser.ValueMember ="UserID";
        }
        public void GetProgLan()
        {
            cmbProgramLang.DataSource = bll.GetProgLanguage();
            cmbProgramLang.ValueMember = "ProgLanguageID";
            cmbProgramLang.DisplayMember = "ProgLanguageDesc";
        }
        public void GetStudyYear()
        {
            cmbStudyYear.DataSource = bll.StudyYear();
            cmbStudyYear.ValueMember = "YearID";
            cmbStudyYear.DisplayMember = "Study Year";
        }
        public void GetModule()
        {
           cmbModule.DataSource = bll.GetModule(); 
           cmbModule.ValueMember = "ModuleID";
           cmbModule.DisplayMember = "ModuleDescription";
        }
        public void GetStatus()
        {
            cmbErrorStatus.Items.Add("Pending");
            cmbErrorStatus.Items.Add("Solved");
            cmbErrorStatus.Items.Add("Unsolved");
        }

        public void GetTopic()
        {
            cmbTopic.DataSource = bll.GetTopicDgv();
            cmbTopic.ValueMember = "TopicID";
            cmbTopic.DisplayMember="TopicDescription";
        }

        public void Refresh()
        {
            dgvStudent.DataSource = bll.GetStudent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                cmbUser.Text = dt.Rows[0]["UserID"].ToString();
                txtErrorDescription.Text = dt.Rows[0]["Error Description"].ToString();
                cmbModule.Text = dt.Rows[0]["ModuleID"].ToString();
                cmbProgramLang.Text = dt.Rows[0]["TopicModuleID"].ToString();
                cmbStudyYear.Text = dt.Rows[0]["YearID"].ToString();
                cmbErrorStatus.Text = dt.Rows[0]["ErrorStatus"].ToString();
                cmbTopic.Text = dt.Rows[0]["TopicID"].ToString();
                dtpErrorDate.Text = dt.Rows[0]["ErrorDate"].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtErrorDescription.Text))
            {
                errorProvider1.SetError(txtErrorDescription, "Please do not leave field empty");
            }
            else
            {
                dt = new DataTable();
                dt = Login.dtInf;
                StudentID = int.Parse(dt.Rows[0]["UserID"].ToString());

                Error error = new Error();
                error.StudentID = StudentID;
                error.StudentID = int.Parse(cmbUser.SelectedValue.ToString());
                error.ErrorDescription = txtErrorDescription.Text;
                error.ProgLanguageID = int.Parse(cmbProgramLang.SelectedValue.ToString());
                error.ModuleID = int.Parse(cmbModule.SelectedValue.ToString());
                error.YearID = int.Parse(cmbStudyYear.SelectedValue.ToString());
                error.ErrorStatus = cmbErrorStatus.SelectedItem.ToString();
                error.TopicID = int.Parse(cmbTopic.SelectedValue.ToString());
                error.ErrorDate = dtpErrorDate.Text;

                int a = bll.InsertStudent(error);
                if (a > 0)
                {
                    MessageBox.Show(a + "Added");
                    this.Refresh();
                    txtErrorDescription.Clear();


                }
                else
                {
                    MessageBox.Show(a + "Added");

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Error error = new Error();
            error.StudentID = int.Parse(cmbUser.SelectedValue.ToString());
            error.ErrorDescription = txtErrorDescription.Text;
            error.ProgLanguageID = int.Parse(cmbProgramLang.SelectedValue.ToString());
            error.ModuleID = int.Parse(cmbModule.SelectedValue.ToString());
            error.YearID = int.Parse(cmbStudyYear.SelectedValue.ToString());
            error.ErrorStatus = cmbErrorStatus.SelectedItem.ToString();
            error.TopicID = int.Parse(cmbTopic.SelectedValue.ToString());
            error.ErrorDate = dtpErrorDate.Text;
            error.ErrorID = int.Parse(dgvStudent.SelectedRows[0].Cells["ErrorID"].Value.ToString());

            int a = bll.UpdateStudent(error);
            if (a > 0)
            {
                MessageBox.Show(a + "Updated");
                this.Refresh();
                
                txtErrorDescription.Clear();

            }
            else
            {
                MessageBox.Show(a + "Updated");

            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Error error = new Error();
            error.ErrorID = int.Parse(dgvStudent.SelectedRows[0].Cells["ErrorID"].Value.ToString());
            int a = bll.DeleteStudent(error);
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

        private void Student_Load(object sender, EventArgs e)
        {
            GetProgLan();
            GetUser();
            Refresh();
            GetStudyYear();
            GetModule();
            GetStatus();
            GetTopic();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            frmRegistration r = new frmRegistration();
            r.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRole_Click(object sender, EventArgs e)
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

        private void btnSearchErrorS_Click(object sender, EventArgs e)
        {
            frmReport_ErrorSolution ES = new frmReport_ErrorSolution();
            ES.Show();
            this.Hide();
        }

        private void dtpErrorDate_ValueChanged(object sender, EventArgs e)
        {
          
        }
    }
}
