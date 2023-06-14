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
    public partial class DangNhap : Form
    {
        string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=NanoThucTap;Integrated Security=True";
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataAdapter adapter;
        SqlDataReader docdulieu;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            errorProvider1.Clear();
            thuchien = new SqlCommand();
            /*sql = "select * from DM_NguoiDung where TenNguoiDung='"+txtTaiKhoan.Text+"' AND MatKhau='"+txtMatKhau.Text+"'";*/
            thuchien.CommandText = "dangnhap";
            thuchien.CommandType = CommandType.StoredProcedure;
            thuchien.Connection = ketnoi;
            string TK = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            thuchien.Parameters.Add("@taikhoan", SqlDbType.NVarChar).Value = TK;
            thuchien.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = mk;
            /* thuchien = new SqlCommand(sql, ketnoi);*/
            docdulieu = thuchien.ExecuteReader();
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản!!");
                errorProvider1.SetError(txtTaiKhoan, "Nhập đi cụ ơi!");
                txtTaiKhoan.Focus();
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!!");
                errorProvider1.SetError(txtMatKhau, "chưa nhập mật khẩu cụ ơi!!");
                txtTaiKhoan.Focus();

            }
            else if (docdulieu.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
                txtTaiKhoan.Focus();
            }
            ketnoi.Close();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            thuchien = new SqlCommand();
            thuchien.Connection = ketnoi;

            //lưu thông tin cho những lần đăng nhập tiếp theo
            txtTaiKhoan.Text = Properties.Settings.Default.taikhoan;
            txtMatKhau.Text = Properties.Settings.Default.matkhau;
            if(Properties.Settings.Default.taikhoan != "")
            {
                ckbNhoMk.Checked = true;
            }
        }

        private void ckbNhoMk_CheckedChanged(object sender, EventArgs e)
        {
           if(txtMatKhau.Text != null && txtTaiKhoan.Text != null)
            {
                if (ckbNhoMk.Checked)
                {
                    string user = txtTaiKhoan.Text;
                    string password = txtMatKhau.Text;
                    Properties.Settings.Default.taikhoan = user;
                    Properties.Settings.Default.matkhau = password;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult v = MessageBox.Show("bạn có muốn thoát không?", "thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (v == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ckbHienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienthi.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            DangKy dangKy = new DangKy();
            this.Hide();
            dangKy.Show();
        }
    }
}
