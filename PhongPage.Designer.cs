using System.Data;

partial class PhongPage
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        dgvP = new DataGridView();
        pnlTop = new Panel();
        lbl_txtMaP = new Label();
        txtMaP = new TextBox();
        lbl_txtTenP = new Label();
        txtTenP = new TextBox();
        lbl_txtToa = new Label();
        txtToa = new TextBox();
        lbl_nudTang = new Label();
        nudTang = new NumericUpDown();
        lbl_nudSucChua = new Label();
        nudSucChua = new NumericUpDown();
        lbl_txtLoaiP = new Label();
        txtLoaiP = new TextBox();
        btnThem = new Button();
        btnSua = new Button();
        btnXoa = new Button();
        btnBack = new Button();
        SuspendLayout();
        // dgvP
        dgvP.Dock = DockStyle.Fill;
        dgvP.ReadOnly = true;
        dgvP.AllowUserToAddRows = false;
        dgvP.RowHeadersVisible = false;
        dgvP.BackgroundColor = Color.White;
        dgvP.BorderStyle = BorderStyle.None;
        dgvP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvP.SelectionChanged += dgvP_SelectionChanged;
        // pnlTop
        pnlTop.Dock = DockStyle.Top;
        pnlTop.Height = 190;
        pnlTop.BackColor = Color.White;
        // lbl_txtMaP
        lbl_txtMaP.AutoSize = true;
        lbl_txtMaP.Location = new Point(15, 18);
        lbl_txtMaP.Text = "Mã phòng";
        // txtMaP
        txtMaP.Location = new Point(115, 15);
        txtMaP.Size = new Size(120, 27);
        // lbl_txtTenP
        lbl_txtTenP.AutoSize = true;
        lbl_txtTenP.Location = new Point(15, 53);
        lbl_txtTenP.Text = "Tên phòng";
        // txtTenP
        txtTenP.Location = new Point(115, 50);
        txtTenP.Size = new Size(250, 27);
        // lbl_txtToa
        lbl_txtToa.AutoSize = true;
        lbl_txtToa.Location = new Point(15, 88);
        lbl_txtToa.Text = "Tòa";
        // txtToa
        txtToa.Location = new Point(115, 85);
        txtToa.Size = new Size(120, 27);
        // lbl_nudTang
        lbl_nudTang.AutoSize = true;
        lbl_nudTang.Location = new Point(420, 18);
        lbl_nudTang.Text = "Tầng";
        // nudTang
        nudTang.Location = new Point(520, 15);
        nudTang.Size = new Size(80, 27);
        nudTang.Minimum = 1;
        nudTang.Maximum = 50;
        nudTang.Value = 1;
        // lbl_nudSucChua
        lbl_nudSucChua.AutoSize = true;
        lbl_nudSucChua.Location = new Point(420, 53);
        lbl_nudSucChua.Text = "Sức chứa";
        // nudSucChua
        nudSucChua.Location = new Point(520, 50);
        nudSucChua.Size = new Size(80, 27);
        nudSucChua.Maximum = 10000;
        // lbl_txtLoaiP
        lbl_txtLoaiP.AutoSize = true;
        lbl_txtLoaiP.Location = new Point(420, 88);
        lbl_txtLoaiP.Text = "Loại phòng";
        // txtLoaiP
        txtLoaiP.Location = new Point(520, 85);
        txtLoaiP.Size = new Size(150, 27);
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
        // btnBack
        btnBack.Location = new Point(315, 130);
        btnBack.Size = new Size(130, 30);
        btnBack.Text = "← Trang chủ";
        btnBack.BackColor = Color.FromArgb(33, 150, 243);
        btnBack.ForeColor = Color.White;
        btnBack.FlatStyle = FlatStyle.Flat;
        btnBack.FlatAppearance.BorderSize = 0;
        btnBack.UseVisualStyleBackColor = false;
        btnBack.Click += btnBack_Click;
        Controls.Add(dgvP);
        Controls.Add(pnlTop);
        pnlTop.Controls.Add(lbl_txtMaP);
        pnlTop.Controls.Add(txtMaP);
        pnlTop.Controls.Add(lbl_txtTenP);
        pnlTop.Controls.Add(txtTenP);
        pnlTop.Controls.Add(lbl_txtToa);
        pnlTop.Controls.Add(txtToa);
        pnlTop.Controls.Add(lbl_nudTang);
        pnlTop.Controls.Add(nudTang);
        pnlTop.Controls.Add(lbl_nudSucChua);
        pnlTop.Controls.Add(nudSucChua);
        pnlTop.Controls.Add(lbl_txtLoaiP);
        pnlTop.Controls.Add(txtLoaiP);
        pnlTop.Controls.Add(btnThem);
        pnlTop.Controls.Add(btnSua);
        pnlTop.Controls.Add(btnXoa);
        pnlTop.Controls.Add(btnBack);
        // PhongPage
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(238, 241, 246);
        Font = new Font("Segoe UI", 10F);
        Name = "PhongPage";
        Padding = new Padding(16);
        Size = new Size(1100, 600);
        ResumeLayout(false);
    }

    private DataGridView dgvP;
    private Panel pnlTop;
    private Label lbl_txtMaP;
    private TextBox txtMaP;
    private Label lbl_txtTenP;
    private TextBox txtTenP;
    private Label lbl_txtToa;
    private TextBox txtToa;
    private Label lbl_nudTang;
    private NumericUpDown nudTang;
    private Label lbl_nudSucChua;
    private NumericUpDown nudSucChua;
    private Label lbl_txtLoaiP;
    private TextBox txtLoaiP;
    private Button btnThem;
    private Button btnSua;
    private Button btnXoa;
    private Button btnBack;
}
