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

namespace SinhvienFull
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=NanoThucTap;Integrated Security=True";
        SqlConnection ketnoi;
        SqlCommand thuchien;
        private void ckbHienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienthi.Checked)
            {
                txtMKmoi.PasswordChar = (char)0;
                txtNhaplai.PasswordChar = (char)0;
            }
            else
            {
                txtMKmoi.PasswordChar = (char)0;
                txtNhaplai.PasswordChar = (char)0;
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            thuchien = new SqlCommand();
            thuchien.Connection = ketnoi;

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.Open();
                thuchien = new SqlCommand();
                thuchien.CommandText = "DangKy";
                thuchien.CommandType = CommandType.StoredProcedure;
                thuchien.Connection = ketnoi;

                thuchien.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar).Value = txtTaikhoan.Text;
                thuchien.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = txtMKmoi.Text;
                thuchien.Parameters.Add("@MatKhauNhapLai", SqlDbType.NVarChar).Value = txtNhaplai.Text;
                thuchien.ExecuteNonQuery();
                ketnoi.Close();


                MessageBox.Show("Đăng ký người dùng thành công.");
                DangNhap dangNhap = new DangNhap();
                this.Hide();
                dangNhap.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void ckbHienthi_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (ckbHienthi.Checked)
                {
                    txtMKmoi.PasswordChar = (char)0;
                    txtNhaplai.PasswordChar = (char)0;
                }
                else
                {
                    txtMKmoi.PasswordChar = (char)0;
                    txtNhaplai.PasswordChar = (char)0;
                }
            }
        }
    }
}