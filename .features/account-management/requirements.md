# Yêu cầu hệ thống - Quản trị Tài khoản

## 1. Yêu cầu chức năng (Functional Requirements)
- **Xem danh sách tài khoản**: Hệ thống phải hiển thị danh sách tất cả tài khoản dưới dạng bảng. Thông tin hiển thị bao gồm: Avatar, Họ tên, Email, Phòng ban, Vai trò, Trạng thái (Hoạt động/Bị khóa) và thời gian đăng nhập cuối.
- **Thống kê tổng số lượng**: Hiển thị tổng số tài khoản hiện có trong hệ thống.
- **Đánh dấu tài khoản hiện tại**: Tài khoản của người đang đăng nhập phải được hiển thị nổi bật với huy hiệu "Bạn".
- **Thêm tài khoản mới**: Quản trị viên có thể tạo tài khoản mới. Các trường dữ liệu bao gồm Họ tên, Email, Phòng ban, và Nhóm quyền (Vai trò).
- **Cập nhật thông tin tài khoản**: Quản trị viên có thể thay đổi Họ tên, Số điện thoại, Phòng ban của một tài khoản.
- **Khóa/Mở khóa tài khoản**: Quản trị viên có thể tạm ngưng (Khóa) hoặc cấp lại quyền (Mở khóa) truy cập của một tài khoản.
- **Xóa tài khoản**: Xóa tài khoản vĩnh viễn khỏi hệ thống.
- **Cập nhật ảnh đại diện**: Người dùng (hoặc quản trị viên) có thể tải lên và thay đổi ảnh đại diện.
- **Phân quyền nhanh**: Cung cấp nút thao tác để chuyển nhanh tới form gán vai trò/nhóm quyền cho tài khoản đó.

## 2. Yêu cầu phi chức năng (Non-functional Requirements)
- **Giao diện/Trải nghiệm (UI/UX)**:
  - Mở các form (Thêm, Sửa, Phân quyền) trong Modal popup, không chuyển trang.
  - Các huy hiệu (badge) trạng thái và vai trò cần có màu sắc dễ phân biệt (Ví dụ: Hoạt động màu xanh, Bị khóa màu đỏ/cam).
  - Ảnh đại diện trống tự động sinh ảnh từ tên qua API `ui-avatars.com`.
- **Bảo mật**:
  - Không cho phép người dùng tự xóa hoặc tự khóa tài khoản của chính mình.
  - Tài khoản có trạng thái "Bị khóa" sẽ bị hệ thống từ chối đăng nhập (Unauthorized).

## 3. Quy tắc nghiệp vụ (Business Rules)
- **Dữ liệu bắt buộc**: Tên và Email là bắt buộc khi tạo tài khoản mới. Email phải đúng định dạng và duy nhất trên toàn hệ thống.
- **Trạng thái mặc định**: Tài khoản mới tạo luôn ở trạng thái "Hoạt động".
- **Khóa ngoại Vai trò (Role)**: Cột "VAI TRÒ" hiển thị tên của Nhóm Quyền (Role) mà tài khoản đó đang được gán. Nếu Nhóm quyền thay đổi tên, thông tin hiển thị trên bảng cũng phải cập nhật tương ứng.