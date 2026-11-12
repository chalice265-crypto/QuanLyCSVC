using System.Data;
using System.Drawing.Drawing2D;
using System.Text;

// Giao diện: sửa bằng Designer (LogPage.Designer.cs). File này chỉ chứa xử lý.
partial class LogPage : UserControl
{
    public LogPage() { InitializeComponent(); }

    public event Action GoHome;
    public void Open() => LoadLog();

    void btnBack_Click(object sender, EventArgs e) => GoHome?.Invoke();

    void LoadLog() => dgvLog.DataSource = Db.Query(@"SELECT TOP 500 k.ThoiGian [Thời gian], ISNULL(n.TenDangNhap,'?') [Người dùng], k.HanhDong [Hành động], k.DoiTuong [Đối tượng]
        FROM NhatKy k LEFT JOIN NguoiDung n ON k.MaND=n.MaND ORDER BY k.MaNK DESC");
}
