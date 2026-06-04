# User Stories - Quản trị Nhóm Quyền

## US01: Xem danh sách Nhóm Quyền
**Là** Quản trị viên
**Tôi muốn** xem toàn bộ các nhóm quyền trên hệ thống
**Để** biết các vai trò đang có và quyền hạn của chúng.
*Tiêu chí chấp nhận:*
- Hiển thị dạng Card Grid (2 cột).
- Hiển thị tên nhóm, mô tả.
- Hiển thị tổng số lượng phân hệ được cấp phép (VD: 4/11).
- Hiển thị đầy đủ 11 phân hệ, nếu phân hệ nào không được phép thì hiển thị chữ màu xám, gạch ngang.
- Hiển thị tổng số người dùng (user) đang thuộc nhóm này.

## US02: Thêm Nhóm Quyền mới
**Là** Quản trị viên
**Tôi muốn** tạo thêm nhóm quyền
**Để** cấp quyền chi tiết cho một bộ phận nhân sự mới.
*Tiêu chí chấp nhận:*
- Form mở dạng Modal.
- Bắt buộc nhập Tên nhóm (duy nhất).
- Cho phép tích chọn trong 11 phân hệ.
- Lưu thành công thì Card mới xuất hiện với màu sắc ngẫu nhiên hoặc mặc định.

## US03: Sửa Nhóm Quyền
**Là** Quản trị viên
**Tôi muốn** thay đổi quyền của nhóm
**Để** thêm hoặc bớt quyền truy cập cho nhân viên khi quy trình thay đổi.
*Tiêu chí chấp nhận:*
- Form mở Modal với dữ liệu cũ điền sẵn (Tên, mô tả, các ô checkbox đã tích).
- Cho phép đổi quyền, đổi tên.
- Lưu và cập nhật lại giao diện.

## US04: Xóa Nhóm Quyền
**Là** Quản trị viên
**Tôi muốn** xóa một nhóm quyền không còn sử dụng
**Để** dọn dẹp hệ thống.
*Tiêu chí chấp nhận:*
- Có nút xóa trên mỗi Card.
- Xác nhận trước khi xóa.
- API chặn xóa nếu Nhóm đang có người dùng (trả về lỗi "Nhóm đang có thành viên, không thể xóa").