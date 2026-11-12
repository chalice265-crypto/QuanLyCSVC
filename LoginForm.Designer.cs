partial class LoginForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitle = new Label(); lblUser = new Label(); lblPass = new Label(); lblHint = new Label();
        txtU = new TextBox(); txtP = new TextBox(); btnLogin = new Button();
        SuspendLayout();
        // lblTitle
        lblTitle.AutoSize = true; lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(33, 150, 243); lblTitle.Location = new Point(40, 20);
        lblTitle.Name = "lblTitle"; lblTitle.TabIndex = 0; lblTitle.Text = "🏫 QUẢN LÝ CSVC";
        // lblUser
        lblUser.AutoSize = true; lblUser.Location = new Point(40, 75); lblUser.Name = "lblUser"; lblUser.TabIndex = 1; lblUser.Text = "Tài khoản";
        // txtU
        txtU.Location = new Point(40, 98); txtU.Name = "txtU"; txtU.Size = new Size(280, 27); txtU.TabIndex = 2;
        // lblPass
        lblPass.AutoSize = true; lblPass.Location = new Point(40, 140); lblPass.Name = "lblPass"; lblPass.TabIndex = 3; lblPass.Text = "Mật khẩu";
        // txtP
        txtP.Location = new Point(40, 163); txtP.Name = "txtP"; txtP.Size = new Size(280, 27); txtP.TabIndex = 4; txtP.UseSystemPasswordChar = true;
        // btnLogin
        btnLogin.BackColor = Color.FromArgb(33, 150, 243); btnLogin.FlatStyle = FlatStyle.Flat; btnLogin.FlatAppearance.BorderSize = 0;
        btnLogin.ForeColor = Color.White; btnLogin.Location = new Point(40, 215); btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(280, 38); btnLogin.TabIndex = 5; btnLogin.Text = "Đăng nhập"; btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += btnLogin_Click;
        // lblHint
        lblHint.AutoSize = true; lblHint.ForeColor = Color.Gray; lblHint.Location = new Point(40, 268); lblHint.Name = "lblHint";
        lblHint.TabIndex = 6; lblHint.Text = "Chưa có tài khoản? Liên hệ quản trị viên.";
        // LoginForm
        AcceptButton = btnLogin; AutoScaleDimensions = new SizeF(96F, 96F); AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.White; ClientSize = new Size(360, 300); Font = new Font("Segoe UI", 10F);
        Controls.Add(lblTitle); Controls.Add(lblUser); Controls.Add(txtU); Controls.Add(lblPass);
        Controls.Add(txtP); Controls.Add(btnLogin); Controls.Add(lblHint);
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen; Text = "Đăng nhập";
        ResumeLayout(false); PerformLayout();
    }

    private Label lblTitle, lblUser, lblPass, lblHint;
    private TextBox txtU, txtP;
    private Button btnLogin;
}
