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
    public partial class frmTopic : Form
    {
        public frmTopic()
        {
            InitializeComponent();
        }

        BusinessLogicaLayer bll = new BusinessLogicaLayer();

        private void button2_Click(object sender, EventArgs e)
        {
            Topic updateTopic = new Topic();

            updateTopic.TopicDescription = txtTopicDescription.Text;

            updateTopic.TopicID = int.Parse(dgvTopic.SelectedRows[0].Cells["TopicID"].Value.ToString());

            int z = bll.UpdateTopic(updateTopic);

            if (z > 0)
            {
                MessageBox.Show(z + "Updated");
                txtTopicDescription.Clear();
                this.Refresh();

            }
            else
            {
                MessageBox.Show(z + "Updated");
            }
        }

        public void Refresh ()
        {
            dgvTopic.DataSource = bll.GetTopicDgv(); 
        }

        private void frmTopic_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTopicDescription.Text))
            {
                errorProvider1.SetError(txtTopicDescription, "Please do not leave field empty");
            }
            else
            {
                Topic topic = new Topic();

                topic.TopicDescription = txtTopicDescription.Text;


                int z = bll.InsertTopic(topic);

                if (z > 0)
                {
                    MessageBox.Show(z + "Topic Added");
                    Refresh();
                }
                else
                {
                    MessageBox.Show(z + "Topic Added");
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            TopicModule t = new TopicModule();
            t.Show();
            this.Hide();
        }

        private void dgvTopic_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
