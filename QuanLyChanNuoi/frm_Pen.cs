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
    public partial class frm_Pen: Form
    {
        public frm_Pen()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG LOPDUNGCHUNG = new LOPDUNGCHUNG();
        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE PEN SET Name = '"+PenID_Text.Text+"', '"+Penname_text.Text+ "', '"+Capacity_text.Text+ "', '"+Location_text.Text+"'";
            int kq = LOPDUNGCHUNG.ChucNang(sql);
            if(kq > 0)
            {
                MessageBox.Show("Update Success");
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
            LoadPen();
        }

        private void frm_Pen_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO PEN (PenID, PenName, Capacity, Location) VALUES ('" + PenID_Text.Text + "', '" + Penname_text.Text + "', '" + Capacity_text.Text + "', '" + Location_text.Text + "')";
            int kq = LOPDUNGCHUNG.ChucNang(sql);
            if (kq > 0)
            {
                MessageBox.Show("Add Success");
                
            }
            else
            {
                MessageBox.Show("Add Failed");
            }
            LoadPen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM PEN WHERE PenID = '" + PenID_Text.Text + "'";
            int kq = LOPDUNGCHUNG.ChucNang(sql);
            if (kq > 0)
            {
                MessageBox.Show("Delete Success");
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
            LoadPen();
        }
        public void LoadPen()
        {
            string sql = "SELECT * from Animal";
            dataGridView1.DataSource = LOPDUNGCHUNG.LayDLBang(sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            PenID_Text.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Penname_text.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Capacity_text.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Location_text.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
