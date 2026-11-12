using System.Data;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        pnlHost = new Panel();
        dashPage = new DashboardPage();
        tbPage = new ThietBiPage();
        phongPage = new PhongPage();
        usersPage = new UsersPage();
        logPage = new LogPage();
        pnlHeader = new Panel();
        lblBrand = new Label();
        txtGlobal = new TextBox();
        pnlNav = new Panel();
        lblHome = new Label();
        lblUser = new Label();
        lblLogout = new Label();
        SuspendLayout();
        // pnlHost
        pnlHost.Dock = DockStyle.Fill;
        // dashPage
        dashPage.Dock = DockStyle.Fill;
        // tbPage
        tbPage.Dock = DockStyle.Fill;
        tbPage.Visible = false;
        // phongPage
        phongPage.Dock = DockStyle.Fill;
        phongPage.Visible = false;
        // usersPage
        usersPage.Dock = DockStyle.Fill;
        usersPage.Visible = false;
        // logPage
        logPage.Dock = DockStyle.Fill;
        logPage.Visible = false;
        // pnlHeader
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Height = 64;
        pnlHeader.BackColor = Color.White;
        // lblBrand
        lblBrand.AutoSize = true;
        lblBrand.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblBrand.ForeColor = Color.FromArgb(33, 150, 243);
        lblBrand.Location = new Point(20, 18);
        lblBrand.Text = "🏫 QUẢN LÝ CƠ SỞ VẬT CHẤT";
        // txtGlobal
        txtGlobal.Location = new Point(380, 17);
        txtGlobal.Size = new Size(230, 27);
        txtGlobal.PlaceholderText = "Tìm kiếm thiết bị...";
        txtGlobal.KeyDown += txtGlobal_KeyDown;
        // pnlNav
        pnlNav.Dock = DockStyle.Right;
        pnlNav.Width = 560;
        // lblHome
        lblHome.AutoSize = true;
        lblHome.Cursor = Cursors.Hand;
        lblHome.Location = new Point(10, 21);
        lblHome.Text = "🏠 Trang chủ";
        lblHome.Click += lblHome_Click;
        // lblUser
        lblUser.AutoSize = true;
        lblUser.Cursor = Cursors.Hand;
        lblUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblUser.Location = new Point(140, 21);
        lblUser.Text = "👤";
        lblUser.Click += lblUser_Click;
        // lblLogout
        lblLogout.AutoSize = true;
        lblLogout.Cursor = Cursors.Hand;
        lblLogout.Location = new Point(440, 21);
        lblLogout.Text = "⎋ Đăng xuất";
        lblLogout.Click += lblLogout_Click;
        Controls.Add(pnlHost);
        pnlHost.Controls.Add(dashPage);
        pnlHost.Controls.Add(tbPage);
        pnlHost.Controls.Add(phongPage);
        pnlHost.Controls.Add(usersPage);
        pnlHost.Controls.Add(logPage);
        Controls.Add(pnlHeader);
        pnlHeader.Controls.Add(lblBrand);
        pnlHeader.Controls.Add(txtGlobal);
        pnlHeader.Controls.Add(pnlNav);
        pnlNav.Controls.Add(lblHome);
        pnlNav.Controls.Add(lblUser);
        pnlNav.Controls.Add(lblLogout);
        // MainForm
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(238, 241, 246);
        ClientSize = new Size(1264, 721);
        Font = new Font("Segoe UI", 10F);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Quản lý cơ sở vật chất trường học";
        ResumeLayout(false);
    }

    private Panel pnlHost;
    private DashboardPage dashPage;
    private ThietBiPage tbPage;
    private PhongPage phongPage;
    private UsersPage usersPage;
    private LogPage logPage;
    private Panel pnlHeader;
    private Label lblBrand;
    private TextBox txtGlobal;
    private Panel pnlNav;
    private Label lblHome;
    private Label lblUser;
    private Label lblLogout;
}
