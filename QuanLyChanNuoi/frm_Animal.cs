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
    public partial class frm_Animal: Form
    {
        public frm_Animal()
        {
            InitializeComponent();
        }

        private void frm_Animal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyChanNuoi1DataSet.Animal' table. You can move, or remove it, as needed.
            this.animalTableAdapter.Fill(this.quanLyChanNuoi1DataSet.Animal);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
