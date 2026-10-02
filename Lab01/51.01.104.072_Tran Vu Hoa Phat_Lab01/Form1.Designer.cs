namespace _51._01._104._072_Tran_Vu_Hoa_Phat_Lab01
{
    partial class Form1 : Form
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
            lblTitle = new Label();
            lblHoten = new Label();
            lblNamSinh = new Label();
            lblEmail = new Label();
            txtHoTen = new TextBox();
            txtNamSinh = new TextBox();
            txtEmail = new TextBox();
            grbGioiTinh = new GroupBox();
            radNu = new RadioButton();
            radNam = new RadioButton();
            lblKhoa = new Label();
            cboKhoa = new ComboBox();
            btnHienThi = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            grbKetQua = new GroupBox();
            txtKetQua = new TextBox();
            grbGioiTinh.SuspendLayout();
            grbKetQua.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(245, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = RightToLeft.No;
            lblTitle.Size = new Size(303, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THÔNG TIN CÁ NHÂN SINH VIÊN";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblHoten
            // 
            lblHoten.AutoSize = true;
            lblHoten.Location = new Point(131, 95);
            lblHoten.Name = "lblHoten";
            lblHoten.Size = new Size(72, 19);
            lblHoten.TabIndex = 1;
            lblHoten.Text = "Họ và tên:";
            // 
            // lblNamSinh
            // 
            lblNamSinh.AutoSize = true;
            lblNamSinh.Location = new Point(131, 126);
            lblNamSinh.Name = "lblNamSinh";
            lblNamSinh.Size = new Size(70, 19);
            lblNamSinh.TabIndex = 2;
            lblNamSinh.Text = "Năm sinh:";
            lblNamSinh.Click += lblNamSinh_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(131, 157);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 19);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            lblEmail.Click += label4_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(228, 92);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(354, 25);
            txtHoTen.TabIndex = 4;
            // 
            // txtNamSinh
            // 
            txtNamSinh.Location = new Point(228, 123);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(354, 25);
            txtNamSinh.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(228, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(354, 25);
            txtEmail.TabIndex = 6;
            // 
            // grbGioiTinh
            // 
            grbGioiTinh.Controls.Add(radNu);
            grbGioiTinh.Controls.Add(radNam);
            grbGioiTinh.Location = new Point(131, 206);
            grbGioiTinh.Name = "grbGioiTinh";
            grbGioiTinh.Size = new Size(451, 58);
            grbGioiTinh.TabIndex = 7;
            grbGioiTinh.TabStop = false;
            grbGioiTinh.Text = "Giới tính";
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(268, 24);
            radNu.Name = "radNu";
            radNu.Size = new Size(45, 23);
            radNu.TabIndex = 8;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(61, 24);
            radNam.Name = "radNam";
            radNam.Size = new Size(56, 23);
            radNam.TabIndex = 0;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            radNam.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Location = new Point(131, 294);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(43, 19);
            lblKhoa.TabIndex = 8;
            lblKhoa.Text = "Khoa:";
            // 
            // cboKhoa
            // 
            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(228, 293);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(354, 25);
            cboKhoa.TabIndex = 9;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(647, 91);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(75, 23);
            btnHienThi.TabIndex = 11;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(647, 142);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(647, 194);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // grbKetQua
            // 
            grbKetQua.Controls.Add(txtKetQua);
            grbKetQua.Location = new Point(131, 363);
            grbKetQua.Name = "grbKetQua";
            grbKetQua.Size = new Size(451, 107);
            grbKetQua.TabIndex = 14;
            grbKetQua.TabStop = false;
            grbKetQua.Text = "Kết quả tổng hợp";
            // 
            // txtKetQua
            // 
            txtKetQua.BackColor = Color.White;
            txtKetQua.Location = new Point(6, 24);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.ScrollBars = ScrollBars.Vertical;
            txtKetQua.Size = new Size(439, 77);
            txtKetQua.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(grbKetQua);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnHienThi);
            Controls.Add(cboKhoa);
            Controls.Add(lblKhoa);
            Controls.Add(grbGioiTinh);
            Controls.Add(txtEmail);
            Controls.Add(txtNamSinh);
            Controls.Add(txtHoTen);
            Controls.Add(lblEmail);
            Controls.Add(lblNamSinh);
            Controls.Add(lblHoten);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ứng dụng Thông tin Cá nhân Sinh viên";
            Load += Form1_Load;
            grbGioiTinh.ResumeLayout(false);
            grbGioiTinh.PerformLayout();
            grbKetQua.ResumeLayout(false);
            grbKetQua.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblHoten;
        private Label lblNamSinh;
        private Label lblEmail;
        private TextBox txtHoTen;
        private TextBox txtNamSinh;
        private TextBox txtEmail;
        private GroupBox grbGioiTinh;
        private RadioButton radNam;
        private RadioButton radNu;
        private Label lblKhoa;
        private ComboBox cboKhoa;
        private Button btnHienThi;
        private Button btnXoa;
        private Button btnThoat;
        private GroupBox grbKetQua;
        private TextBox txtKetQua;
    }
}
