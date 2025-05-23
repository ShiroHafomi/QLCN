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
    public partial class frm_Staff : Form
    {
        public frm_Staff()
        {
            InitializeComponent();
        }

        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();


        private void frm_Staff_Load(object sender, EventArgs e)
        {
            LoadStaff();

        }

        private void dataGridView_Staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Tb_StaffID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Tb_Fullname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Tb_Position.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Tb_Phone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Staff(StaffID, Fullname, Position, Phone) " + "VALUES('" + Tb_StaffID.Text + "','" + Tb_Fullname.Text + "','" + Tb_Position.Text + "','" + Tb_Phone.Text + "')";
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Staff SET Fullname = '" + Tb_Fullname.Text + "','" + Tb_Position.Text + "','" + Tb_Phone.Text + "'WHERE StaffID = '" + Tb_StaffID.Text + "'";
            int kq = lopchung.ChucNang(sql);
            if (kq > 0)
            {
                MessageBox.Show("Update Success");

            }
            else
            {
                MessageBox.Show("Update Failed");
            }
            LoadStaff();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Staff WHERE StaffID = '" + Tb_StaffID.Text + "'";
            int kq = lopchung.ChucNang(sql);
            if (kq > 0)
            {
                MessageBox.Show("Delete Success");

            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
            LoadStaff();
        }



        public void LoadStaff()
        {
            string sql = "SELECT * from Staff";
            dataGridView1.DataSource = lopchung.LayDLBang(sql);
        }
    }
}
