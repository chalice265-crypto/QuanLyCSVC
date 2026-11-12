using System.Data;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        try { Db.EnsureAdmin(); }
        catch (Exception ex) { MessageBox.Show("Không kết nối được CSDL (đã chạy file .sql chưa?):\n" + ex.Message); return; }
        while (true)
        {
            using (var lg = new LoginForm()) { if (lg.ShowDialog() != DialogResult.OK) return; }
            var mf = new MainForm();
            Application.Run(mf);
            if (!mf.LoggedOut) return;   // đóng cửa sổ = thoát; Đăng xuất = quay lại màn hình đăng nhập
            Session.Clear();
        }
    }
}

static class Session
{
    public static int Id; public static string User = "", HoTen = "", Role = "";
    public static bool IsAdmin => Role == "Admin";
    public static bool CanEdit => Role == "Admin" || Role == "QuanLy";
    public static void Clear() { Id = 0; User = HoTen = Role = ""; }
}

static class Security
{
    public static byte[] NewSalt() => RandomNumberGenerator.GetBytes(16);
    public static byte[] Hash(string pw, byte[] salt) => Rfc2898DeriveBytes.Pbkdf2(pw, salt, 100000, HashAlgorithmName.SHA256, 32);
    public static bool Verify(string pw, byte[] salt, byte[] hash) => CryptographicOperations.FixedTimeEquals(Hash(pw, salt), hash);
}

static class Db
{
    // Đổi Server cho phù hợp máy bạn, vd: .\SQLEXPRESS
    const string Conn = "Server=localhost;Database=QLCSVC;Trusted_Connection=True;TrustServerCertificate=True";

    public static DataTable Query(string sql, params (string, object)[] ps)
    {
        using var cn = new SqlConnection(Conn); using var cmd = new SqlCommand(sql, cn);
        foreach (var (n, v) in ps) cmd.Parameters.AddWithValue(n, v ?? DBNull.Value);
        var dt = new DataTable(); new SqlDataAdapter(cmd).Fill(dt); return dt;
    }

    public static int Exec(string sql, params (string, object)[] ps)
    {
        using var cn = new SqlConnection(Conn); using var cmd = new SqlCommand(sql, cn);
        foreach (var (n, v) in ps) cmd.Parameters.AddWithValue(n, v ?? DBNull.Value);
        cn.Open(); return cmd.ExecuteNonQuery();
    }

    public static void Log(string act, string obj)
    {
        try { Exec("INSERT NhatKy(MaND,HanhDong,DoiTuong) VALUES(@u,@a,@o)", ("@u", Session.Id == 0 ? null : (object)Session.Id), ("@a", act), ("@o", obj)); } catch { }
    }

    // Lần chạy đầu: chưa có tài khoản nào thì tạo admin / admin123 (bắt đổi mật khẩu khi đăng nhập)
    public static void EnsureAdmin()
    {
        if ((int)Query("SELECT COUNT(*) FROM NguoiDung").Rows[0][0] > 0) return;
        var salt = Security.NewSalt();
        Exec(@"INSERT NguoiDung(TenDangNhap,MatKhauHash,Salt,HoTen,MaVaiTro,BatDoiMatKhau)
               SELECT 'admin',@h,@s,N'Quản trị viên',MaVaiTro,1 FROM VaiTro WHERE TenVaiTro='Admin'",
            ("@h", Security.Hash("admin123", salt)), ("@s", salt));
    }
}

static class Perm
{
    public static bool Can()
    {
        if (Session.CanEdit) return true;
        MessageBox.Show("Bạn chỉ có quyền xem, không được thêm/sửa/xóa."); return false;
    }
}
