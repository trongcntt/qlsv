using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SinhvienFull
{
    public partial class Form1 : Form
    {
        string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=NanoThucTap;Integrated Security=True";
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataAdapter adapter;
        SqlDataReader docdulieu;
        public bool Luu = false;
        private int droppDown = 0;
        public Form1()
        {
            InitializeComponent();
        }
        class DiaChi
        {
            public DiaChi(string tinh, string huyen, string xa)
            {
                this.tinh = tinh;
                this.huyen = huyen;
                this.xa = xa;
            }

            public string tinh { get; set; }
            public string huyen { get; set; }

            public string xa { get; set; }

            public override string ToString()
            {
                return $"{xa}, {huyen}, {tinh}";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nanoThucTapDataSet.tinh' table. You can move, or remove it, as needed.
            this.tinhTableAdapter.Fill(this.nanoThucTapDataSet.tinh);
            ketnoi = new SqlConnection(chuoiketnoi);
            hienthidulieu();
            ketnoi.Open();
            thuchien = new SqlCommand();
            thuchien.CommandText = "LayDiaChi";
            thuchien.CommandType = CommandType.StoredProcedure;
            thuchien.Connection = ketnoi;
            docdulieu = thuchien.ExecuteReader();
            while (docdulieu.Read())
            {
                cbDiaChi.Items.Add(docdulieu["DiaChi"].ToString());
            }
            ketnoi.Close();
        }

        private void hienthidulieu()
        {
            ketnoi.Open();
            thuchien = new SqlCommand();
            thuchien.Connection = ketnoi;
            thuchien.CommandText = "SelectSV";
            thuchien.CommandType = CommandType.StoredProcedure;

            adapter = new SqlDataAdapter();
            adapter.SelectCommand = thuchien;
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            ketnoi.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            cbMaSV.Text = "";
            cbMaLop.Text = "";
            cbMaGV.Text = "";
            txtTenSV.Text = "";
            txtNamSinh.Text = "";
            cbGT.Text = "";
            cbDiaChi.Text = "";
            cbMaSV.Focus();
            Luu = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedRow = dataGridView1.SelectedRows[0];
            }
            else if (dataGridView1.SelectedCells.Count > 0)
            {
                selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
            }

            if (selectedRow != null)
            {

                // Đổ dữ liệu từ hàng được chọn lên các trường văn bản trong cell là tên cột
                txtID.Text = selectedRow.Cells["ID"].Value.ToString();
                cbMaSV.Text = selectedRow.Cells["MaSinhVien"].Value.ToString();
                cbMaLop.Text = selectedRow.Cells["MaLop"].Value.ToString();
                cbMaGV.Text = selectedRow.Cells["MaGiaoVien"].Value.ToString();
                txtTenSV.Text = selectedRow.Cells["TenSinhVien"].Value.ToString();
                txtNamSinh.Text = selectedRow.Cells["NamSinh"].Value.ToString();
                cbGT.Text = selectedRow.Cells["GioiTinh"].Value.ToString();
                cbTinh.Text = selectedRow.Cells["MaTinhThanh"].Value.ToString();
                cbHuyen.Text = selectedRow.Cells["MaQuanHuyen"].Value.ToString();
                cbXa.Text = selectedRow.Cells["MaXaPhuong"].Value.ToString();
                cbDiaChi.Text = cbXa.Text + "," + cbHuyen.Text + "," + cbTinh.Text;

            }
            cbMaSV.Focus();
            Luu = false;
        }

        private void cbDiaChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string diaChi = cbDiaChi.SelectedItem.ToString();
            string[] diaChiParts = diaChi.Split(',');

            string tenTinh = diaChiParts[0].Trim();
            string tenHuyen = diaChiParts[1].Trim();
            string tenXa = diaChiParts[2].Trim();
        }
        private bool ThongTinKhongDu()
        {
            // Kiểm tra điều kiện thông tin không đủ
            bool thieuThongTin = false;

            // Kiểm tra các điều khiển để xác định thông tin không đủ
            if (string.IsNullOrEmpty(cbMaSV.Text))
            {
                thieuThongTin = true;
            }

            if (string.IsNullOrEmpty(txtNamSinh.Text))
            {
                thieuThongTin = true;
            }
            if (string.IsNullOrEmpty(txtTenSV.Text))
            {
                thieuThongTin = true;
            }

            // ...

            return thieuThongTin;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            if (ThongTinKhongDu())
            {
                // Hiển thị cảnh báo đỏ cho các điều khiển không hợp lệ
                errorProvider1.SetError(cbMaSV, "Thông tin không được bỏ trống");
                errorProvider1.SetError(txtTenSV, "Thông tin không được bỏ trống");
                errorProvider1.SetError(txtNamSinh, "Thông tin không được bỏ trống");
                errorProvider1.SetError(cbMaGV, "Thông tin không được bỏ trống");
                errorProvider1.SetError(cbGT, "Thông tin không được bỏ trống");
                errorProvider1.SetError(cbHuyen, "Thông tin không được bỏ trống");
                errorProvider1.SetError(cbMaLop, "Thông tin không được bỏ trống");
                errorProvider1.SetError(cbXa, "Thông tin không được bỏ trống");
                errorProvider1.SetError(cbTinh, "Thông tin không được bỏ trống");
                // ...
            }
            else
            {
                string diaChi = cbDiaChi.SelectedItem.ToString();
                string[] diaChiParts = diaChi.Split(',');
                ketnoi.Open();
                if (Luu == true)
                {
                    thuchien = new SqlCommand();
                    thuchien.Connection = ketnoi;
                    thuchien.CommandText = "InsertSV";
                    thuchien.CommandType = CommandType.StoredProcedure;

                    thuchien.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = cbMaSV.Text;
                    thuchien.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = cbMaLop.Text;
                    thuchien.Parameters.Add("@MaGV", SqlDbType.VarChar).Value = cbMaGV.Text;
                    thuchien.Parameters.Add("@TenSV", SqlDbType.NVarChar).Value = txtTenSV.Text;
                    thuchien.Parameters.Add("@NamSinh", SqlDbType.VarChar).Value = txtNamSinh.Text;
                    thuchien.Parameters.Add("@GioiTinh", SqlDbType.VarChar).Value = cbGT.Text;
                    thuchien.Parameters.Add("@MaTT", SqlDbType.NVarChar).Value = diaChiParts[2];
                    thuchien.Parameters.Add("@MaQH", SqlDbType.NVarChar).Value = diaChiParts[1];
                    thuchien.Parameters.Add("@MaXP", SqlDbType.NVarChar).Value = diaChiParts[0];
                    thuchien.ExecuteNonQuery();
                }
                else if (Luu == false)
                {
                    thuchien = new SqlCommand();
                    thuchien.Connection = ketnoi;
                    thuchien.CommandText = "UpdateSV";
                    thuchien.CommandType = CommandType.StoredProcedure;

                    thuchien.Parameters.Add("@id", SqlDbType.VarChar).Value = txtID.Text;
                    thuchien.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = cbMaSV.Text;
                    thuchien.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = cbMaLop.Text;
                    thuchien.Parameters.Add("@MaGV", SqlDbType.VarChar).Value = cbMaGV.Text;
                    thuchien.Parameters.Add("@TenSV", SqlDbType.NVarChar).Value = txtTenSV.Text;
                    thuchien.Parameters.Add("@NamSinh", SqlDbType.VarChar).Value = txtNamSinh.Text;
                    thuchien.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = cbGT.Text;
                    thuchien.Parameters.Add("@MaTT", SqlDbType.NVarChar).Value = diaChiParts[2];
                    thuchien.Parameters.Add("@MaQH", SqlDbType.NVarChar).Value = diaChiParts[1];
                    thuchien.Parameters.Add("@MaXP", SqlDbType.NVarChar).Value = diaChiParts[0];
                    thuchien.ExecuteNonQuery();
                }
                ketnoi.Close();
                hienthidulieu();
            }
        }

        private void cbTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            ketnoi.Open();
            cbHuyen.Items.Clear();
            cbXa.Items.Clear();

            string sql = "GetHuyenByTinh";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.CommandType = CommandType.StoredProcedure;
            thuchien.Parameters.AddWithValue("@TenTT", cbTinh.Text);
            docdulieu = thuchien.ExecuteReader();

            while (docdulieu.Read())
            {
                cbHuyen.Items.Add(docdulieu[0].ToString());
            }

            ketnoi.Close();
        }

        private void cbHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ketnoi.Open();
            cbXa.Items.Clear();
           string sql = "GetXaByTinh";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.CommandType = CommandType.StoredProcedure;
            thuchien.Parameters.AddWithValue("@TenQH", cbHuyen.Text);
            docdulieu = thuchien.ExecuteReader();
            int i = 0;
            while (docdulieu.Read())
            {
                cbXa.Items.Add(docdulieu[0].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool hasSelectedItems = false;
            List<int> selectedIDs = new List<int>();

            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];

                if (row.Selected)
                {
                    hasSelectedItems = true;
                    int id = Convert.ToInt32(row.Cells["ID"].Value);
                    selectedIDs.Add(id);
                }
            }

            if (selectedIDs.Count > 0)
            {
                ketnoi.Open();
                thuchien = new SqlCommand();
                thuchien.Connection = ketnoi;
                thuchien.CommandText = "DeleteSelected";
                thuchien.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = thuchien.Parameters.AddWithValue("@IDs", string.Join(",", selectedIDs));
                parameter.SqlDbType = SqlDbType.VarChar;
                thuchien.ExecuteNonQuery();

                ketnoi.Close();
                hienthidulieu();
                MessageBox.Show("Đã xóa các hàng đã chọn thành công.");
            }


            if (ckbAll.Checked)
            {
                ketnoi.Open();
                thuchien = new SqlCommand();
                thuchien.Connection = ketnoi;
                thuchien.CommandText = "deleteAll";
                thuchien.CommandType = CommandType.StoredProcedure;
                thuchien.ExecuteNonQuery();
                ketnoi.Close();
                hienthidulieu();
            }

            if (!hasSelectedItems && !ckbAll.Checked && dataGridView1.SelectedRows.Count <= 1)
            {
                MessageBox.Show("Không có mục nào được chọn.");
            }
        }

        private void ckbAll_CheckedChanged(object sender, EventArgs e)
        {
            bool selectAll = ckbAll.Checked;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (ckbAll.Checked)
                {
                    dataGridView1.Rows[row.Index].SetValues(true);

                    row.Selected = selectAll;
                }
                else
                {
                    dataGridView1.Rows[row.Index].SetValues(false);

                    row.Selected = false;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                dataGridView1.Rows[e.RowIndex].Selected = true;

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Kiểm tra xem sự kiện xảy ra trên hàng dữ liệu và không phải trên hàng mới
            if (e.RowIndex >= 0 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Lấy giá trị từ cột tương ứng trong hàng được chọn
                string id = selectedRow.Cells["ID"].Value.ToString();
                string MaSV = selectedRow.Cells["MaSinhVien"].Value.ToString();
                string MaLop = selectedRow.Cells["MaLop"].Value.ToString();
                string MaGV = selectedRow.Cells["MaGiaoVien"].Value.ToString();
                string TenSV = selectedRow.Cells["TenSinhVien"].Value.ToString();
                string NamSinh = selectedRow.Cells["NamSinh"].Value.ToString();
                string GioiTinh = selectedRow.Cells["GioiTinh"].Value.ToString();
                string MaTT = selectedRow.Cells["MaTinhThanh"].Value.ToString();
                string MaQH = selectedRow.Cells["MaQuanHuyen"].Value.ToString();
                string MaXP = selectedRow.Cells["MaXaPhuong"].Value.ToString();
                // Gán giá trị lên các TextBox
                txtID.Text = id;
                cbMaSV.Text = MaSV;
                cbMaLop.Text = MaLop;
                cbMaGV.Text = MaGV;
                txtTenSV.Text = TenSV;
                txtNamSinh.Text = NamSinh;
                cbGT.Text = GioiTinh;
                cbTinh.Text = MaTT;
                cbHuyen.Text = MaQH;
                cbXa.Text = MaXP;
                cbDiaChi.Text = cbXa.Text + "," + cbHuyen.Text + "," + cbTinh.Text;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            cbMaSV.Text = "";
            cbMaLop.Text = "";
            cbMaGV.Text = "";
            txtTenSV.Text = "";
            txtNamSinh.Text = "";
            cbGT.Text = "";
            cbDiaChi.Text = "";

            ketnoi.Open();
            thuchien = new SqlCommand("search", ketnoi);
            string searchSV = txtSearch.Text.Trim();
            thuchien.CommandType = CommandType.StoredProcedure;
            thuchien.Parameters.Add("@tukhoa", SqlDbType.NVarChar).Value = searchSV;
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = thuchien;
            adapter.SelectCommand.Connection = ketnoi;

            DataSet data = new DataSet();
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
            adapter.Dispose();
            ketnoi.Close();
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Tên Bạn tìm kiếm không có trong danh sách");
            }
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Xin mời nhập tên cần tìm");
            }

        }

       

        private void cbMaSV_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbMaSV, "");

        }

        private void cbMaLop_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbMaLop, "");
        }

        private void cbMaGV_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbMaGV, "");
        }

        private void txtTenSV_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenSV, "");
        }

        private void txtNamSinh_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNamSinh, "");
        }

        private void cbGT_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbGT, "");
        }

        private void cbDiaChi_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbDiaChi, "");
        }

        private void cbTinh_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbTinh, "");
        }

        private void cbHuyen_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbHuyen, "");
        }

        private void cbXa_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbXa, "");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimdc_Click(object sender, EventArgs e)
        {
            string tim = txtTimDc.Text.Trim();
            string diachitimthay = "";
            foreach (var item in cbDiaChi.Items)
            {
                string itemDiaChi = item + "";
                //tách các thành phần trong itemDiaChi
                string[] diaChiParts = itemDiaChi.Split(',');
                if (diaChiParts.Length == 3)
                {
                    string tenXa = Tachtuviettat(diaChiParts[0]);
                    string tenHuyen = Tachtuviettat(diaChiParts[1]);
                    string tenTinh = Tachtuviettat(diaChiParts[2]);
                    string tuVietTat = $"{tenXa},{tenHuyen},{tenTinh}".ToLower();
                    /*  MessageBox.Show(itemDiaChi);
                      MessageBox.Show(tuVietTat);*/
                    if (tuVietTat == tim)
                    {
                        diachitimthay = itemDiaChi;
                        cbDiaChi.Text = diachitimthay;
                    }
                }
            }
        }
        private string Tachtuviettat(string chuoi)
        {
            string[] tu = chuoi.Split(' ');
            string Tuviettat = "";
            foreach (var t in tu)
            {
                if (!string.IsNullOrEmpty(t))
                {
                    Tuviettat += t[0];
                }
            }
            return Tuviettat;
        }

        private void cbMaSV_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                switch (droppDown)
                {
                    case 0:
                        cbMaSV.DroppedDown = false;
                        droppDown = 1;
                        break;
                    case 1:
                        cbMaSV.DroppedDown = true;
                        droppDown = 0;
                        break;
                            
                    default:
                        break;
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cbMaLop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (droppDown)
                {
                    case 0:
                        cbMaLop.DroppedDown = false;
                        droppDown = 1;
                        break;
                    case 1:
                        cbMaLop.DroppedDown = true;
                        droppDown = 0;
                        break;

                    default:
                        break;
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cbMaGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (droppDown)
                {
                    case 0:
                        cbMaGV.DroppedDown = false;
                        droppDown = 1;
                        break;
                    case 1:
                        cbMaGV.DroppedDown = true;
                        droppDown = 0;
                        break;

                    default:
                        break;
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cbGT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (droppDown)
                {
                    case 0:
                        cbGT.DroppedDown = false;
                        droppDown = 1;
                        break;
                    case 1:
                        cbGT.DroppedDown = true;
                        droppDown = 0;
                        break;

                    default:
                        break;
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private bool chondc = false;
        private void cbDiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            
                if (e.KeyCode == Keys.Enter)
                {
                    switch (droppDown)
                    {
                        case 0:
                            cbDiaChi.DroppedDown = false;
                            droppDown = 1;
                            break;
                        case 1:
                            cbDiaChi.DroppedDown = true;
                            droppDown = 0;
                            break;

                        default:
                            break;
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                chondc = true;
                }
            
            if(chondc == true && e.KeyCode == Keys.Enter && cbDiaChi.SelectedIndex != -1)
            {
                btnLuu.PerformClick();
                txtID.Text = "";
                cbMaSV.Text = "";
                cbMaLop.Text = "";
                cbMaGV.Text = "";
                txtTenSV.Text = "";
                txtNamSinh.Text = "";
                cbGT.Text = "";
                cbDiaChi.Text = "";
                cbMaSV.Focus();
            }
        }

        private void btnThem_KeyDown(object sender, KeyEventArgs e)
        {
            btnThem.PerformClick();
        }

        private void txtTimDc_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnTimdc.PerformClick();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dataGridView1.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.Cell && hit.ColumnIndex >= 0 && hit.RowIndex >= 0)
            {
                DataGridViewCell cell = dataGridView1.Rows[hit.RowIndex].Cells[hit.ColumnIndex];
                if (cell is DataGridViewCheckBoxCell checkBoxCell)
                {
                    checkBoxCell.Value = !Convert.ToBoolean(checkBoxCell.Value);
                }
            }
        }
    }

}
