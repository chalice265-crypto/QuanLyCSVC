using System.Data;
using System.Drawing.Drawing2D;
using System.Text;

// Giao diện: sửa bằng Designer (PhongPage.Designer.cs). File này chỉ chứa xử lý.
partial class PhongPage : UserControl
{
    public PhongPage() { InitializeComponent(); }

    public event Action GoHome;
    public void Open() { btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = Session.CanEdit; LoadPhong(); }

    void btnThem_Click(object sender, EventArgs e) => SavePhong(true);
    void btnSua_Click(object sender, EventArgs e) => SavePhong(false);
    void btnXoa_Click(object sender, EventArgs e) => DeletePhong();
    void btnBack_Click(object sender, EventArgs e) => GoHome?.Invoke();
    void dgvP_SelectionChanged(object sender, EventArgs e) { if (dgvP.CurrentRow == null || dgvP.CurrentRow.DataBoundItem == null) return; var r = ((DataRowView)dgvP.CurrentRow.DataBoundItem).Row; txtMaP.Text = r["MaPhong"].ToString(); txtTenP.Text = r["TenPhong"].ToString(); txtToa.Text = r["Toa"].ToString(); txtLoaiP.Text = r["LoaiPhong"].ToString(); nudTang.Value = Convert.ToInt32(r["Tang"]); nudSucChua.Value = Convert.ToInt32(r["SucChua"]); }

    void LoadPhong() => dgvP.DataSource = Db.Query("SELECT * FROM Phong ORDER BY MaPhong");

    void SavePhong(bool add)
    {
        if (!Perm.Can()) return;
        if (string.IsNullOrWhiteSpace(txtMaP.Text) || string.IsNullOrWhiteSpace(txtTenP.Text)) { MessageBox.Show("Nhập mã và tên phòng!"); return; }
        var ps = new (string, object)[] { ("@ma", txtMaP.Text.Trim()), ("@ten", txtTenP.Text.Trim()), ("@toa", txtToa.Text),
            ("@tang", (int)nudTang.Value), ("@sc", (int)nudSucChua.Value), ("@lp", txtLoaiP.Text) };
        try
        {
            Db.Exec(add ? "INSERT Phong VALUES(@ma,@ten,@toa,@tang,@sc,@lp)"
                        : "UPDATE Phong SET TenPhong=@ten,Toa=@toa,Tang=@tang,SucChua=@sc,LoaiPhong=@lp WHERE MaPhong=@ma", ps);
            Db.Log(add ? "Thêm phòng" : "Sửa phòng", txtMaP.Text.Trim());
            LoadPhong();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    void DeletePhong()
    {
        if (!Perm.Can()) return;
        if (MessageBox.Show("Xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
        try { Db.Exec("DELETE Phong WHERE MaPhong=@ma", ("@ma", txtMaP.Text)); Db.Log("Xóa phòng", txtMaP.Text); LoadPhong(); }
        catch (Exception ex) { MessageBox.Show("Không xóa được (phòng còn thiết bị?):\n" + ex.Message); }
    }
}
