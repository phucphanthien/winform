using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAppJob
{
    public partial class UV_TrangChu : Form
    {
        public UV_TrangChu()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }


        private void btnUT_Click(object sender, EventArgs e)
        {
            this.Hide();
            UV_UngTuyen ut = new UV_UngTuyen();
            ut.Show();
        }

        private void btnHS_Click(object sender, EventArgs e)
        {
            this.Hide();
            UV_HoSo hsuv = new UV_HoSo();
            hsuv.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            UV_LichSu his = new UV_LichSu();
            his.Show();
        }
    }
}
