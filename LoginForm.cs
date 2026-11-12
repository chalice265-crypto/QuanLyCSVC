// Giao diện: sửa bằng Designer (bấm đúp file này hoặc LoginForm.Designer.cs). File này chỉ chứa xử lý.
partial class LoginForm : Form
{
    public LoginForm() { InitializeComponent(); }

    void btnLogin_Click(object sender, EventArgs e) => DoLogin();

    void DoLogin()
    {
        try
        {
            var dt = Db.Query("SELECT n.*, v.TenVaiTro FROM NguoiDung n JOIN VaiTro v ON n.MaVaiTro=v.MaVaiTro WHERE n.TenDangNhap=@u", ("@u", txtU.Text.Trim()));
            if (dt.Rows.Count == 0) { MessageBox.Show("Sai tài khoản hoặc mật khẩu."); return; }
            var r = dt.Rows[0]; int id = (int)r["MaND"];
            if (!(bool)r["TrangThai"]) { MessageBox.Show("Tài khoản đã bị khóa. Vui lòng liên hệ quản trị viên."); return; }
            if (r["KhoaDen"] != DBNull.Value && (DateTime)r["KhoaDen"] > DateTime.Now)
            { MessageBox.Show("Tài khoản tạm khóa do nhập sai nhiều lần. Thử lại sau ít phút."); return; }
            if (!Security.Verify(txtP.Text, (byte[])r["Salt"], (byte[])r["MatKhauHash"]))
            {
                Db.Exec(@"UPDATE NguoiDung SET SoLanSai = CASE WHEN SoLanSai+1>=5 THEN 0 ELSE SoLanSai+1 END,
                          KhoaDen = CASE WHEN SoLanSai+1>=5 THEN DATEADD(MINUTE,5,GETDATE()) ELSE KhoaDen END WHERE MaND=@id", ("@id", id));
                MessageBox.Show("Sai tài khoản hoặc mật khẩu."); return;
            }
            Db.Exec("UPDATE NguoiDung SET SoLanSai=0, KhoaDen=NULL WHERE MaND=@id", ("@id", id));
            Session.Id = id; Session.User = r["TenDangNhap"].ToString(); Session.HoTen = r["HoTen"].ToString(); Session.Role = r["TenVaiTro"].ToString();
            if ((bool)r["BatDoiMatKhau"])
            {
                using var f = new ChangePasswordForm(true);
                if (f.ShowDialog() != DialogResult.OK) { Session.Clear(); return; }
            }
            Db.Log("Đăng nhập", "");
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex) { MessageBox.Show("Lỗi kết nối CSDL:\n" + ex.Message); }
    }
}
