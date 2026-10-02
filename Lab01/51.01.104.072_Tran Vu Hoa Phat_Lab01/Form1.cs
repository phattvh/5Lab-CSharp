using System;
using System.Text;
using System.Windows.Forms;

namespace _51._01._104._072_Tran_Vu_Hoa_Phat_Lab01 // <-- Đảm bảo dòng này TRÙNG KHỚP với namespace trong Form1.Designer.cs của bạn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhoa.Items.Add("Công nghệ thông tin");
            cboKhoa.Items.Add("Hệ thống thông tin");
            cboKhoa.Items.Add("Khoa học máy tính");
            cboKhoa.Items.Add("Kỹ thuật phần mềm");
            cboKhoa.Items.Add("Kinh tế số");

            cboKhoa.SelectedIndex = 0;
            txtHoTen.Focus();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra Họ tên
            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên sinh viên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            // 2. Kiểm tra Năm sinh
            string strNamSinh = txtNamSinh.Text.Trim();
            if (string.IsNullOrWhiteSpace(strNamSinh))
            {
                MessageBox.Show("Vui lòng nhập năm sinh!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamSinh.Focus();
                return;
            }

            if (!int.TryParse(strNamSinh, out int namSinh))
            {
                MessageBox.Show("Năm sinh phải là số nguyên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamSinh.SelectAll();
                txtNamSinh.Focus();
                return;
            }

            int namHienTai = DateTime.Now.Year;
            if (namSinh < 1900 || namSinh > namHienTai)
            {
                MessageBox.Show($"Năm sinh phải nằm trong khoảng từ 1900 đến {namHienTai}!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamSinh.SelectAll();
                txtNamSinh.Focus();
                return;
            }

            // 3. Kiểm tra Email (Dùng ký tự char '@' và '.' theo gợi ý của trình biên dịch)
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (!email.Contains('@') || !email.Contains('.'))
            {
                MessageBox.Show("Email không đúng định dạng (phải có ký tự '@' và '.')!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.SelectAll();
                txtEmail.Focus();
                return;
            }

            // 4. Kiểm tra Giới tính
            if (!radNam.Checked && !radNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính (Nam hoặc Nữ)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";

            // 5. Kiểm tra Khoa
            if (cboKhoa.SelectedIndex == -1 || cboKhoa.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn Khoa hoặc Lớp!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKhoa.Focus();
                return;
            }
            string khoa = cboKhoa.SelectedItem.ToString() ?? "";

            // 6. Tính toán & Hiển thị kết quả
            int tuoi = namHienTai - namSinh;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("THÔNG TIN SINH VIÊN");
            sb.AppendLine($"Họ tên: {hoTen}");
            sb.AppendLine($"Tuổi: {tuoi}");
            sb.AppendLine($"Email: {email}");
            sb.AppendLine($"Giới tính: {gioiTinh}");
            sb.AppendLine($"Khoa/Lớp: {khoa}");

            txtKetQua.Text = sb.ToString();

            MessageBox.Show("Nhận và tổng hợp thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtNamSinh.Clear();
            txtEmail.Clear();
            txtKetQua.Clear();

            radNam.Checked = false;
            radNu.Checked = false;

            if (cboKhoa.Items.Count > 0)
            {
                cboKhoa.SelectedIndex = 0;
            }

            txtHoTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // =========================================================================
        // CÁC HÀM XỬ LÝ DO NHẤP ĐÚP CHUỘT NHẦM NGOÀI GIAO DIỆN (ĐỂ HẾT BÁO LỖI CS0103)
        // =========================================================================
        private void lblNamSinh_Click(object sender, EventArgs e)
        {
            // Để trống
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Để trống
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Để trống
        }
    }
}