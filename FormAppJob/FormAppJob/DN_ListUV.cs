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
    public partial class DN_ListUV : Form
    {
        public DN_ListUV()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DN_TrangChu tc = new DN_TrangChu();
            tc.Show();
        }
    }
}
