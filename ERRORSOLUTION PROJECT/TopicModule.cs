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
    public partial class TopicModule : Form
    {
        public TopicModule()
        {
            InitializeComponent();
        }
        BusinessLogicaLayer bll = new BusinessLogicaLayer();
        DataAccessLayer dal = new DataAccessLayer();

        public void FillModuleID()
        {
            cmbModuleID.DisplayMember ="ModuleDescription";
            cmbModuleID.ValueMember ="ModuleID";
            cmbModuleID.DataSource = bll.GetModule();
        }
        public void FillTopicID()
        {
            cmbTopicID.DisplayMember = "TopicDescription";
            cmbTopicID.ValueMember = "TopicID";
            cmbTopicID.DataSource = bll.GetTopic();
        }
        public void Refresh()
        {
            dgvTopicModule.DataSource = bll.GetTopicModule();
        }
        private void TopicModule_Load(object sender, EventArgs e)
        {
            Refresh();
            FillModuleID();
            FillTopicID();
        }

        private void btnAddTopicModule_Click(object sender, EventArgs e)
        {
            ModuleTopic moduleTopic = new ModuleTopic();
           
            moduleTopic.ModuleID = int.Parse(cmbModuleID.SelectedValue.ToString());
            moduleTopic.TopicID = int.Parse(cmbTopicID.SelectedValue.ToString());

            int x = bll.InsertModuleTopic(moduleTopic);
            if (x > 0)
            {
                Refresh();
                MessageBox.Show(x + " Added");
                Refresh();
            }
            else
            {
                Refresh();
                MessageBox.Show(x + " Added");
                Refresh();
            }
        }

        private void btnSelectTopicModule_Click(object sender, EventArgs e)
        {
            dgvTopicModule.DataSource = bll.GetTopicModule();
        }

        private void btnUpdateTopicModule_Click(object sender, EventArgs e)
        {
            ModuleTopic moduleTopic = new ModuleTopic();


            moduleTopic.ModuleTopicID = int.Parse(dgvTopicModule.SelectedRows[0].Cells["TopicModuleID"].Value.ToString());

            moduleTopic.ModuleID = int.Parse(cmbModuleID.SelectedValue.ToString());
            moduleTopic.TopicID = int.Parse(cmbTopicID.SelectedValue.ToString());

            int x = bll.UpdateModuleTopic(moduleTopic);

            if (x > 0)
            {
                MessageBox.Show(x + " Updated");
                Refresh();
            }
            else
            {
                MessageBox.Show(x + " Updated");
            }
        }

        private void btnDeleteTopicModule_Click(object sender, EventArgs e)
        {
            ModuleTopic moduleTopic = new ModuleTopic();

            moduleTopic.ModuleTopicID = int.Parse(dgvTopicModule.SelectedRows[0].Cells["TopicModuleID"].Value.ToString());

            int x = bll.DeleteModuleTopic(moduleTopic);
            if (x > 0)
            {
                MessageBox.Show(x + " Deleted");
                Refresh();
            }
            else
            {
                MessageBox.Show(x + " Deleted");
            }
        }

        private void dgvTopicModule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTopicModule.SelectedRows.Count > 0)
            {
                cmbModuleID.Text = dgvTopicModule.SelectedRows[0].Cells["ModuleDescription"].Value.ToString();
                cmbTopicID.Text = dgvTopicModule.SelectedRows[0].Cells["TopicDescription"].Value.ToString();
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
