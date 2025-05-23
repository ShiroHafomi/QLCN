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
    public partial class frm_CareLOG : Form
    {
        public frm_CareLOG()
        {
            InitializeComponent();

        }

        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();



        private void frm_CareLOG_Load(object sender, EventArgs e)
        {
            LoadCareLog();
            LoadStaff();
            LoadAnimal();


        }

        private void button_ADD_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Carelog(LogID, AnimalID, StaffID, CareDate, Decription) " + "VALUES('" + LogID_Text.Text + "','" + cmb_Animal_Name.Text + "','" + cmb_Staff_Name.Text + "','" + CareDate_Text.Text + "','" + Desciption_Text.Text + "')";
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
           string sql = "UPDATE Carelog SET AnimailID = '" + cmb_Animal_Name.Text + "', StaffID = '" + cmb_Staff_Name.Text + "', CareDate = '" + CareDate_Text.Text + "',Desciption = '" + Desciption_Text.Text + "'WHERE LogID = '" + LogID_Text.Text + "'";
            int kq = lopchung.ChucNang(sql);
            if (kq > 0)
            {
                MessageBox.Show("Update Success");
                
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
            LoadCareLog();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Carelog WHERE LogID = '" + LogID_Text.Text + "'";
            int kq = lopchung.ChucNang(sql);
            if (kq > 0)
            {
                MessageBox.Show("Delete Success");

            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
            LoadCareLog();
        }
        public void LoadCareLog()
        {
            string sql = "SELECT * from Carelog";
            dataGridView1.DataSource = lopchung.LayDLBang(sql);
        }

        private void dataGridView_Staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LogID_Text.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmb_Animal_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmb_Staff_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            CareDate_Text.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Desciption_Text.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        public void LoadStaff()
        {
            string querryLoad_Staff = "SELECT * FROM Staff";
            cmb_Staff_Name.DataSource = lopchung.LayDLBang(querryLoad_Staff);
            cmb_Staff_Name.DisplayMember = "FullName";
            cmb_Staff_Name.ValueMember = "StaffID";
        }
        public void LoadAnimal()
        {
            string querryLoad_Animal = "SELECT * FROM Animal";
            cmb_Animal_Name.DataSource = lopchung.LayDLBang(querryLoad_Animal);
            cmb_Animal_Name.DisplayMember = "Name";
            cmb_Animal_Name.ValueMember = "AnimalID";
        }
    }
}
