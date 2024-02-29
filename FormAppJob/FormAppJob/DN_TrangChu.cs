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
    public partial class DN_TrangChu : Form
    {
        public DN_TrangChu()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            DN_AddJob add = new DN_AddJob();
            add.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DN_HoSo hs = new DN_HoSo();
            hs.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.Hide();
            DN_ListUV list = new DN_ListUV();
            list.Show();
        }
    }
}
