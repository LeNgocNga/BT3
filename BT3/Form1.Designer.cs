namespace BT3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ThongTinSP = new System.Windows.Forms.GroupBox();
            this.Xoa = new System.Windows.Forms.Button();
            this.Luu = new System.Windows.Forms.Button();
            this.NgayHetHan = new System.Windows.Forms.Label();
            this.XuatXu = new System.Windows.Forms.Label();
            this.Gia = new System.Windows.Forms.Label();
            this.SL = new System.Windows.Forms.Label();
            this.TenSP = new System.Windows.Forms.Label();
            this.MaSp = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TimKiem = new System.Windows.Forms.GroupBox();
            this.ĐG1 = new System.Windows.Forms.TextBox();
            this.ĐG2 = new System.Windows.Forms.TextBox();
            this.SPCN = new System.Windows.Forms.Button();
            this.TimKiemTheoDonGia = new System.Windows.Forms.Button();
            this.SPQH = new System.Windows.Forms.Button();
            this.SPNB = new System.Windows.Forms.Button();
            this.ListTimKiem = new System.Windows.Forms.ListView();
            this.Ma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dgia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.XXu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ngay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DS = new System.Windows.Forms.GroupBox();
            this.DSSP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NoiXX = new System.Windows.Forms.TextBox();
            this.XoaSPQH = new System.Windows.Forms.Button();
            this.XoaTB = new System.Windows.Forms.Button();
            this.KTSPQH = new System.Windows.Forms.Button();
            this.XoaXX = new System.Windows.Forms.Button();
            this.ThongTinSP.SuspendLayout();
            this.TimKiem.SuspendLayout();
            this.DS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 22);
            this.textBox1.TabIndex = 0;
            // 
            // ThongTinSP
            // 
            this.ThongTinSP.Controls.Add(this.Xoa);
            this.ThongTinSP.Controls.Add(this.Luu);
            this.ThongTinSP.Controls.Add(this.NgayHetHan);
            this.ThongTinSP.Controls.Add(this.XuatXu);
            this.ThongTinSP.Controls.Add(this.Gia);
            this.ThongTinSP.Controls.Add(this.SL);
            this.ThongTinSP.Controls.Add(this.TenSP);
            this.ThongTinSP.Controls.Add(this.MaSp);
            this.ThongTinSP.Controls.Add(this.dateTimePicker1);
            this.ThongTinSP.Controls.Add(this.textBox5);
            this.ThongTinSP.Controls.Add(this.textBox4);
            this.ThongTinSP.Controls.Add(this.textBox3);
            this.ThongTinSP.Controls.Add(this.textBox2);
            this.ThongTinSP.Controls.Add(this.textBox1);
            this.ThongTinSP.Location = new System.Drawing.Point(12, 21);
            this.ThongTinSP.Name = "ThongTinSP";
            this.ThongTinSP.Size = new System.Drawing.Size(417, 271);
            this.ThongTinSP.TabIndex = 1;
            this.ThongTinSP.TabStop = false;
            this.ThongTinSP.Text = "Nhập thông tin sản phẩm";
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(260, 218);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(96, 31);
            this.Xoa.TabIndex = 13;
            this.Xoa.Text = "Xóa SP";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Luu
            // 
            this.Luu.Location = new System.Drawing.Point(142, 218);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(96, 31);
            this.Luu.TabIndex = 12;
            this.Luu.Text = "Lưu SP";
            this.Luu.UseVisualStyleBackColor = true;
            this.Luu.Click += new System.EventHandler(this.Luu_Click);
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.AutoSize = true;
            this.NgayHetHan.Location = new System.Drawing.Point(24, 182);
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.Size = new System.Drawing.Size(86, 16);
            this.NgayHetHan.TabIndex = 11;
            this.NgayHetHan.Text = "Ngày hết hạn";
            // 
            // XuatXu
            // 
            this.XuatXu.AutoSize = true;
            this.XuatXu.Location = new System.Drawing.Point(24, 152);
            this.XuatXu.Name = "XuatXu";
            this.XuatXu.Size = new System.Drawing.Size(51, 16);
            this.XuatXu.TabIndex = 10;
            this.XuatXu.Text = "Xuất Xứ";
            // 
            // Gia
            // 
            this.Gia.AutoSize = true;
            this.Gia.Location = new System.Drawing.Point(24, 124);
            this.Gia.Name = "Gia";
            this.Gia.Size = new System.Drawing.Size(53, 16);
            this.Gia.TabIndex = 9;
            this.Gia.Text = "Đơn giá";
            // 
            // SL
            // 
            this.SL.AutoSize = true;
            this.SL.Location = new System.Drawing.Point(24, 99);
            this.SL.Name = "SL";
            this.SL.Size = new System.Drawing.Size(60, 16);
            this.SL.TabIndex = 8;
            this.SL.Text = "Số lượng";
            // 
            // TenSP
            // 
            this.TenSP.AutoSize = true;
            this.TenSP.Location = new System.Drawing.Point(24, 71);
            this.TenSP.Name = "TenSP";
            this.TenSP.Size = new System.Drawing.Size(52, 16);
            this.TenSP.TabIndex = 7;
            this.TenSP.Text = "Tên SP";
            // 
            // MaSp
            // 
            this.MaSp.AutoSize = true;
            this.MaSp.Location = new System.Drawing.Point(24, 40);
            this.MaSp.Name = "MaSp";
            this.MaSp.Size = new System.Drawing.Size(47, 16);
            this.MaSp.TabIndex = 6;
            this.MaSp.Text = "Mã SP";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 177);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(123, 149);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(245, 22);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(123, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(245, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(245, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 22);
            this.textBox2.TabIndex = 1;
            // 
            // TimKiem
            // 
            this.TimKiem.Controls.Add(this.ĐG1);
            this.TimKiem.Controls.Add(this.ĐG2);
            this.TimKiem.Controls.Add(this.SPCN);
            this.TimKiem.Controls.Add(this.TimKiemTheoDonGia);
            this.TimKiem.Controls.Add(this.SPQH);
            this.TimKiem.Controls.Add(this.SPNB);
            this.TimKiem.Controls.Add(this.ListTimKiem);
            this.TimKiem.Location = new System.Drawing.Point(435, 21);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(800, 271);
            this.TimKiem.TabIndex = 2;
            this.TimKiem.TabStop = false;
            this.TimKiem.Text = "Chọn chức năng tìm kiếm";
            // 
            // ĐG1
            // 
            this.ĐG1.Location = new System.Drawing.Point(527, 43);
            this.ĐG1.Name = "ĐG1";
            this.ĐG1.Size = new System.Drawing.Size(93, 22);
            this.ĐG1.TabIndex = 18;
            // 
            // ĐG2
            // 
            this.ĐG2.Location = new System.Drawing.Point(661, 43);
            this.ĐG2.Name = "ĐG2";
            this.ĐG2.Size = new System.Drawing.Size(93, 22);
            this.ĐG2.TabIndex = 17;
            // 
            // SPCN
            // 
            this.SPCN.Location = new System.Drawing.Point(26, 21);
            this.SPCN.Name = "SPCN";
            this.SPCN.Size = new System.Drawing.Size(96, 59);
            this.SPCN.TabIndex = 16;
            this.SPCN.Text = "1 SP có ĐG cao nhất";
            this.SPCN.UseVisualStyleBackColor = true;
            this.SPCN.Click += new System.EventHandler(this.SPCN_Click);
            // 
            // TimKiemTheoDonGia
            // 
            this.TimKiemTheoDonGia.Location = new System.Drawing.Point(398, 21);
            this.TimKiemTheoDonGia.Name = "TimKiemTheoDonGia";
            this.TimKiemTheoDonGia.Size = new System.Drawing.Size(96, 59);
            this.TimKiemTheoDonGia.TabIndex = 15;
            this.TimKiemTheoDonGia.Text = "Xuất các SP có ĐG [a..b]:";
            this.TimKiemTheoDonGia.UseVisualStyleBackColor = true;
            this.TimKiemTheoDonGia.Click += new System.EventHandler(this.TimKiemTheoDonGia_Click);
            // 
            // SPQH
            // 
            this.SPQH.Location = new System.Drawing.Point(275, 21);
            this.SPQH.Name = "SPQH";
            this.SPQH.Size = new System.Drawing.Size(96, 59);
            this.SPQH.TabIndex = 14;
            this.SPQH.Text = "Xuất toàn bộ SP quá hạn";
            this.SPQH.UseVisualStyleBackColor = true;
            this.SPQH.Click += new System.EventHandler(this.SPQH_Click);
            // 
            // SPNB
            // 
            this.SPNB.Location = new System.Drawing.Point(146, 21);
            this.SPNB.Name = "SPNB";
            this.SPNB.Size = new System.Drawing.Size(96, 59);
            this.SPNB.TabIndex = 13;
            this.SPNB.Text = "1 SP từ NB";
            this.SPNB.UseVisualStyleBackColor = true;
            this.SPNB.Click += new System.EventHandler(this.SPNB_Click);
            // 
            // ListTimKiem
            // 
            this.ListTimKiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ma,
            this.Ten,
            this.SLuong,
            this.Dgia,
            this.XXu,
            this.Ngay});
            this.ListTimKiem.HideSelection = false;
            this.ListTimKiem.Location = new System.Drawing.Point(6, 86);
            this.ListTimKiem.Name = "ListTimKiem";
            this.ListTimKiem.Size = new System.Drawing.Size(788, 179);
            this.ListTimKiem.TabIndex = 0;
            this.ListTimKiem.UseCompatibleStateImageBehavior = false;
            this.ListTimKiem.View = System.Windows.Forms.View.Details;
            // 
            // Ma
            // 
            this.Ma.Text = "Mã SP";
            this.Ma.Width = 57;
            // 
            // Ten
            // 
            this.Ten.Text = "Tên SP";
            this.Ten.Width = 98;
            // 
            // SLuong
            // 
            this.SLuong.Text = "Số lượng";
            this.SLuong.Width = 74;
            // 
            // Dgia
            // 
            this.Dgia.Text = "Đơn giá";
            this.Dgia.Width = 91;
            // 
            // XXu
            // 
            this.XXu.Text = "Xuất Xứ";
            this.XXu.Width = 87;
            // 
            // Ngay
            // 
            this.Ngay.Text = "Ngày hết hạn";
            this.Ngay.Width = 95;
            // 
            // DS
            // 
            this.DS.Controls.Add(this.DSSP);
            this.DS.Location = new System.Drawing.Point(12, 298);
            this.DS.Name = "DS";
            this.DS.Size = new System.Drawing.Size(800, 331);
            this.DS.TabIndex = 3;
            this.DS.TabStop = false;
            this.DS.Text = "Danh sách sản phẩm sau khi nhập";
            // 
            // DSSP
            // 
            this.DSSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.DSSP.FullRowSelect = true;
            this.DSSP.HideSelection = false;
            this.DSSP.Location = new System.Drawing.Point(6, 21);
            this.DSSP.Name = "DSSP";
            this.DSSP.Size = new System.Drawing.Size(788, 304);
            this.DSSP.TabIndex = 1;
            this.DSSP.UseCompatibleStateImageBehavior = false;
            this.DSSP.View = System.Windows.Forms.View.Details;
            this.DSSP.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.DSSP_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã SP";
            this.columnHeader1.Width = 57;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên SP";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 74;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Xuất Xứ";
            this.columnHeader5.Width = 87;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày hết hạn";
            this.columnHeader6.Width = 95;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NoiXX);
            this.groupBox1.Controls.Add(this.XoaSPQH);
            this.groupBox1.Controls.Add(this.XoaTB);
            this.groupBox1.Controls.Add(this.KTSPQH);
            this.groupBox1.Controls.Add(this.XoaXX);
            this.groupBox1.Location = new System.Drawing.Point(818, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 331);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn thao tác";
            // 
            // NoiXX
            // 
            this.NoiXX.Location = new System.Drawing.Point(258, 90);
            this.NoiXX.Name = "NoiXX";
            this.NoiXX.Size = new System.Drawing.Size(100, 22);
            this.NoiXX.TabIndex = 4;
            // 
            // XoaSPQH
            // 
            this.XoaSPQH.Location = new System.Drawing.Point(226, 233);
            this.XoaSPQH.Name = "XoaSPQH";
            this.XoaSPQH.Size = new System.Drawing.Size(163, 64);
            this.XoaSPQH.TabIndex = 3;
            this.XoaSPQH.Text = "Xóa toàn bộ SP quá hạn";
            this.XoaSPQH.UseVisualStyleBackColor = true;
            this.XoaSPQH.Click += new System.EventHandler(this.XoaSPQH_Click);
            // 
            // XoaTB
            // 
            this.XoaTB.Location = new System.Drawing.Point(39, 233);
            this.XoaTB.Name = "XoaTB";
            this.XoaTB.Size = new System.Drawing.Size(163, 64);
            this.XoaTB.TabIndex = 2;
            this.XoaTB.Text = "Xóa toàn bộ sản phẩm trong kho";
            this.XoaTB.UseVisualStyleBackColor = true;
            this.XoaTB.Click += new System.EventHandler(this.XoaTB_Click);
            // 
            // KTSPQH
            // 
            this.KTSPQH.Location = new System.Drawing.Point(39, 152);
            this.KTSPQH.Name = "KTSPQH";
            this.KTSPQH.Size = new System.Drawing.Size(350, 64);
            this.KTSPQH.TabIndex = 1;
            this.KTSPQH.Text = "Kiểm tra xem kho có SP quá hạn hay không";
            this.KTSPQH.UseVisualStyleBackColor = true;
            this.KTSPQH.Click += new System.EventHandler(this.KTSPQH_Click);
            // 
            // XoaXX
            // 
            this.XoaXX.Location = new System.Drawing.Point(39, 69);
            this.XoaXX.Name = "XoaXX";
            this.XoaXX.Size = new System.Drawing.Size(163, 64);
            this.XoaXX.TabIndex = 0;
            this.XoaXX.Text = "Xóa SP theo xuất xứ bất kỳ: ";
            this.XoaXX.UseVisualStyleBackColor = true;
            this.XoaXX.Click += new System.EventHandler(this.XoaXX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 641);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DS);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.ThongTinSP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ThongTinSP.ResumeLayout(false);
            this.ThongTinSP.PerformLayout();
            this.TimKiem.ResumeLayout(false);
            this.TimKiem.PerformLayout();
            this.DS.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox ThongTinSP;
        private System.Windows.Forms.Label NgayHetHan;
        private System.Windows.Forms.Label XuatXu;
        private System.Windows.Forms.Label Gia;
        private System.Windows.Forms.Label SL;
        private System.Windows.Forms.Label TenSP;
        private System.Windows.Forms.Label MaSp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Luu;
        private System.Windows.Forms.GroupBox TimKiem;
        private System.Windows.Forms.ListView ListTimKiem;
        private System.Windows.Forms.ColumnHeader Ma;
        private System.Windows.Forms.ColumnHeader Ten;
        private System.Windows.Forms.ColumnHeader SLuong;
        private System.Windows.Forms.ColumnHeader Dgia;
        private System.Windows.Forms.ColumnHeader XXu;
        private System.Windows.Forms.ColumnHeader Ngay;
        private System.Windows.Forms.TextBox ĐG1;
        private System.Windows.Forms.TextBox ĐG2;
        private System.Windows.Forms.Button SPCN;
        private System.Windows.Forms.Button TimKiemTheoDonGia;
        private System.Windows.Forms.Button SPQH;
        private System.Windows.Forms.Button SPNB;
        private System.Windows.Forms.GroupBox DS;
        private System.Windows.Forms.ListView DSSP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NoiXX;
        private System.Windows.Forms.Button XoaSPQH;
        private System.Windows.Forms.Button XoaTB;
        private System.Windows.Forms.Button KTSPQH;
        private System.Windows.Forms.Button XoaXX;
    }
}

