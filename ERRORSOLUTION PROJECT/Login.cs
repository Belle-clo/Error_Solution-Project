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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        BusinessLogicaLayer bll = new BusinessLogicaLayer();
        public static DataTable dtInf;
        private void Login_Load(object sender, EventArgs e)
        {
            
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                lblEmaile.ForeColor = Color.Green;
                lblEmaile.Text = "Valid";

            }
            else
            {
                lblEmaile.ForeColor = Color.Red;
                lblEmaile.Text = "Invalid";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dtInf = bll.GetLogin(txtEmail.Text, txtPassword.Text);
            string role = dtInf.Rows[0]["RoleID"].ToString();
            if (dtInf.Rows.Count > 0)
            {

                if (role == "2")
                {
                    frmRegistration f = new frmRegistration();
                    f.Show();
                    this.Hide();
                }
               else if (role == "3")
                {
                    Student f = new Student();
                    
                    f.Show();
                    this.Hide();
                   
                }
               else if (role == "1")
               {
                    Lecturer f = new Lecturer();
                    f.Show();
                    this.Hide();
               }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
        
    

    
}
