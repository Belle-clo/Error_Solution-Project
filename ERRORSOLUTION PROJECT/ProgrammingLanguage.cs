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
    public partial class ProgrammingLanguage : Form
    {
        public ProgrammingLanguage()
        {
            InitializeComponent();
        }
        BusinessLogicaLayer bll = new BusinessLogicaLayer();
        private void ProgrammingLanguage_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProgLang.Text))
            {
                errorProvider1.SetError(txtProgLang, "Please do not leave field empty");
            }
            else
            {


                ProgLang proglang = new ProgLang();
                proglang.ProgLangDesc = txtProgLang.Text;



                int z = bll.InsertProgLanguage(proglang);

                if (z > 0)
                {
                    MessageBox.Show(z + "Added");
                    txtProgLang.Clear();
                    this.Refresh();
                }
                else
                {
                    MessageBox.Show(z + "Added");
                }
            }
        }

        public void Refresh()
        {
            dgvProgLang.DataSource = bll.GetProgLanguage();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            ProgLang progLang = new ProgLang();
            ProgLang progLangID = new ProgLang();
            progLangID.ProgLanguageID = int.Parse(dgvProgLang.SelectedRows[0].Cells["ProgLanguageID"].Value.ToString()); ;
            progLang.ProgLangDesc = txtProgLang.Text;

            int a = bll.UpdateProgLanguage(progLangID,progLang);
            if (a > 0)
            {
                MessageBox.Show(a + "Updated");
                 txtProgLang.Clear();
                 this.Refresh();
            }
            else
            {
                MessageBox.Show(a + "Updated");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProgLang lang = new ProgLang();
            lang.ProgLanguageID = int.Parse(dgvProgLang.SelectedRows[0].Cells["ProgLanguageID"].Value.ToString());
            int a = bll.DeleteProgLanguage(lang);
            if (a > 0)
            {
                MessageBox.Show(a + "Deleted");
                dgvProgLang.DataSource = bll.GetProgLanguage();
            }
            else
            {
                MessageBox.Show(a + "Deleted");
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
