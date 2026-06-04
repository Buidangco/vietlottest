# Yêu cầu - Quản trị Nhóm Quyền

## 1. Yêu cầu chức năng
- **Xem danh sách**: Hệ thống hiển thị tất cả các Nhóm Quyền dưới dạng thẻ (Card) Grid. Mỗi nhóm hiển thị chi tiết tên, mô tả, danh sách phân hệ được phép/không được phép, số lượng thành viên thuộc nhóm.
- **Thêm Nhóm**: Quản trị viên có thể tạo một nhóm quyền mới bằng cách nhập tên, mô tả và tích chọn các phân hệ được phép truy cập.
- **Sửa Nhóm**: Quản trị viên cập nhật tên, mô tả, quyền phân hệ của nhóm hiện có.
- **Xóa Nhóm**: Quản trị viên xóa nhóm quyền (Cần kiểm tra có thành viên nào đang thuộc nhóm không trước khi xóa).
- **Danh sách phân hệ cố định**: Có 11 module chính: dashboard, phathanh, thuhoi, trathuong, ketoan, thamdinh, daily, baocao, hethong, nhatky, congkhach.

## 2. Yêu cầu phi chức năng
- **Giao diện**: Dạng Card trực quan, sử dụng màu sắc ngẫu nhiên/cố định để phân biệt các nhóm. Trạng thái phân hệ (có quyền/không quyền) phải hiển thị khác biệt rõ ràng (có quyền = nổi bật, không quyền = gạch ngang mờ).
- **Trải nghiệm**: Form Thêm/Sửa mở dưới dạng Modal.

## 3. Quy tắc nghiệp vụ
- **Ràng buộc xóa**: Không được xóa nhóm quyền nếu đang có người dùng (User) thuộc nhóm đó (MemberCount > 0).
- **Bắt buộc**: Tên nhóm không được để trống và không được trùng lặp.