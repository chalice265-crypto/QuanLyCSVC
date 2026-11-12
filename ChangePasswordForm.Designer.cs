partial class ChangePasswordForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblOld = new Label(); lblNew = new Label(); lblCf = new Label();
        txtOld = new TextBox(); txtNew = new TextBox(); txtCf = new TextBox();
        btnSave = new Button(); btnCancel = new Button();
        SuspendLayout();
        // lblOld / txtOld
        lblOld.AutoSize = true; lblOld.Location = new Point(40, 20); lblOld.Name = "lblOld"; lblOld.TabIndex = 0; lblOld.Text = "Mật khẩu hiện tại";
        txtOld.Location = new Point(40, 44); txtOld.Name = "txtOld"; txtOld.Size = new Size(280, 27); txtOld.TabIndex = 1; txtOld.UseSystemPasswordChar = true;
        // lblNew / txtNew
        lblNew.AutoSize = true; lblNew.Location = new Point(40, 85); lblNew.Name = "lblNew"; lblNew.TabIndex = 2; lblNew.Text = "Mật khẩu mới (từ 6 ký tự)";
        txtNew.Location = new Point(40, 109); txtNew.Name = "txtNew"; txtNew.Size = new Size(280, 27); txtNew.TabIndex = 3; txtNew.UseSystemPasswordChar = true;
        // lblCf / txtCf
        lblCf.AutoSize = true; lblCf.Location = new Point(40, 150); lblCf.Name = "lblCf"; lblCf.TabIndex = 4; lblCf.Text = "Nhập lại mật khẩu mới";
        txtCf.Location = new Point(40, 174); txtCf.Name = "txtCf"; txtCf.Size = new Size(280, 27); txtCf.TabIndex = 5; txtCf.UseSystemPasswordChar = true;
        // btnSave
        btnSave.Location = new Point(40, 225); btnSave.Name = "btnSave"; btnSave.Size = new Size(135, 34); btnSave.TabIndex = 6; btnSave.Text = "Lưu";
        btnSave.UseVisualStyleBackColor = true; btnSave.Click += btnSave_Click;
        // btnCancel
        btnCancel.DialogResult = DialogResult.Cancel; btnCancel.Location = new Point(185, 225); btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(135, 34); btnCancel.TabIndex = 7; btnCancel.Text = "Hủy"; btnCancel.UseVisualStyleBackColor = true;
        // ChangePasswordForm
        AcceptButton = btnSave; AutoScaleDimensions = new SizeF(96F, 96F); AutoScaleMode = AutoScaleMode.Dpi;
        CancelButton = btnCancel; ClientSize = new Size(360, 290); Font = new Font("Segoe UI", 10F);
        Controls.Add(lblOld); Controls.Add(txtOld); Controls.Add(lblNew); Controls.Add(txtNew); Controls.Add(lblCf);
        Controls.Add(txtCf); Controls.Add(btnSave); Controls.Add(btnCancel);
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false; Name = "ChangePasswordForm";
        StartPosition = FormStartPosition.CenterParent; Text = "Đổi mật khẩu";
        ResumeLayout(false); PerformLayout();
    }

    private Label lblOld, lblNew, lblCf;
    private TextBox txtOld, txtNew, txtCf;
    private Button btnSave, btnCancel;
}
