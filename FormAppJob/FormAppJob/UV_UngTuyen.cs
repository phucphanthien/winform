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
    public partial class UV_UngTuyen : Form
    {
        public UV_UngTuyen()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UV_TrangChu tc = new UV_TrangChu();
            tc.Show();
        }
    }
}
