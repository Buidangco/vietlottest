# Yêu cầu Quản trị Người dùng

## 1. Yêu cầu chức năng
- **Xem danh sách**: Hiển thị danh sách tất cả người dùng.
- **Thông tin hiển thị**: Ảnh đại diện, Họ tên, Email, Phòng ban, Vai trò, Trạng thái (Hoạt động/Bị khóa), Đăng nhập cuối.
- **Thống kê**: Hiển thị tổng số lượng tài khoản hiện có.
- **Thêm tài khoản**: Quản trị viên có thể thêm người dùng mới (Trường dữ liệu: Họ tên, Email, Phòng ban, Vai trò).
- **Sửa tài khoản**: Cập nhật thông tin tài khoản (Trường dữ liệu: Họ tên, Email, Phòng ban, Số điện thoại).
- **Xóa tài khoản**: Xóa vĩnh viễn người dùng khỏi hệ thống.
- **Khóa/Mở khóa**: Thay đổi trạng thái truy cập của tài khoản.
- **Đổi ảnh đại diện**: Cập nhật ảnh đại diện cho người dùng.
- **Phân quyền**: Gán vai trò và quyền hạn (chức năng phân quyền riêng).

## 2. Yêu cầu phi chức năng
- **Giao diện (UI)**: Thêm và Sửa tài khoản phải mở trong Modal để giữ nguyên màn hình danh sách.
- **Bảo mật**:
  - Tài khoản "Bị khóa" không được phép đăng nhập.
  - Validate (Kiểm tra) dữ liệu đầu vào bắt buộc ở phía người dùng (Frontend).
- **Trải nghiệm (UX)**:
  - Dùng nhãn (badge) màu sắc để phân biệt trạng thái (Hoạt động, Bị khóa) và đánh dấu người dùng hiện tại ("Bạn").
  - Nếu không có ảnh đại diện, tự động hiển thị ảnh chữ cái tên sử dụng API của ui-avatars.

## 3. Quy tắc nghiệp vụ
- **Dữ liệu bắt buộc**:
  - Khi tạo mới: Họ tên, Email.
  - Khi cập nhật: Họ tên, Email.
- **Danh sách Phòng ban**: Ban Giám Đốc, Phòng Tài vụ, Phòng Kế hoạch Phát hành, Phòng Trả thưởng, Phòng Thanh Tra, Chi nhánh.
- **Danh sách Vai trò (Quyền)**: Admin (Giám đốc), Nhân viên Kế toán, Nhân viên Thẩm định, Chuyên viên Phát hành, Thủ kho vé, Giám sát viên (Read-only).
- **Ngữ cảnh người dùng**: Hệ thống nhận biết tài khoản đang đăng nhập để hiển thị nhãn "Bạn" và chặn tự khóa/xóa chính mình.
- **Trạng thái mặc định**: Tài khoản mới tạo luôn có trạng thái mặc định là "Hoạt động".