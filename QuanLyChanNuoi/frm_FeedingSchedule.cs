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
    }
}
