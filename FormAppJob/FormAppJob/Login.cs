using Microsoft.Win32;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void link_forgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            QuenMK fg = new QuenMK();
            fg.Show();
        }

        private void link_dangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangKy dk = new DangKy();
            dk.Show();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (btn_ungVien.Checked)
            {
                UV_TrangChu uv = new UV_TrangChu();
                uv.Show();
            }
            if (btn_doanhNghiep.Checked)
            {
                DN_TrangChu dn = new DN_TrangChu();
                dn.Show();
            }
        }
    }
}
