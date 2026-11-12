using System.Data;

partial class UsersPage
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        dgvU = new DataGridView();
        pnlTop = new Panel();
        lbl_txtUser = new Label();
        txtUser = new TextBox();
        lbl_txtHoTen = new Label();
        txtHoTen = new TextBox();
        lbl_cboRole = new Label();
        cboRole = new ComboBox();
        lbl_txtPw = new Label();
        txtPw = new TextBox();
        lblNote = new Label();
        btnTao = new Button();
        btnCapNhat = new Button();
        btnKhoa = new Button();
        btnReset = new Button();
        btnMoi = new Button();
        btnBack = new Button();
        SuspendLayout();
        // dgvU
        dgvU.Dock = DockStyle.Fill;
        dgvU.ReadOnly = true;
        dgvU.AllowUserToAddRows = false;
        dgvU.RowHeadersVisible = false;
        dgvU.BackgroundColor = Color.White;
        dgvU.BorderStyle = BorderStyle.None;
        dgvU.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvU.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvU.SelectionChanged += dgvU_SelectionChanged;
        // pnlTop
        pnlTop.Dock = DockStyle.Top;
        pnlTop.Height = 190;
        pnlTop.BackColor = Color.White;
        // lbl_txtUser
        lbl_txtUser.AutoSize = true;
        lbl_txtUser.Location = new Point(15, 18);
        lbl_txtUser.Text = "Tài khoản";
        // txtUser
        txtUser.Location = new Point(115, 15);
        txtUser.Size = new Size(180, 27);
        // lbl_txtHoTen
        lbl_txtHoTen.AutoSize = true;
        lbl_txtHoTen.Location = new Point(15, 53);
        lbl_txtHoTen.Text = "Họ tên";
        // txtHoTen
        txtHoTen.Location = new Point(115, 50);
        txtHoTen.Size = new Size(250, 27);
        // lbl_cboRole
        lbl_cboRole.AutoSize = true;
        lbl_cboRole.Location = new Point(15, 88);
        lbl_cboRole.Text = "Vai trò";
        // cboRole
        cboRole.Location = new Point(115, 85);
        cboRole.Size = new Size(180, 27);
        cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
        // lbl_txtPw
        lbl_txtPw.AutoSize = true;
        lbl_txtPw.Location = new Point(420, 18);
        lbl_txtPw.Text = "Mật khẩu";
        // txtPw
        txtPw.Location = new Point(520, 15);
        txtPw.Size = new Size(180, 27);
        txtPw.PlaceholderText = "mật khẩu tạm";
        // lblNote
        lblNote.Location = new Point(420, 50);
        lblNote.Size = new Size(450, 40);
        lblNote.ForeColor = Color.Gray;
        lblNote.Text = "Mật khẩu tạm dùng khi Tạo mới / Reset; người dùng sẽ phải đổi ở lần đăng nhập đầu.";
        // btnTao
        btnTao.Location = new Point(15, 130);
        btnTao.Size = new Size(100, 30);
        btnTao.Text = "Tạo mới";
        btnTao.BackColor = Color.FromArgb(33, 150, 243);
        btnTao.ForeColor = Color.White;
        btnTao.FlatStyle = FlatStyle.Flat;
        btnTao.FlatAppearance.BorderSize = 0;
        btnTao.UseVisualStyleBackColor = false;
        btnTao.Click += btnTao_Click;
        // btnCapNhat
        btnCapNhat.Location = new Point(125, 130);
        btnCapNhat.Size = new Size(100, 30);
        btnCapNhat.Text = "Cập nhật";
        btnCapNhat.BackColor = Color.FromArgb(33, 150, 243);
        btnCapNhat.ForeColor = Color.White;
        btnCapNhat.FlatStyle = FlatStyle.Flat;
        btnCapNhat.FlatAppearance.BorderSize = 0;
        btnCapNhat.UseVisualStyleBackColor = false;
        btnCapNhat.Click += btnCapNhat_Click;
        // btnKhoa
        btnKhoa.Location = new Point(235, 130);
        btnKhoa.Size = new Size(100, 30);
        btnKhoa.Text = "Khóa/Mở";
        btnKhoa.BackColor = Color.FromArgb(33, 150, 243);
        btnKhoa.ForeColor = Color.White;
        btnKhoa.FlatStyle = FlatStyle.Flat;
        btnKhoa.FlatAppearance.BorderSize = 0;
        btnKhoa.UseVisualStyleBackColor = false;
        btnKhoa.Click += btnKhoa_Click;
        // btnReset
        btnReset.Location = new Point(345, 130);
        btnReset.Size = new Size(100, 30);
        btnReset.Text = "Reset MK";
        btnReset.BackColor = Color.FromArgb(33, 150, 243);
        btnReset.ForeColor = Color.White;
        btnReset.FlatStyle = FlatStyle.Flat;
        btnReset.FlatAppearance.BorderSize = 0;
        btnReset.UseVisualStyleBackColor = false;
        btnReset.Click += btnReset_Click;
        // btnMoi
        btnMoi.Location = new Point(455, 130);
        btnMoi.Size = new Size(100, 30);
        btnMoi.Text = "Nhập mới";
        btnMoi.BackColor = Color.FromArgb(33, 150, 243);
        btnMoi.ForeColor = Color.White;
        btnMoi.FlatStyle = FlatStyle.Flat;
        btnMoi.FlatAppearance.BorderSize = 0;
        btnMoi.UseVisualStyleBackColor = false;
        btnMoi.Click += btnMoi_Click;
        // btnBack
        btnBack.Location = new Point(565, 130);
        btnBack.Size = new Size(130, 30);
        btnBack.Text = "← Trang chủ";
        btnBack.BackColor = Color.FromArgb(33, 150, 243);
        btnBack.ForeColor = Color.White;
        btnBack.FlatStyle = FlatStyle.Flat;
        btnBack.FlatAppearance.BorderSize = 0;
        btnBack.UseVisualStyleBackColor = false;
        btnBack.Click += btnBack_Click;
        Controls.Add(dgvU);
        Controls.Add(pnlTop);
        pnlTop.Controls.Add(lbl_txtUser);
        pnlTop.Controls.Add(txtUser);
        pnlTop.Controls.Add(lbl_txtHoTen);
        pnlTop.Controls.Add(txtHoTen);
        pnlTop.Controls.Add(lbl_cboRole);
        pnlTop.Controls.Add(cboRole);
        pnlTop.Controls.Add(lbl_txtPw);
        pnlTop.Controls.Add(txtPw);
        pnlTop.Controls.Add(lblNote);
        pnlTop.Controls.Add(btnTao);
        pnlTop.Controls.Add(btnCapNhat);
        pnlTop.Controls.Add(btnKhoa);
        pnlTop.Controls.Add(btnReset);
        pnlTop.Controls.Add(btnMoi);
        pnlTop.Controls.Add(btnBack);
        // UsersPage
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(238, 241, 246);
        Font = new Font("Segoe UI", 10F);
        Name = "UsersPage";
        Padding = new Padding(16);
        Size = new Size(1100, 600);
        ResumeLayout(false);
    }

    private DataGridView dgvU;
    private Panel pnlTop;
    private Label lbl_txtUser;
    private TextBox txtUser;
    private Label lbl_txtHoTen;
    private TextBox txtHoTen;
    private Label lbl_cboRole;
    private ComboBox cboRole;
    private Label lbl_txtPw;
    private TextBox txtPw;
    private Label lblNote;
    private Button btnTao;
    private Button btnCapNhat;
    private Button btnKhoa;
    private Button btnReset;
    private Button btnMoi;
    private Button btnBack;
}
