# Kế hoạch triển khai - Quản trị Tài khoản

*(Lưu ý: API và Model phần lớn đã được hoàn thành trong module `user-management`. Giai đoạn này chỉ cần cập nhật thêm logic Join Role và mapping DTO mới)*

## Giai đoạn 1: Model & DTOs
1. **Cập nhật UserDto**: Thêm `RoleName` vào Response của `UserDto` để Front-End có thể hiển thị Tên vai trò thay vì ID.

## Giai đoạn 2: API (Backend - `UsersController`)
1. **GET `/api/users`**: Thêm `.Include(u => u.Role)` vào truy vấn Entity Framework để lấy thông tin Tên Vai trò.
2. **Mapping DTO**: Map trường `user.Role.Name` vào `UserDto.RoleName` khi trả về Json.

## Giai đoạn 3: UI (Frontend HTML/JS)
1. **Hiển thị Danh sách**: Gọi API `/api/users`. Render HTML `<tr>` tương ứng.
2. **Avatar mặc định**: Xử lý fallback URL với thẻ `<img>` (`onerror="this.src='https://ui-avatars.com/api/?name=' + name"`).
3. **Binding Form Thêm/Sửa**: Gọi API `/api/roles` để lấy danh sách Vai trò đổ vào thẻ `<select id="nu-role">` thay vì hardcode.
4. **Event Listeners**: Gắn event cho các nút thao tác Sửa, Khóa/Mở khóa, Xóa, Đổi ảnh.

## Giai đoạn 4: Kiểm thử
- Chạy API Backend và kiểm tra postman/swagger.
- Kiểm tra logic chặn khóa/xóa chính mình.
- Xác nhận việc Join Role hiển thị đúng tên vai trò trên bảng thay vì ID.