using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChanNuoi
{
    public partial class frm_Feed : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_Feed()
        {
            InitializeComponent();
        }

        private void frm_Feed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_QuanLyChanNuoi_Minn_DataSet.Feed' table. You can move, or remove it, as needed.
            this.feedTableAdapter.Fill(this._QuanLyChanNuoi_Minn_DataSet.Feed);

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Feed(FeedID, FeedName, Description, Quantity, Unit) " + "VALUES('" + FeedID_Text.Text + "','" + FeedName_Text.Text + "','" + Description_Text.Text + "','" + Quantity_Text.Text + "','" + Unit_Text.Text + "')";
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
            string sql = "UPDATE Animal SET FeedName = '" + FeedName_Text.Text + "', Description = '" + Description_Text.Text + "', Quantity = '" + Quantity_Text.Text + "',Unit = '" + Unit_Text.Text + "'WHERE FeedID = '" + FeedID_Text.Text + "'";
            int kq = lopchung.ChucNang(sql);
            if (kq > 0)
            {
                MessageBox.Show("Update Success");
                
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
            LoadFeed();
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FeedID_Text.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            FeedName_Text.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Description_Text.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Quantity_Text.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Unit_Text.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Feed WHERE FeedID = '" + FeedID_Text.Text + "'";
            int kq = lopchung.ChucNang(sql);
            if (kq > 0)
            {
                MessageBox.Show("Delete Success");
                
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
            LoadFeed();
        }
        public void LoadFeed()
        {
            string sql = "SELECT * from Feed";
            dataGridView1.DataSource = lopchung.LayDLBang(sql);
        }
    }
}
