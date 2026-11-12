// Giao diện: sửa bằng Designer (ChangePasswordForm.Designer.cs). File này chỉ chứa xử lý.
partial class ChangePasswordForm : Form
{
    public ChangePasswordForm() : this(false) { }   // constructor rỗng để Designer mở được

    public ChangePasswordForm(bool forced)
    {
        InitializeComponent();
        if (forced)   // đăng nhập lần đầu: bắt buộc đổi, không cho hủy
        {
            Text = "Đổi mật khẩu lần đầu"; ControlBox = false;
            btnCancel.Visible = false; CancelButton = null; btnSave.Width = 280;
        }
    }

    void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            var r = Db.Query("SELECT MatKhauHash, Salt FROM NguoiDung WHERE MaND=@id", ("@id", Session.Id)).Rows[0];
            if (!Security.Verify(txtOld.Text, (byte[])r["Salt"], (byte[])r["MatKhauHash"])) { MessageBox.Show("Mật khẩu hiện tại không đúng."); return; }
            if (txtNew.Text.Length < 6) { MessageBox.Show("Mật khẩu mới phải từ 6 ký tự."); return; }
            if (txtNew.Text != txtCf.Text) { MessageBox.Show("Mật khẩu nhập lại không khớp."); return; }
            if (txtNew.Text == txtOld.Text) { MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ."); return; }
            var salt = Security.NewSalt();
            Db.Exec("UPDATE NguoiDung SET MatKhauHash=@h, Salt=@s, BatDoiMatKhau=0 WHERE MaND=@id",
                ("@h", Security.Hash(txtNew.Text, salt)), ("@s", salt), ("@id", Session.Id));
            Db.Log("Đổi mật khẩu", ""); MessageBox.Show("Đã đổi mật khẩu."); DialogResult = DialogResult.OK;
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }
}
