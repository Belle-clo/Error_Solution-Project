using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BLL;
using DAL;

namespace ERRORSOLUTION_PROJECT
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }
        BusinessLogicaLayer bll = new BusinessLogicaLayer();
     
        private void frmRegistration_Load(object sender, EventArgs e)
        {
            
            LoadUser();
            LoadStatus();
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstname.Text))
            {
                errorProvider1.SetError(txtFirstname, "Please do not leave field empty");
            }
            else
            {


                User userError = new User();

                userError.Username = txtFirstname.Text;
                userError.Surname = txtSurname.Text;
                userError.Email = txtEmail.Text;
                userError.Password = txtPassword.Text;
                userError.RoleID = int.Parse(cmbRoleDescription.SelectedValue.ToString());
                userError.UserStatus = cmbStatus.SelectedItem.ToString();

                int a = bll.InsertUser(userError);
                if (a > 0)
                {
                    MessageBox.Show(a + "Added");
                    this.Refresh();
                    txtFirstname.Clear();
                    txtSurname.Clear();
                    txtEmail.Clear();
                    txtPassword.Clear();
                }
                else
                {
                    MessageBox.Show(a + "Added");

                }
            }

        }
        public void Refresh()
        {
            dgvReg.DataSource = bll.GetUser();
        }
        public void LoadUser()
        {
            cmbRoleDescription.DataSource = bll.GetUserByID();
            cmbRoleDescription.ValueMember = "RoleID";
            cmbRoleDescription.DisplayMember = "RoleDescription";
        }
        public void LoadStatus()
        {
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("In-Active");
            cmbStatus.Items.Add("Pending");

        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
           

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User userError = new User();
            userError.Username = txtFirstname.Text;
            userError.Surname = txtSurname.Text;
            userError.Email = txtEmail.Text;
            userError.Password = txtPassword.Text;
            userError.RoleID = int.Parse(cmbRoleDescription.SelectedValue.ToString());
            userError.UserStatus = cmbStatus.SelectedItem.ToString();
            userError.UserID = int.Parse(dgvReg.SelectedRows[0].Cells["User ID"].Value.ToString());
            int a = bll.UpdateUser(userError);
            if (a > 0)
            {
                MessageBox.Show(a + "Updated");
                this.Refresh();
              
                txtEmail.Clear();
                txtPassword.Clear();
                dgvReg.DataSource = bll.GetUser();
            }
            else
            {
                MessageBox.Show(a + "Updated");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User userError = new User();
            userError.UserID = int.Parse(dgvReg.SelectedRows[0].Cells["User ID"].Value.ToString());
            int a = bll.DelectUser(userError);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvReg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReg.SelectedRows.Count > 0)
            {
                cmbRoleDescription.Text = dgvReg.SelectedRows[0].Cells["RoleID"].Value.ToString();
                txtFirstname.Text = dgvReg.SelectedRows[0].Cells["Username"].Value.ToString();
                txtSurname.Text = dgvReg.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.Text = dgvReg.SelectedRows[0].Cells["Email"].Value.ToString();
                cmbStatus.Text = dgvReg.SelectedRows[0].Cells["UserStatus"].Value.ToString();

            }
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            frmRole role = new frmRole();
            role.Show();
            this.Hide();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            frmYear year = new frmYear();
            year.Show();
            this.Hide();
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            frmModule module = new frmModule();
            module.Show();
            this.Hide();
        }

        private void btnTopic_Click(object sender, EventArgs e)
        {
            frmTopic topic = new frmTopic();
            topic.Show();
            this.Hide();
        }

        private void btnTopicModule_Click(object sender, EventArgs e)
        {
            TopicModule TM = new TopicModule();
            TM.Show();
            this.Hide();
        }

        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            frmTimeTable TT = new frmTimeTable();
            TT.Show();
            this.Hide();
        }

        private void btnProgLang_Click(object sender, EventArgs e)
        {
            ProgrammingLanguage prog = new ProgrammingLanguage();
            prog.Show();
            this.Hide();

        }
    }
}
