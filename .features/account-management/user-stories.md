# User Stories - Quản trị Tài khoản

## US01: Xem danh sách tài khoản
**Là** Quản trị viên
**Tôi muốn** xem toàn bộ danh sách tài khoản trong hệ thống
**Để** dễ dàng quản lý và theo dõi thông tin người dùng.
*Tiêu chí chấp nhận:*
- Hiển thị bảng gồm các cột: Tài khoản (Avatar, Tên, Email), Phòng ban, Vai trò, Trạng thái, Đăng nhập cuối.
- Hiển thị tổng số tài khoản trên góc phải bảng.
- User hiện tại đang đăng nhập có nhãn "Bạn".
- User chưa có ảnh đại diện sẽ hiển thị ảnh mặc định tạo từ tên.

## US02: Thêm tài khoản mới
**Là** Quản trị viên
**Tôi muốn** tạo thêm tài khoản mới trên hệ thống
**Để** cung cấp quyền truy cập cho nhân viên/thành viên mới.
*Tiêu chí chấp nhận:*
- Nhấn "Thêm Tài Khoản" sẽ mở cửa sổ Modal form.
- Form yêu cầu điền: Họ tên (Bắt buộc), Email (Bắt buộc, không trùng lặp).
- Cho phép chọn Phòng ban và Vai trò (Role) từ danh sách có sẵn.
- Tạo thành công tài khoản sẽ hiển thị ngay lên đầu danh sách với trạng thái "Hoạt động".

## US03: Sửa thông tin tài khoản
**Là** Quản trị viên
**Tôi muốn** sửa thông tin của một tài khoản đã có
**Để** cập nhật thông tin (Tên, SĐT, Phòng ban) khi nhân viên thay đổi dữ liệu.
*Tiêu chí chấp nhận:*
- Nhấn nút "Sửa" (icon Edit) trên 1 dòng sẽ mở Modal form với thông tin cũ được điền sẵn.
- Cập nhật thông tin thành công, đóng Modal và hiển thị dữ liệu mới trên bảng.

## US04: Khóa và Mở khóa tài khoản
**Là** Quản trị viên
**Tôi muốn** khóa hoặc mở khóa tài khoản
**Để** tạm thời ngừng quyền truy cập của nhân sự nghỉ việc hoặc cấp lại khi cần thiết.
*Tiêu chí chấp nhận:*
- Nếu user đang "Hoạt động", nút thao tác là "Khóa" (màu đỏ). Bấm vào chuyển trạng thái sang "Bị khóa".
- Nếu user đang "Bị khóa", nút thao tác là "Mở khóa" (màu xanh/ổ khóa mở). Bấm vào chuyển lại "Hoạt động".
- API từ chối login nếu tài khoản "Bị khóa".

## US05: Xóa tài khoản
**Là** Quản trị viên
**Tôi muốn** xóa một tài khoản
**Để** dọn dẹp hệ thống khi nhân viên nghỉ việc vĩnh viễn.
*Tiêu chí chấp nhận:*
- Có icon thùng rác màu đỏ trên các tài khoản.
- Xác nhận trước khi xóa vĩnh viễn khỏi CSDL.
- Không được phép xóa tài khoản của chính mình đang đăng nhập.

## US06: Cập nhật ảnh đại diện
**Là** Quản trị viên hoặc Người dùng
**Tôi muốn** cập nhật ảnh đại diện (avatar)
**Để** cá nhân hóa tài khoản.
*Tiêu chí chấp nhận:*
- Nhấn icon camera góc dưới avatar ở danh sách.
- Mở file chọn ảnh tải lên.
- Upload thành công, ảnh đại diện thay đổi ngay lập tức trên UI mà không cần tải lại trang.