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
    public partial class frm_healthcheck : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_healthcheck()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_healthcheck_Load(object sender, EventArgs e)
        {
            LoadHealthCheck();
            LoadAnimal();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO HealthCheck(CheckID, AnimalID, CheckDate, Status, Notes) " + "VALUES('" + CheckID_Text.Text + "','" + cmb_AnimalName.Text + "',Convert(datetime,'" + dt_Checkdate.Value + "'), '"+ Status_Text.Text+"', '" + Note_Text.Text + "')";
            int kq = lopchung.ChucNang(sql);
            if (kq > 0)
            {
                MessageBox.Show("Add Successed");

            }
            else
            {
                MessageBox.Show("Add Failed");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE HealthCheck SET AnimalID = '" + cmb_AnimalName.Text + "', CheckDate = Convert(datetime,'" + dt_Checkdate.Value + "'), Status = '"+ Status_Text.Text+"', Notes = '" + Note_Text.Text + "'WHERE CheckID = '" + CheckID_Text.Text + "'";
            int kq = lopchung.ChucNang(sql);
            if (kq > 0)
            {
                MessageBox.Show("Update Success");

            }
            else
            {
                MessageBox.Show("Update Failed");
            }
            LoadHealthCheck();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM HealthCheck WHERE CheckID = '" + CheckID_Text.Text + "'";
            int kq = lopchung.ChucNang(sql);
            if (kq > 0)
            {
                MessageBox.Show("Delete Success");

            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
            LoadHealthCheck();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CheckID_Text.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmb_AnimalName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dt_Checkdate.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Status_Text.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Note_Text.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        public void LoadHealthCheck()
        {
            string sql = "SELECT * from HealthCheck";
            dataGridView1.DataSource = lopchung.LayDLBang(sql);
        }
        public void LoadAnimal()
        {
            string querryLoad_Animal = "SELECT * FROM Animal";
            cmb_AnimalName.DataSource = lopchung.LayDLBang(querryLoad_Animal);
            cmb_AnimalName.DisplayMember = "Name";
            cmb_AnimalName.ValueMember = "AnimalID";
        }
    }
}
