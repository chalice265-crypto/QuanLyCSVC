HƯỚNG DẪN CHẠY
1. SSMS: mở CSDL_QLCSVC.sql -> Execute (chạy lại nhiều lần không lỗi).
2. Visual Studio 2022 (.NET 8): mở QuanLyCSVC.csproj. Nếu SQL Server không phải localhost, sửa chuỗi Conn trong Program.cs.
3. Build > Rebuild Solution, rồi F5. Lần đầu đăng nhập: admin / admin123 (bắt đổi mật khẩu).
SỬA GIAO DIỆN BẰNG DESIGNER: bấm đúp các file sau trong Solution Explorer
  LoginForm, ChangePasswordForm, MainForm (khung + header), DashboardPage (trang chủ),
  ThietBiPage, PhongPage, UsersPage, LogPage.
  (Phải Rebuild một lần thì các trang UserControl mới hiện được trong Designer/Toolbox.)
Phần xử lý nằm ở file .cs cùng tên; bố cục nằm ở file .Designer.cs.
