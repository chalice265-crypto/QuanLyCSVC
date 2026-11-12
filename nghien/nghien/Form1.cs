namespace nghien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = dangnhap.Text.Trim();
            string password = pass.Text.Trim();

            // Kiểm tra tài khoản mẫu (Ví dụ: tài khoản là admin, mật khẩu là 123456)
            if (username == "admin" && password == "123456")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đoạn code mở Form chính (nếu có) và ẩn Form đăng nhập:
                // MainForm main = new MainForm();
                // main.Show();
                // this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dangnhap.Clear();
                pass.Focus(); // Đưa con trỏ chuột về ô mật khẩu
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Đóng toàn bộ ứng dụng
        }
    }
}
