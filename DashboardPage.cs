using System.Data;
using System.Drawing.Drawing2D;
using System.Text;

// Giao diện: sửa bằng Designer (DashboardPage.Designer.cs). File này chỉ chứa xử lý.
partial class DashboardPage : UserControl
{
    DataTable dtStat = new();
    Label[] vals;
    public event Action<string> TileClicked;
    public DashboardPage() { InitializeComponent(); vals = new[] { lblSv0, lblSv1, lblSv2, lblSv3 }; }
    public void Open() { pnlT5.Visible = pnlT6.Visible = Session.IsAdmin; LoadDash(); }

    void Tile_Click(object sender, EventArgs e) => TileClicked?.Invoke((string)((Control)sender).Tag);
    void Tile_Enter(object sender, EventArgs e) { var c = (Control)sender; (c as Panel ?? (Panel)c.Parent).BackColor = Color.FromArgb(232, 244, 253); }
    void Tile_Leave(object sender, EventArgs e) { var c = (Control)sender; (c as Panel ?? (Panel)c.Parent).BackColor = Color.White; }

    void LoadDash()
    {
        var a = Db.Query(@"SELECT ISNULL(SUM(SoLuong),0) t,(SELECT COUNT(*) FROM Phong) p,
            ISNULL(SUM(CASE WHEN TinhTrang=N'Cần bảo trì' THEN SoLuong END),0) b,
            ISNULL(SUM(CASE WHEN TinhTrang=N'Hỏng' THEN SoLuong END),0) h FROM ThietBi").Rows[0];
        for (int i = 0; i < 4; i++) vals[i].Text = a[i].ToString();
        dtStat = Db.Query("SELECT TinhTrang, SUM(SoLuong) n FROM ThietBi GROUP BY TinhTrang");
        pnlChart.Invalidate();
        dgvWarn.DataSource = Db.Query(@"SELECT TOP 20 TenTB [Thiết bị], TenPhong [Phòng], TinhTrang [Tình trạng]
            FROM vw_ThietBi WHERE TinhTrang IN (N'Cần bảo trì',N'Hỏng')");
    }

    void DrawChart(object s, PaintEventArgs e)
    {
        var g = e.Graphics; g.SmoothingMode = SmoothingMode.AntiAlias;
        double tot = dtStat.AsEnumerable().Sum(r => Convert.ToDouble(r["n"]));
        if (tot == 0) { g.DrawString("Chưa có dữ liệu hiển thị", Font, Brushes.Gray, 20, 20); return; }
        int d = Math.Max(Math.Min(pnlChart.Width / 2, pnlChart.Height) - 40, 60);
        var rc = new Rectangle(30, 20, d, d); float st = -90; int y = 30;
        foreach (DataRow r in dtStat.Rows)
        {
            var col = r["TinhTrang"].ToString() switch { "Tốt" => Color.FromArgb(0, 200, 120), "Cần bảo trì" => Color.FromArgb(255, 160, 0),
                "Hỏng" => Color.FromArgb(235, 70, 70), _ => Color.Gray };
            float sw = (float)(Convert.ToDouble(r["n"]) / tot * 360);
            using (var pen = new Pen(col, 26)) g.DrawArc(pen, rc, st, sw);
            st += sw;
            using (var br = new SolidBrush(col)) g.FillRectangle(br, rc.Right + 35, y, 14, 14);
            g.DrawString($"{r["TinhTrang"]}: {r["n"]}", Font, Brushes.DimGray, rc.Right + 55, y - 3); y += 30;
        }
        g.DrawString(tot.ToString(), new Font("Segoe UI", 18, FontStyle.Bold), Brushes.Black, rc.X + d / 2 - 22, rc.Y + d / 2 - 16);
    }
}
