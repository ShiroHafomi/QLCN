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
    public partial class frm_FeedingSchedule : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_FeedingSchedule()
        {
            InitializeComponent();
        }

        private void frm_FeedingSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_QuanLyChanNuoi_Minn_DataSet3.FeedingSchedule' table. You can move, or remove it, as needed.
            this.feedingScheduleTableAdapter.Fill(this._QuanLyChanNuoi_Minn_DataSet3.FeedingSchedule);
            // TODO: This line of code loads data into the '_QuanLyChanNuoi_Minn_DataSet2.Feed' table. You can move, or remove it, as needed.
            this.feedTableAdapter.Fill(this._QuanLyChanNuoi_Minn_DataSet2.Feed);
            // TODO: This line of code loads data into the '_QuanLyChanNuoi_Minn_DataSet1.Animal' table. You can move, or remove it, as needed.
            this.animalTableAdapter.Fill(this._QuanLyChanNuoi_Minn_DataSet1.Animal);

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO FeedingSchedule(ScheduleID, AnimalID, FeedID, FeedTime, Amount) " + "VALUES('" + ScheduleID_Text.Text + "','" + cmb_animalID.Text + "','" + cmb_FeedID.Text + "',Convert(datetime,'" + DT_FeedTime.Text + "',103),'" + Amount_Text.Text + "')";
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

        private void button_Update_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE FeedingSchedule SET AnimalID = '" + cmb_animalID.Text + "', FeedID = '" + cmb_FeedID.Text + "', FeedTime = Convert(datetime,'" + DT_FeedTime.Text + "',103), Amount = '" + Amount_Text.Text + "'WHERE ScheduleID = '" + ScheduleID_Text.Text + "'";
            int kq = lopchung.ChucNang(sql);
            if (kq > 0)
            {
                MessageBox.Show("Update Success");

            }
            else
            {
                MessageBox.Show("Update Failed");
            }
            LoadFeedingSchedule();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM FeedingSchedule WHERE ScheduleID = '" + ScheduleID_Text.Text + "'";
            int kq = lopchung.ChucNang(sql);
            if (kq > 0)
            {
                MessageBox.Show("Delete Success");

            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
            LoadFeedingSchedule();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ScheduleID_Text.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmb_animalID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmb_FeedID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            DT_FeedTime.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Amount_Text.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        public void LoadFeedingSchedule()
        {
            string sql = "SELECT * from FeedingSchedule";
            dataGridView1.DataSource = lopchung.LayDLBang(sql);
        }
    }
}
