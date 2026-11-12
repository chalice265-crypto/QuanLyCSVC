using System.Data;
using System.Drawing.Drawing2D;
using System.Text;

// Giao diện: sửa bằng Designer (ThietBiPage.Designer.cs). File này chỉ chứa xử lý.
partial class ThietBiPage : UserControl
{
    public ThietBiPage() { InitializeComponent(); }

    int maTB = 0;
    public event Action GoHome;
    public void SetSearch(string t) => txtSearch.Text = t;
    public void Open(string filter)
    {
        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = Session.CanEdit;
        LoadCombos(); cboLoc.Text = filter; LoadTB();
    }

    void btnThem_Click(object sender, EventArgs e) => SaveTB(true);
    void btnSua_Click(object sender, EventArgs e) => SaveTB(false);
    void btnXoa_Click(object sender, EventArgs e) => DeleteTB();
    void btnMoi_Click(object sender, EventArgs e) { ClearTB(); cboLoc.SelectedIndex = 0; LoadTB(); }
    void btnLoc_Click(object sender, EventArgs e) => LoadTB();
    void btnBack_Click(object sender, EventArgs e) => GoHome?.Invoke();
    void dgvTB_SelectionChanged(object sender, EventArgs e) => FillTB();

    void LoadCombos()
    {
        cboLoai.DataSource = Db.Query("SELECT MaLoai, TenLoai FROM LoaiThietBi"); cboLoai.DisplayMember = "TenLoai"; cboLoai.ValueMember = "MaLoai";
        cboPhong.DataSource = Db.Query("SELECT MaPhong, TenPhong FROM Phong"); cboPhong.DisplayMember = "TenPhong"; cboPhong.ValueMember = "MaPhong";
    }

    void LoadTB()
    {
        var dt = Db.Query(@"SELECT * FROM vw_ThietBi WHERE (TenTB LIKE @k OR TenPhong LIKE @k OR TenLoai LIKE @k)
            AND (@tt=N'Tất cả' OR TinhTrang=@tt) ORDER BY MaTB", ("@k", "%" + txtSearch.Text.Trim() + "%"), ("@tt", cboLoc.Text));
        dgvTB.DataSource = dt;
        foreach (var c in new[] { "MaLoai", "MaPhong" }) dgvTB.Columns[c].Visible = false;
        lblTong.Text = $"{dt.Rows.Count} dòng | Tổng giá trị: " + dt.AsEnumerable().Sum(r => Convert.ToDecimal(r["GiaTri"]) * Convert.ToInt32(r["SoLuong"])).ToString("N0") + " đ";
    }

    void FillTB()
    {
        if (dgvTB.CurrentRow == null || dgvTB.CurrentRow.DataBoundItem == null) return;
        var r = ((DataRowView)dgvTB.CurrentRow.DataBoundItem).Row;
        maTB = (int)r["MaTB"]; txtTen.Text = r["TenTB"].ToString(); cboLoai.SelectedValue = r["MaLoai"]; cboPhong.SelectedValue = r["MaPhong"];
        nudSL.Value = Convert.ToInt32(r["SoLuong"]); cboTT.Text = r["TinhTrang"].ToString();
        if (r["NgayMua"] != DBNull.Value) dtpNgay.Value = (DateTime)r["NgayMua"];
        txtGia.Text = Convert.ToDecimal(r["GiaTri"]).ToString("0"); txtGhiChu.Text = r["GhiChu"].ToString();
    }

    void ClearTB() { maTB = 0; txtTen.Clear(); txtGia.Clear(); txtGhiChu.Clear(); nudSL.Value = 1; txtSearch.Clear(); }

    void SaveTB(bool add)
    {
        if (!Perm.Can()) return;
        if (string.IsNullOrWhiteSpace(txtTen.Text)) { MessageBox.Show("Nhập tên thiết bị!"); return; }
        if (!add && maTB == 0) { MessageBox.Show("Chọn một dòng để sửa!"); return; }
        if (!decimal.TryParse(txtGia.Text, out var gia)) gia = 0;
        var ps = new (string, object)[] { ("@ten", txtTen.Text.Trim()), ("@loai", cboLoai.SelectedValue), ("@phong", cboPhong.SelectedValue),
            ("@sl", (int)nudSL.Value), ("@tt", cboTT.Text), ("@ngay", dtpNgay.Value.Date), ("@gia", gia), ("@gc", txtGhiChu.Text), ("@id", maTB) };
        try
        {
            Db.Exec(add ? "INSERT ThietBi(TenTB,MaLoai,MaPhong,SoLuong,TinhTrang,NgayMua,GiaTri,GhiChu) VALUES(@ten,@loai,@phong,@sl,@tt,@ngay,@gia,@gc)"
                        : "UPDATE ThietBi SET TenTB=@ten,MaLoai=@loai,MaPhong=@phong,SoLuong=@sl,TinhTrang=@tt,NgayMua=@ngay,GiaTri=@gia,GhiChu=@gc WHERE MaTB=@id", ps);
            Db.Log(add ? "Thêm thiết bị" : "Sửa thiết bị", txtTen.Text.Trim());
            LoadTB();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

    void DeleteTB()
    {
        if (!Perm.Can()) return;
        if (maTB == 0 || MessageBox.Show("Xóa thiết bị này?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
        try { Db.Exec("DELETE ThietBi WHERE MaTB=@id", ("@id", maTB)); Db.Log("Xóa thiết bị", txtTen.Text.Trim()); ClearTB(); LoadTB(); }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }
}
