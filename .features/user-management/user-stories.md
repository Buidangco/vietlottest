# User Stories - Quản trị Người dùng

## US01: Xem danh sách tài khoản
**Là** Quản trị viên
**Tôi muốn** xem danh sách tất cả tài khoản
**Để** quản lý lượng người dùng hiện có trên hệ thống.
*Tiêu chí chấp nhận:*
- Hiển thị bảng gồm: Ảnh đại diện, Họ tên, Email, Phòng ban, Vai trò, Trạng thái, Đăng nhập cuối.
- Hiển thị tổng số lượng tài khoản.
- Tài khoản của người đang đăng nhập có nhãn "Bạn".
- Ảnh đại diện trống tự động lấy chữ cái đầu tên (ui-avatars).

## US02: Thêm tài khoản mới
**Là** Quản trị viên
**Tôi muốn** thêm tài khoản mới
**Để** cấp quyền sử dụng hệ thống cho nhân viên mới.
*Tiêu chí chấp nhận:*
- Mở form Thêm trên cửa sổ Modal.
- Bắt buộc nhập: Họ và Tên, Email.
- Chọn Phòng ban từ danh sách: Ban Giám Đốc, Phòng Tài vụ, Phòng KH Phát hành, Phòng Trả thưởng, Phòng Thanh Tra, Chi nhánh.
- Chọn Vai trò từ danh sách: Admin, Kế toán, Thẩm định, Phát hành, Thủ kho, Giám sát.
- Tài khoản mới tạo mặc định trạng thái "Hoạt động".

## US03: Sửa thông tin tài khoản
**Là** Quản trị viên
**Tôi muốn** sửa thông tin của một tài khoản
**Để** cập nhật thông tin khi có thay đổi.
*Tiêu chí chấp nhận:*
- Mở form Sửa trên cửa sổ Modal.
- Bắt buộc nhập: Họ và Tên, Email.
- Có thể sửa Phòng ban và Số điện thoại (tùy chọn).
- Dữ liệu cũ tự động điền sẵn vào form.

## US04: Xóa tài khoản
**Là** Quản trị viên
**Tôi muốn** xóa tài khoản
**Để** dọn dẹp dữ liệu người dùng không còn sử dụng.
*Tiêu chí chấp nhận:*
- Có nút xóa trên mỗi dòng tài khoản (trừ tài khoản của chính mình).
- Xóa vĩnh viễn tài khoản khỏi hệ thống.

## US05: Khóa và Mở khóa tài khoản
**Là** Quản trị viên
**Tôi muốn** khóa hoặc mở khóa tài khoản
**Để** kiểm soát quyền truy cập hệ thống một cách nhanh chóng.
*Tiêu chí chấp nhận:*
- Có nút Khóa (nếu đang hoạt động) hoặc Mở khóa (nếu bị khóa).
- Đổi nhãn trạng thái tương ứng ("Hoạt động" hoặc "Bị khóa").
- Tài khoản "Bị khóa" bị chặn đăng nhập.

## US06: Cập nhật ảnh đại diện
**Là** Quản trị viên / Người dùng
**Tôi muốn** thay đổi ảnh đại diện
**Để** cá nhân hóa và dễ nhận diện.
*Tiêu chí chấp nhận:*
- Có biểu tượng máy ảnh trên ảnh đại diện ở danh sách.
- Cho phép upload ảnh mới thay thế ảnh cũ/ảnh mặc định.

## US07: Phân quyền tài khoản
**Là** Quản trị viên
**Tôi muốn** mở form phân quyền cho người dùng
**Để** gán quyền hạn chi tiết hơn nếu cần.
*Tiêu chí chấp nhận:*
- Nút phân quyền (biểu tượng khiên) mở ra giao diện phân quyền riêng biệt.