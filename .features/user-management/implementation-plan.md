"# Kế hoạch triển khai - Quản trị Người dùng

## Giai đoạn 1: Cơ sở dữ liệu (Database)
1. **Tạo bảng `users`**: Dựa trên `database-design.md`. Chạy script SQL hoặc Migration.
2. **Seed dữ liệu mẫu**: Thêm tài khoản admin mặc định để kiểm thử.

## Giai đoạn 2: Phát triển Backend API
1. **Cấu hình Model**: Tạo model `User`.
2. **Xây dựng Controller & Route**:
   - `GET /api/users` (Lấy danh sách)
   - `POST /api/users` (Thêm mới)
   - `PUT /api/users/{id}` (Cập nhật)
   - `DELETE /api/users/{id}` (Xóa)
   - `PATCH /api/users/{id}/status` (Khóa/Mở)
   - `POST /api/users/{id}/avatar` (Upload ảnh)
3. **Thêm Validation**: Bắt lỗi dữ liệu đầu vào (email hợp lệ, field bắt buộc).

## Giai đoạn 3: Tích hợp Frontend (UI)
1. **Cập nhật danh sách (Read)**: Gọi API GET, render dữ liệu vào bảng HTML (`list.html`). Thay thế dữ liệu tĩnh.
2. **Xử lý Form Thêm/Sửa (Create/Update)**: 
   - Gắn sự kiện submit form.
   - Gọi API POST/PUT. 
   - Đóng Modal và tải lại danh sách khi thành công.
3. **Xử lý Xóa/Khóa (Delete/Status)**:
   - Gắn sự kiện cho nút Thao tác.
   - Gọi API DELETE/PATCH. Hiển thị xác nhận (Confirm) trước khi xóa.
4. **Xử lý Upload Ảnh (Avatar)**: Tích hợp upload file multipart.

## Giai đoạn 4: Kiểm thử & Hoàn thiện
1. **Unit Test API**: Kiểm tra các HTTP status code, response.
2. **Kiểm thử giao diện (E2E)**: Đảm bảo Modal đóng mở đúng, thông báo lỗi (Toast/Alert) hiển thị khi API lỗi.
3. **Kiểm tra phân quyền**: Đảm bảo user bị khóa không đăng nhập được."