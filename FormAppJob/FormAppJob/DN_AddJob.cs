using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAppJob
{
    public partial class DN_AddJob : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        CongViecDAO cvdao = new CongViecDAO();
        private string id;
        private string viTri;
        private string linhVuc;
        private string mucLuong;

        public DN_AddJob()
        {
            InitializeComponent();
        }

        private void AddJob_Load(object sender, EventArgs e)
        {
            dtJob.DataSource = cvdao.Load();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text) && cbviTri.SelectedItem != null && cblinhVuc.SelectedItem != null && cbmucLuong.SelectedItem != null)
            {
                id = txtID.Text;

                viTri = cbviTri.SelectedItem.ToString();
                linhVuc = cblinhVuc.SelectedItem.ToString();
                mucLuong = cbmucLuong.SelectedItem.ToString();

                CongViec cv = new CongViec(id, viTri, linhVuc, mucLuong);
                cvdao.Sua(cv);

                dtJob.DataSource = cvdao.Load();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá trị ID và chọn giá trị cho tất cả các lực chọn để sửa.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DN_TrangChu tc = new DN_TrangChu();
            tc.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                id = txtID.Text;

                CongViec cv = new CongViec(id, viTri, linhVuc, mucLuong);
                cvdao.Xoa(cv);

                dtJob.DataSource = cvdao.Load();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá trị ID để xóa.");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbviTri.SelectedItem != null && cblinhVuc.SelectedItem != null && cbmucLuong.SelectedItem != null)
            {
                viTri = cbviTri.SelectedItem.ToString();
                linhVuc = cblinhVuc.SelectedItem.ToString();
                mucLuong = cbmucLuong.SelectedItem.ToString();

                CongViec cv = new CongViec(viTri, linhVuc, mucLuong);
                cvdao.Them(cv);

               /*/ cbviTri.SelectedIndex = -1;
                cblinhVuc.SelectedIndex = -1;
                cbmucLuong.SelectedIndex = -1;*/
                dtJob.DataSource = cvdao.Load();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giá trị cho tất cả các lựa chọn.");
            }
        }

        private void dtJob_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtJob.Font = new Font("Arial", 12);
            dtJob.DefaultCellStyle.Font = new Font("Arial", 12);
        }
    }
}
