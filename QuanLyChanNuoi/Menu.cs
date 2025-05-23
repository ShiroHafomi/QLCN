using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChanNuoi
{
    public partial class Menu: Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Animal"] == null)
            {
                frm_Animal an = new frm_Animal();
                an.MdiParent = this;
                an.Show();
            }
            else Application.OpenForms["frm_Animal"].Activate();
        }

        private void penToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Pen"] == null)
            {
                frm_Pen an = new frm_Pen();
                an.MdiParent = this;
                an.Show();
            }
            else Application.OpenForms["frm_Pen"].Activate();
        }

        private void feedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Feed"] == null)
            {
                frm_Feed an = new frm_Feed();
                an.MdiParent = this;
                an.Show();
            }
            else Application.OpenForms["frm_Feed"].Activate();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Staff"] == null)
            {
                frm_Staff an = new frm_Staff();
                an.MdiParent = this;
                an.Show();
            }
            else Application.OpenForms["frm_Staff"].Activate();
        }

        private void caToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_CareLOG"] == null)
            {
                frm_CareLOG an = new frm_CareLOG();
                an.MdiParent = this;
                an.Show();
            }
            else Application.OpenForms["frm_CareLOG"].Activate();
        }

        private void feedingScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_FeedingSchedule"] == null)
            {
                frm_FeedingSchedule an = new frm_FeedingSchedule();
                an.MdiParent = this;
                an.Show();
            }
            else Application.OpenForms["frm_FeedingSchedule"].Activate();
        }

        private void healthCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_healthcheck"] == null)
            {
                frm_healthcheck an = new frm_healthcheck();
                an.MdiParent = this;
                an.Show();
            }
            else Application.OpenForms["frm_healthcheck"].Activate();
        }
    }
}
