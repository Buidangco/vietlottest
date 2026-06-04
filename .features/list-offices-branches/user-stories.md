# User Stories - Danh mục Phòng ban / Chi nhánh

## US01: Xem danh sách đơn vị
**Là** Quản trị viên
**Tôi muốn** xem danh sách tất cả các phòng ban và chi nhánh
**Để** quản lý cơ cấu tổ chức và số lượng nhân sự của từng đơn vị.
*Tiêu chí chấp nhận:*
- Bảng hiển thị gồm Mã đơn vị, Tên, Phân loại, Trưởng đơn vị, Quy mô và Trạng thái.
- Cột Quy mô đếm đúng số nhân sự đang trực thuộc.

## US02: Thêm đơn vị mới
**Là** Quản trị viên
**Tôi muốn** tạo thêm phòng ban hoặc chi nhánh mới
**Để** mở rộng cơ cấu tổ chức khi có biến động nhân sự/kinh doanh.
*Tiêu chí chấp nhận:*
- Form mở dạng Modal.
- Mã đơn vị bắt buộc nhập và hệ thống báo lỗi nếu mã đã tồn tại.
- Chọn đúng phân loại: "Phòng ban" hoặc "Chi nhánh".
- Trạng thái mặc định là Hoạt động.

## US03: Cập nhật thông tin đơn vị
**Là** Quản trị viên
**Tôi muốn** sửa thông tin của một đơn vị
**Để** thay đổi Trưởng đơn vị hoặc điều chỉnh Tên, Trạng thái hoạt động.
*Tiêu chí chấp nhận:*
- Form mở Modal với thông tin cũ được điền sẵn.
- Ô Mã đơn vị bị vô hiệu hóa (disabled), không thể sửa.
- Cho phép cập nhật thành công và giao diện bảng tự động làm mới.

## US04: Xóa đơn vị
**Là** Quản trị viên
**Tôi muốn** xóa một phòng ban/chi nhánh không còn sử dụng
**Để** làm gọn danh mục tổ chức.
*Tiêu chí chấp nhận:*
- Hiển thị xác nhận trước khi xóa.
- Nếu đơn vị có nhân sự (Quy mô > 0), hệ thống chặn xóa và hiện thông báo lỗi: "Không thể xóa do đang có nhân sự".
- Nếu quy mô = 0, cho phép xóa vĩnh viễn khỏi CSDL.