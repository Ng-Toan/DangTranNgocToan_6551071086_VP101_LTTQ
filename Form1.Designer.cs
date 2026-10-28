namespace DangTranNgocToan_6551071086_VP101_LTTQ
{
    partial class From1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            grpbThongTin = new GroupBox();
            txtMaCongViec = new TextBox();
            txtLuong = new TextBox();
            lblLuong = new Label();
            txtTenCongViec = new TextBox();
            lblTenCongViec = new Label();
            lblMaCongViec = new Label();
            lblDanhSach = new Label();
            dgvDanhSach = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            grpbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.Location = new Point(212, 18);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(397, 46);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "DANH MỤC CÔNG VIỆC";
            // 
            // grpbThongTin
            // 
            grpbThongTin.Controls.Add(txtMaCongViec);
            grpbThongTin.Controls.Add(txtLuong);
            grpbThongTin.Controls.Add(lblLuong);
            grpbThongTin.Controls.Add(txtTenCongViec);
            grpbThongTin.Controls.Add(lblTenCongViec);
            grpbThongTin.Controls.Add(lblMaCongViec);
            grpbThongTin.Location = new Point(164, 67);
            grpbThongTin.Name = "grpbThongTin";
            grpbThongTin.Size = new Size(483, 220);
            grpbThongTin.TabIndex = 1;
            grpbThongTin.TabStop = false;
            grpbThongTin.Text = "Thông tin công việc";
            // 
            // txtMaCongViec
            // 
            txtMaCongViec.Location = new Point(242, 42);
            txtMaCongViec.Name = "txtMaCongViec";
            txtMaCongViec.Size = new Size(189, 27);
            txtMaCongViec.TabIndex = 6;
            // 
            // txtLuong
            // 
            txtLuong.Location = new Point(242, 151);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(189, 27);
            txtLuong.TabIndex = 7;
            // 
            // lblLuong
            // 
            lblLuong.AutoSize = true;
            lblLuong.Location = new Point(91, 151);
            lblLuong.Name = "lblLuong";
            lblLuong.Size = new Size(96, 20);
            lblLuong.TabIndex = 4;
            lblLuong.Text = "Lương tháng:";
            // 
            // txtTenCongViec
            // 
            txtTenCongViec.Location = new Point(242, 98);
            txtTenCongViec.Name = "txtTenCongViec";
            txtTenCongViec.Size = new Size(189, 27);
            txtTenCongViec.TabIndex = 5;
            // 
            // lblTenCongViec
            // 
            lblTenCongViec.AutoSize = true;
            lblTenCongViec.Location = new Point(91, 101);
            lblTenCongViec.Name = "lblTenCongViec";
            lblTenCongViec.Size = new Size(102, 20);
            lblTenCongViec.TabIndex = 3;
            lblTenCongViec.Text = "Tên công việc:";
            // 
            // lblMaCongViec
            // 
            lblMaCongViec.AutoSize = true;
            lblMaCongViec.Location = new Point(91, 49);
            lblMaCongViec.Name = "lblMaCongViec";
            lblMaCongViec.Size = new Size(100, 20);
            lblMaCongViec.TabIndex = 2;
            lblMaCongViec.Text = "Mã công việc:";
            // 
            // lblDanhSach
            // 
            lblDanhSach.AutoSize = true;
            lblDanhSach.Location = new Point(164, 302);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Size = new Size(144, 20);
            lblDanhSach.TabIndex = 2;
            lblDanhSach.Text = "Danh sách công việc";
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSach.Location = new Point(164, 325);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.RowHeadersWidth = 51;
            dgvDanhSach.Size = new Size(483, 113);
            dgvDanhSach.TabIndex = 3;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(164, 461);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(76, 43);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(277, 461);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(74, 43);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(502, 461);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 41);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(386, 461);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(77, 43);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // From1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 516);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvDanhSach);
            Controls.Add(lblDanhSach);
            Controls.Add(grpbThongTin);
            Controls.Add(lblTieuDe);
            Name = "From1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lí Danh mục Công việc";
            grpbThongTin.ResumeLayout(false);
            grpbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private GroupBox grpbThongTin;
        private TextBox txtMaCongViec;
        private TextBox txtLuong;
        private Label lblLuong;
        private TextBox txtTenCongViec;
        private Label lblTenCongViec;
        private Label lblMaCongViec;
        private Label lblDanhSach;
        private DataGridView dgvDanhSach;
        private Button btnThem;
        private Button btnSua;
        private Button btnThoat;
        private Button btnXoa;
    }
}
