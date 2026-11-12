using System.Data;

partial class ThietBiPage
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        dgvTB = new DataGridView();
        pnlTop = new Panel();
        lbl_txtTen = new Label();
        txtTen = new TextBox();
        lbl_cboLoai = new Label();
        cboLoai = new ComboBox();
        lbl_cboPhong = new Label();
        cboPhong = new ComboBox();
        lbl_nudSL = new Label();
        nudSL = new NumericUpDown();
        lbl_cboTT = new Label();
        cboTT = new ComboBox();
        lbl_dtpNgay = new Label();
        dtpNgay = new DateTimePicker();
        lbl_txtGia = new Label();
        txtGia = new TextBox();
        lbl_txtGhiChu = new Label();
        txtGhiChu = new TextBox();
        btnThem = new Button();
        btnSua = new Button();
        btnXoa = new Button();
        btnMoi = new Button();
        cboLoc = new ComboBox();
        txtSearch = new TextBox();
        btnLoc = new Button();
        btnBack = new Button();
        lblTong = new Label();
        SuspendLayout();
        // dgvTB
        dgvTB.Dock = DockStyle.Fill;
        dgvTB.ReadOnly = true;
        dgvTB.AllowUserToAddRows = false;
        dgvTB.RowHeadersVisible = false;
        dgvTB.BackgroundColor = Color.White;
        dgvTB.BorderStyle = BorderStyle.None;
        dgvTB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvTB.SelectionChanged += dgvTB_SelectionChanged;
        // pnlTop
        pnlTop.Dock = DockStyle.Top;
        pnlTop.Height = 190;
        pnlTop.BackColor = Color.White;
        // lbl_txtTen
        lbl_txtTen.AutoSize = true;
        lbl_txtTen.Location = new Point(15, 18);
        lbl_txtTen.Text = "Tên TB";
        // txtTen
        txtTen.Location = new Point(115, 15);
        txtTen.Size = new Size(250, 27);
        // lbl_cboLoai
        lbl_cboLoai.AutoSize = true;
        lbl_cboLoai.Location = new Point(15, 53);
        lbl_cboLoai.Text = "Loại";
        // cboLoai
        cboLoai.Location = new Point(115, 50);
        cboLoai.Size = new Size(180, 27);
        cboLoai.DropDownStyle = ComboBoxStyle.DropDownList;
        // lbl_cboPhong
        lbl_cboPhong.AutoSize = true;
        lbl_cboPhong.Location = new Point(15, 88);
        lbl_cboPhong.Text = "Phòng";
        // cboPhong
        cboPhong.Location = new Point(115, 85);
        cboPhong.Size = new Size(180, 27);
        cboPhong.DropDownStyle = ComboBoxStyle.DropDownList;
        // lbl_nudSL
        lbl_nudSL.AutoSize = true;
        lbl_nudSL.Location = new Point(420, 18);
        lbl_nudSL.Text = "Số lượng";
        // nudSL
        nudSL.Location = new Point(520, 15);
        nudSL.Size = new Size(100, 27);
        nudSL.Maximum = 100000;
        nudSL.Value = 1;
        // lbl_cboTT
        lbl_cboTT.AutoSize = true;
        lbl_cboTT.Location = new Point(420, 53);
        lbl_cboTT.Text = "Tình trạng";
        // cboTT
        cboTT.Location = new Point(520, 50);
        cboTT.Size = new Size(130, 27);
        cboTT.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTT.Items.AddRange(new object[] { "Tốt", "Cần bảo trì", "Hỏng", "Thanh lý" });
        cboTT.SelectedIndex = 0;
        // lbl_dtpNgay
        lbl_dtpNgay.AutoSize = true;
        lbl_dtpNgay.Location = new Point(420, 88);
        lbl_dtpNgay.Text = "Ngày mua";
        // dtpNgay
        dtpNgay.Location = new Point(520, 85);
        dtpNgay.Size = new Size(130, 27);
        dtpNgay.Format = DateTimePickerFormat.Short;
        // lbl_txtGia
        lbl_txtGia.AutoSize = true;
        lbl_txtGia.Location = new Point(730, 18);
        lbl_txtGia.Text = "Giá trị";
        // txtGia
        txtGia.Location = new Point(830, 15);
        txtGia.Size = new Size(150, 27);
        // lbl_txtGhiChu
        lbl_txtGhiChu.AutoSize = true;
        lbl_txtGhiChu.Location = new Point(730, 53);
        lbl_txtGhiChu.Text = "Ghi chú";
        // txtGhiChu
        txtGhiChu.Location = new Point(830, 50);
        txtGhiChu.Size = new Size(250, 27);
        // btnThem
        btnThem.Location = new Point(15, 130);
        btnThem.Size = new Size(90, 30);
        btnThem.Text = "Thêm";
        btnThem.BackColor = Color.FromArgb(33, 150, 243);
        btnThem.ForeColor = Color.White;
        btnThem.FlatStyle = FlatStyle.Flat;
        btnThem.FlatAppearance.BorderSize = 0;
        btnThem.UseVisualStyleBackColor = false;
        btnThem.Click += btnThem_Click;
        // btnSua
        btnSua.Location = new Point(115, 130);
        btnSua.Size = new Size(90, 30);
        btnSua.Text = "Sửa";
        btnSua.BackColor = Color.FromArgb(33, 150, 243);
        btnSua.ForeColor = Color.White;
        btnSua.FlatStyle = FlatStyle.Flat;
        btnSua.FlatAppearance.BorderSize = 0;
        btnSua.UseVisualStyleBackColor = false;
        btnSua.Click += btnSua_Click;
        // btnXoa
        btnXoa.Location = new Point(215, 130);
        btnXoa.Size = new Size(90, 30);
        btnXoa.Text = "Xóa";
        btnXoa.BackColor = Color.FromArgb(33, 150, 243);
        btnXoa.ForeColor = Color.White;
        btnXoa.FlatStyle = FlatStyle.Flat;
        btnXoa.FlatAppearance.BorderSize = 0;
        btnXoa.UseVisualStyleBackColor = false;
        btnXoa.Click += btnXoa_Click;
        // btnMoi
        btnMoi.Location = new Point(315, 130);
        btnMoi.Size = new Size(90, 30);
        btnMoi.Text = "Làm mới";
        btnMoi.BackColor = Color.FromArgb(33, 150, 243);
        btnMoi.ForeColor = Color.White;
        btnMoi.FlatStyle = FlatStyle.Flat;
        btnMoi.FlatAppearance.BorderSize = 0;
        btnMoi.UseVisualStyleBackColor = false;
        btnMoi.Click += btnMoi_Click;
        // cboLoc
        cboLoc.Location = new Point(440, 131);
        cboLoc.Size = new Size(120, 27);
        cboLoc.DropDownStyle = ComboBoxStyle.DropDownList;
        cboLoc.Items.AddRange(new object[] { "Tất cả", "Tốt", "Cần bảo trì", "Hỏng", "Thanh lý" });
        cboLoc.SelectedIndex = 0;
        // txtSearch
        txtSearch.Location = new Point(570, 131);
        txtSearch.Size = new Size(220, 27);
        txtSearch.PlaceholderText = "Tìm tên / phòng / loại...";
        // btnLoc
        btnLoc.Location = new Point(800, 130);
        btnLoc.Size = new Size(90, 30);
        btnLoc.Text = "Lọc";
        btnLoc.BackColor = Color.FromArgb(33, 150, 243);
        btnLoc.ForeColor = Color.White;
        btnLoc.FlatStyle = FlatStyle.Flat;
        btnLoc.FlatAppearance.BorderSize = 0;
        btnLoc.UseVisualStyleBackColor = false;
        btnLoc.Click += btnLoc_Click;
        // btnBack
        btnBack.Location = new Point(900, 130);
        btnBack.Size = new Size(130, 30);
        btnBack.Text = "← Trang chủ";
        btnBack.BackColor = Color.FromArgb(33, 150, 243);
        btnBack.ForeColor = Color.White;
        btnBack.FlatStyle = FlatStyle.Flat;
        btnBack.FlatAppearance.BorderSize = 0;
        btnBack.UseVisualStyleBackColor = false;
        btnBack.Click += btnBack_Click;
        // lblTong
        lblTong.AutoSize = true;
        lblTong.ForeColor = Color.DimGray;
        lblTong.Location = new Point(15, 166);
        Controls.Add(dgvTB);
        Controls.Add(pnlTop);
        pnlTop.Controls.Add(lbl_txtTen);
        pnlTop.Controls.Add(txtTen);
        pnlTop.Controls.Add(lbl_cboLoai);
        pnlTop.Controls.Add(cboLoai);
        pnlTop.Controls.Add(lbl_cboPhong);
        pnlTop.Controls.Add(cboPhong);
        pnlTop.Controls.Add(lbl_nudSL);
        pnlTop.Controls.Add(nudSL);
        pnlTop.Controls.Add(lbl_cboTT);
        pnlTop.Controls.Add(cboTT);
        pnlTop.Controls.Add(lbl_dtpNgay);
        pnlTop.Controls.Add(dtpNgay);
        pnlTop.Controls.Add(lbl_txtGia);
        pnlTop.Controls.Add(txtGia);
        pnlTop.Controls.Add(lbl_txtGhiChu);
        pnlTop.Controls.Add(txtGhiChu);
        pnlTop.Controls.Add(btnThem);
        pnlTop.Controls.Add(btnSua);
        pnlTop.Controls.Add(btnXoa);
        pnlTop.Controls.Add(btnMoi);
        pnlTop.Controls.Add(cboLoc);
        pnlTop.Controls.Add(txtSearch);
        pnlTop.Controls.Add(btnLoc);
        pnlTop.Controls.Add(btnBack);
        pnlTop.Controls.Add(lblTong);
        // ThietBiPage
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(238, 241, 246);
        Font = new Font("Segoe UI", 10F);
        Name = "ThietBiPage";
        Padding = new Padding(16);
        Size = new Size(1100, 600);
        ResumeLayout(false);
    }

    private DataGridView dgvTB;
    private Panel pnlTop;
    private Label lbl_txtTen;
    private TextBox txtTen;
    private Label lbl_cboLoai;
    private ComboBox cboLoai;
    private Label lbl_cboPhong;
    private ComboBox cboPhong;
    private Label lbl_nudSL;
    private NumericUpDown nudSL;
    private Label lbl_cboTT;
    private ComboBox cboTT;
    private Label lbl_dtpNgay;
    private DateTimePicker dtpNgay;
    private Label lbl_txtGia;
    private TextBox txtGia;
    private Label lbl_txtGhiChu;
    private TextBox txtGhiChu;
    private Button btnThem;
    private Button btnSua;
    private Button btnXoa;
    private Button btnMoi;
    private ComboBox cboLoc;
    private TextBox txtSearch;
    private Button btnLoc;
    private Button btnBack;
    private Label lblTong;
}
