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
    public partial class frm_Feed : Form
    {
        public frm_Feed()
        {
            InitializeComponent();
        }

        private void frm_Feed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_QuanLyChanNuoi_Minn_DataSet.Feed' table. You can move, or remove it, as needed.
            this.feedTableAdapter.Fill(this._QuanLyChanNuoi_Minn_DataSet.Feed);

        }
    }
}
