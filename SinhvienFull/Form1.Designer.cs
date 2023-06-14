namespace SinhvienFull
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbXa = new System.Windows.Forms.ComboBox();
            this.cbHuyen = new System.Windows.Forms.ComboBox();
            this.cbTinh = new System.Windows.Forms.ComboBox();
            this.tinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nanoThucTapDataSet = new SinhvienFull.NanoThucTapDataSet();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.cbMaGV = new System.Windows.Forms.ComboBox();
            this.cbDiaChi = new System.Windows.Forms.ComboBox();
            this.cbGT = new System.Windows.Forms.ComboBox();
            this.cbMaSV = new System.Windows.Forms.ComboBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tinhTableAdapter = new SinhvienFull.NanoThucTapDataSetTableAdapters.tinhTableAdapter();
            this.ckbAll = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtTimDc = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTimdc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nanoThucTapDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbXa);
            this.groupBox1.Controls.Add(this.cbHuyen);
            this.groupBox1.Controls.Add(this.cbTinh);
            this.groupBox1.Controls.Add(this.cbMaLop);
            this.groupBox1.Controls.Add(this.cbMaGV);
            this.groupBox1.Controls.Add(this.cbDiaChi);
            this.groupBox1.Controls.Add(this.cbGT);
            this.groupBox1.Controls.Add(this.cbMaSV);
            this.groupBox1.Controls.Add(this.txtTenSV);
            this.groupBox1.Controls.Add(this.txtNamSinh);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // cbXa
            // 
            this.cbXa.FormattingEnabled = true;
            this.cbXa.Location = new System.Drawing.Point(614, 256);
            this.cbXa.Name = "cbXa";
            this.cbXa.Size = new System.Drawing.Size(263, 28);
            this.cbXa.TabIndex = 10;
            this.cbXa.TextChanged += new System.EventHandler(this.cbXa_TextChanged);
            // 
            // cbHuyen
            // 
            this.cbHuyen.FormattingEnabled = true;
            this.cbHuyen.Location = new System.Drawing.Point(614, 217);
            this.cbHuyen.Name = "cbHuyen";
            this.cbHuyen.Size = new System.Drawing.Size(263, 28);
            this.cbHuyen.TabIndex = 9;
            this.cbHuyen.SelectedIndexChanged += new System.EventHandler(this.cbHuyen_SelectedIndexChanged);
            this.cbHuyen.TextChanged += new System.EventHandler(this.cbHuyen_TextChanged);
            // 
            // cbTinh
            // 
            this.cbTinh.DataSource = this.tinhBindingSource;
            this.cbTinh.DisplayMember = "TenTT";
            this.cbTinh.FormattingEnabled = true;
            this.cbTinh.Location = new System.Drawing.Point(614, 178);
            this.cbTinh.Name = "cbTinh";
            this.cbTinh.Size = new System.Drawing.Size(263, 28);
            this.cbTinh.TabIndex = 8;
            this.cbTinh.SelectedIndexChanged += new System.EventHandler(this.cbTinh_SelectedIndexChanged);
            this.cbTinh.TextChanged += new System.EventHandler(this.cbTinh_TextChanged);
            // 
            // tinhBindingSource
            // 
            this.tinhBindingSource.DataMember = "tinh";
            this.tinhBindingSource.DataSource = this.nanoThucTapDataSet;
            // 
            // nanoThucTapDataSet
            // 
            this.nanoThucTapDataSet.DataSetName = "NanoThucTapDataSet";
            this.nanoThucTapDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbMaLop
            // 
            this.cbMaLop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMaLop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Items.AddRange(new object[] {
            "L01",
            "L02",
            "L03",
            "L04",
            "L05"});
            this.cbMaLop.Location = new System.Drawing.Point(114, 132);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(263, 28);
            this.cbMaLop.TabIndex = 2;
            this.cbMaLop.TextChanged += new System.EventHandler(this.cbMaLop_TextChanged);
            this.cbMaLop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbMaLop_KeyDown);
            // 
            // cbMaGV
            // 
            this.cbMaGV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbMaGV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMaGV.FormattingEnabled = true;
            this.cbMaGV.Items.AddRange(new object[] {
            "GV01",
            "GV02",
            "GV03",
            "GV04",
            "GV05"});
            this.cbMaGV.Location = new System.Drawing.Point(114, 181);
            this.cbMaGV.Name = "cbMaGV";
            this.cbMaGV.Size = new System.Drawing.Size(263, 28);
            this.cbMaGV.TabIndex = 3;
            this.cbMaGV.TextChanged += new System.EventHandler(this.cbMaGV_TextChanged);
            this.cbMaGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbMaGV_KeyDown);
            // 
            // cbDiaChi
            // 
            this.cbDiaChi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDiaChi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDiaChi.FormattingEnabled = true;
            this.cbDiaChi.Location = new System.Drawing.Point(614, 135);
            this.cbDiaChi.Name = "cbDiaChi";
            this.cbDiaChi.Size = new System.Drawing.Size(263, 28);
            this.cbDiaChi.TabIndex = 7;
            this.cbDiaChi.SelectedIndexChanged += new System.EventHandler(this.cbDiaChi_SelectedIndexChanged);
            this.cbDiaChi.TextChanged += new System.EventHandler(this.cbDiaChi_TextChanged);
            this.cbDiaChi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbDiaChi_KeyDown);
            // 
            // cbGT
            // 
            this.cbGT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGT.FormattingEnabled = true;
            this.cbGT.Items.AddRange(new object[] {
            "Nam",
            "Nu",
            "Orther"});
            this.cbGT.Location = new System.Drawing.Point(614, 92);
            this.cbGT.Name = "cbGT";
            this.cbGT.Size = new System.Drawing.Size(263, 28);
            this.cbGT.TabIndex = 6;
            this.cbGT.TextChanged += new System.EventHandler(this.cbGT_TextChanged);
            this.cbGT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbGT_KeyDown);
            // 
            // cbMaSV
            // 
            this.cbMaSV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMaSV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMaSV.FormattingEnabled = true;
            this.cbMaSV.Items.AddRange(new object[] {
            "Sv01",
            "Sv02",
            "Sv03",
            "Sv04",
            "Sv05"});
            this.cbMaSV.Location = new System.Drawing.Point(114, 79);
            this.cbMaSV.Name = "cbMaSV";
            this.cbMaSV.Size = new System.Drawing.Size(263, 28);
            this.cbMaSV.TabIndex = 1;
            this.cbMaSV.TextChanged += new System.EventHandler(this.cbMaSV_TextChanged_1);
            this.cbMaSV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbMaSV_KeyDown);
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(114, 230);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(263, 28);
            this.txtTenSV.TabIndex = 4;
            this.txtTenSV.TextChanged += new System.EventHandler(this.txtTenSV_TextChanged);
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Location = new System.Drawing.Point(614, 40);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(263, 28);
            this.txtNamSinh.TabIndex = 5;
            this.txtNamSinh.TextChanged += new System.EventHandler(this.txtNamSinh_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(114, 43);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(263, 28);
            this.txtID.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã GV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SV";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(471, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Xã";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(471, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Huyện";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(471, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tỉnh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(471, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Năm Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(975, 243);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dataGridView1.Location = new System.Drawing.Point(7, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(969, 195);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 6;
            this.Select.Name = "Select";
            this.Select.Width = 80;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(19, 320);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 36);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnThem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnThem_KeyDown);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(113, 320);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 36);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(207, 320);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 36);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(301, 320);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 36);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(395, 320);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 36);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tinhTableAdapter
            // 
            this.tinhTableAdapter.ClearBeforeFill = true;
            // 
            // ckbAll
            // 
            this.ckbAll.AutoSize = true;
            this.ckbAll.Location = new System.Drawing.Point(31, 649);
            this.ckbAll.Name = "ckbAll";
            this.ckbAll.Size = new System.Drawing.Size(114, 24);
            this.ckbAll.TabIndex = 16;
            this.ckbAll.Text = "Chọn tất cả";
            this.ckbAll.UseVisualStyleBackColor = true;
            this.ckbAll.CheckedChanged += new System.EventHandler(this.ckbAll_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(507, 325);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 28);
            this.txtSearch.TabIndex = 17;
            // 
            // txtTimDc
            // 
            this.txtTimDc.Location = new System.Drawing.Point(507, 366);
            this.txtTimDc.Name = "txtTimDc";
            this.txtTimDc.Size = new System.Drawing.Size(169, 28);
            this.txtTimDc.TabIndex = 19;
            this.txtTimDc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimDc_KeyDown);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(700, 328);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(86, 28);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTimdc
            // 
            this.btnTimdc.Location = new System.Drawing.Point(700, 366);
            this.btnTimdc.Name = "btnTimdc";
            this.btnTimdc.Size = new System.Drawing.Size(124, 28);
            this.btnTimdc.TabIndex = 20;
            this.btnTimdc.Text = "Search Địa chỉ";
            this.btnTimdc.UseVisualStyleBackColor = true;
            this.btnTimdc.Click += new System.EventHandler(this.btnTimdc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 700);
            this.Controls.Add(this.btnTimdc);
            this.Controls.Add(this.txtTimDc);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.ckbAll);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nanoThucTapDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaLop;
        private System.Windows.Forms.ComboBox cbMaGV;
        private System.Windows.Forms.ComboBox cbDiaChi;
        private System.Windows.Forms.ComboBox cbGT;
        private System.Windows.Forms.ComboBox cbMaSV;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbXa;
        private System.Windows.Forms.ComboBox cbHuyen;
        private System.Windows.Forms.ComboBox cbTinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private NanoThucTapDataSet nanoThucTapDataSet;
        private System.Windows.Forms.BindingSource tinhBindingSource;
        private NanoThucTapDataSetTableAdapters.tinhTableAdapter tinhTableAdapter;
        private System.Windows.Forms.CheckBox ckbAll;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.Button btnTimdc;
        private System.Windows.Forms.TextBox txtTimDc;
        private System.Windows.Forms.Button btnTimKiem;
    }
}

