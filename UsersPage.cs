using System.Data;
using System.Drawing.Drawing2D;
using System.Text;

// Giao diện: sửa bằng Designer (UsersPage.Designer.cs). File này chỉ chứa xử lý.
partial class UsersPage : UserControl
{
    public UsersPage() { InitializeComponent(); }

    int maU = 0;
    public event Action GoHome;
    public void Open() => LoadUsers();

    void btnTao_Click(object sender, EventArgs e) => CreateUser();
    void btnCapNhat_Click(object sender, EventArgs e) => UpdateUser();
    void btnKhoa_Click(object sender, EventArgs e) => ToggleUser();
    void btnReset_Click(object sender, EventArgs e) => ResetPw();
    void btnMoi_Click(object sender, EventArgs e) => ClearU();
    void btnBack_Click(object sender, EventArgs e) => GoHome?.Invoke();
    void dgvU_SelectionChanged(object sender, EventArgs e) { if (dgvU.CurrentRow == null || dgvU.CurrentRow.DataBoundItem == null) return; var r = ((DataRowView)dgvU.CurrentRow.DataBoundItem).Row; maU = (int)r["MaND"]; txtUser.Text = r["Tài khoản"].ToString(); txtUser.ReadOnly = true; txtHoTen.Text = r["Họ tên"].ToString(); cboRole.SelectedValue = r["MaVaiTro"]; txtPw.Clear(); }

    void LoadUsers()
    {
        cboRole.DataSource = Db.Query("SELECT MaVaiTro, TenVaiTro FROM VaiTro"); cboRole.DisplayMember = "TenVaiTro"; cboRole.ValueMember = "MaVaiTro";
        dgvU.DataSource = Db.Query(@"SELECT n.MaND, n.MaVaiTro, n.TenDangNhap [Tài khoản], n.HoTen [Họ tên], v.TenVaiTro [Vai trò],
            CASE n.TrangThai WHEN 1 THEN N'Hoạt động' ELSE N'Đã khóa' END [Trạng thái],
            CASE n.BatDoiMatKhau WHEN 1 THEN N'Chờ đổi mật khẩu' ELSE N'' END [Mật khẩu]
            FROM NguoiDung n JOIN VaiTro v ON n.MaVaiTro=v.MaVaiTro ORDER BY n.MaND");
        dgvU.Columns["MaND"].Visible = false; dgvU.Columns["MaVaiTro"].Visible = false;
    }

    void ClearU() { maU = 0; txtUser.Clear(); txtUser.ReadOnly = false; txtHoTen.Clear(); txtPw.Clear(); }

    bool LastAdmin(int id)
    {
        string q = "SELECT COUNT(*) FROM NguoiDung n JOIN VaiTro v ON n.MaVaiTro=v.MaVaiTro WHERE v.TenVaiTro='Admin' AND n.TrangThai=1 AND ";
        int other = (int)Db.Query(q + "n.MaND<>@i", ("@i", id)).Rows[0][0], me = (int)Db.Query(q + "n.MaND=@i", ("@i", id)).Rows[0][0];
        return me == 1 && other == 0;
    }

    bool AdminOnly() { if (Session.IsAdmin) return true; MessageBox.Show("Chỉ quản trị viên được thực hiện thao tác này."); return false; }

    void CreateUser()
    {
        if (!AdminOnly()) return;
        if (maU != 0) { MessageBox.Show("Bấm \"Nhập mới\" trước khi tạo tài khoản mới."); return; }
        string u = txtUser.Text.Trim();
        if (u == "" || u.Contains(' ')) { MessageBox.Show("Tên tài khoản không được trống hoặc chứa khoảng trắng."); return; }
        if (txtPw.Text.Length < 6) { MessageBox.Show("Mật khẩu tạm phải từ 6 ký tự."); return; }
        var salt = Security.NewSalt();
        try
        {
            Db.Exec("INSERT NguoiDung(TenDangNhap,MatKhauHash,Salt,HoTen,MaVaiTro,BatDoiMatKhau) VALUES(@u,@h,@s,@n,@v,1)",
                ("@u", u), ("@h", Security.Hash(txtPw.Text, salt)), ("@s", salt), ("@n", txtHoTen.Text.Trim()), ("@v", cboRole.SelectedValue));
            Db.Log("Tạo tài khoản", u); ClearU(); LoadUsers();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message.Contains("UNIQUE") || ex.Message.Contains("duplicate") ? "Tài khoản đã tồn tại." : ex.Message); }
    }

    void UpdateUser()
    {
        if (!AdminOnly() || maU == 0) return;
        int cur = (int)Db.Query("SELECT MaVaiTro FROM NguoiDung WHERE MaND=@i", ("@i", maU)).Rows[0][0];
        if ((int)cboRole.SelectedValue != cur && (maU == Session.Id || LastAdmin(maU)))
        { MessageBox.Show("Không thể đổi vai trò của chính mình hoặc của Admin cuối cùng."); return; }
        Db.Exec("UPDATE NguoiDung SET HoTen=@n, MaVaiTro=@v WHERE MaND=@i", ("@n", txtHoTen.Text.Trim()), ("@v", cboRole.SelectedValue), ("@i", maU));
        Db.Log("Cập nhật tài khoản", txtUser.Text); LoadUsers();
    }

    void ToggleUser()
    {
        if (!AdminOnly() || maU == 0) return;
        if (maU == Session.Id) { MessageBox.Show("Không thể tự khóa tài khoản của mình."); return; }
        if (LastAdmin(maU)) { MessageBox.Show("Không thể khóa Admin cuối cùng."); return; }
        Db.Exec("UPDATE NguoiDung SET TrangThai=CASE WHEN TrangThai=1 THEN 0 ELSE 1 END, SoLanSai=0, KhoaDen=NULL WHERE MaND=@i", ("@i", maU));
        Db.Log("Khóa/Mở khóa tài khoản", txtUser.Text); LoadUsers();
    }

    void ResetPw()
    {
        if (!AdminOnly() || maU == 0) return;
        if (txtPw.Text.Length < 6) { MessageBox.Show("Nhập mật khẩu tạm mới (từ 6 ký tự) vào ô Mật khẩu."); return; }
        var salt = Security.NewSalt();
        Db.Exec("UPDATE NguoiDung SET MatKhauHash=@h, Salt=@s, BatDoiMatKhau=1, SoLanSai=0, KhoaDen=NULL WHERE MaND=@i",
            ("@h", Security.Hash(txtPw.Text, salt)), ("@s", salt), ("@i", maU));
        Db.Log("Reset mật khẩu", txtUser.Text); txtPw.Clear(); LoadUsers(); MessageBox.Show("Đã reset. Người dùng sẽ phải đổi mật khẩu khi đăng nhập.");
    }
}
