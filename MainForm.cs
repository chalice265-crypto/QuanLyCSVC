using System.Data;
using System.Text;

// Khung chính: giao diện sửa trong MainForm.Designer.cs; mỗi trang là một UserControl riêng (ThietBiPage, PhongPage, UsersPage, LogPage, DashboardPage).
partial class MainForm : Form
{
    public bool LoggedOut;

    public MainForm()
    {
        InitializeComponent();
        lblUser.Text = $"👤 {Session.HoTen} ({Session.Role})";
        new ToolTip().SetToolTip(lblUser, "Bấm để đổi mật khẩu");
        dashPage.TileClicked += OnTile;
        tbPage.GoHome += GoHome; phongPage.GoHome += GoHome; usersPage.GoHome += GoHome; logPage.GoHome += GoHome;
        try { GoHome(); } catch (Exception ex) { MessageBox.Show("Không kết nối được CSDL:\n" + ex.Message); }
    }

    void ShowPage(Control c) { foreach (Control p in pnlHost.Controls) p.Visible = p == c; }
    void GoHome() { ShowPage(dashPage); dashPage.Open(); }
    void ShowTB(string filter) { ShowPage(tbPage); tbPage.Open(filter); }

    void OnTile(string key)
    {
        switch (key)
        {
            case "tb": ShowTB("Tất cả"); break;
            case "bt": ShowTB("Cần bảo trì"); break;
            case "hong": ShowTB("Hỏng"); break;
            case "phong": ShowPage(phongPage); phongPage.Open(); break;
            case "users": ShowPage(usersPage); usersPage.Open(); break;
            case "log": ShowPage(logPage); logPage.Open(); break;
            case "csv": Export(); break;
        }
    }

    void lblHome_Click(object sender, EventArgs e) => GoHome();
    void lblUser_Click(object sender, EventArgs e) { using var f = new ChangePasswordForm(false); f.ShowDialog(); }
    void lblLogout_Click(object sender, EventArgs e) { Db.Log("Đăng xuất", ""); LoggedOut = true; Close(); }
    void txtGlobal_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) { tbPage.SetSearch(txtGlobal.Text); ShowTB("Tất cả"); }
    }

    void Export()
    {
        var dt = Db.Query("SELECT TenTB,TenLoai,TenPhong,SoLuong,TinhTrang,NgayMua,GiaTri,GhiChu FROM vw_ThietBi");
        using var d = new SaveFileDialog { Filter = "CSV|*.csv", FileName = "thietbi.csv" };
        if (d.ShowDialog() != DialogResult.OK) return;
        var sb = new StringBuilder();
        sb.AppendLine(string.Join(",", dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName)));
        foreach (DataRow r in dt.Rows) sb.AppendLine(string.Join(",", r.ItemArray.Select(x => "\"" + x.ToString().Replace("\"", "\"\"") + "\"")));
        File.WriteAllText(d.FileName, sb.ToString(), new UTF8Encoding(true));
        MessageBox.Show("Đã xuất file!");
    }
}
