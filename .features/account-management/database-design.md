# Thiết kế Cơ sở dữ liệu - Quản trị Tài khoản

*(Tính năng Account Management sử dụng bảng `Users` chung hệ thống)*

## Bảng: `users`

| Tên cột | Kiểu dữ liệu | Ràng buộc | Mô tả |
| :--- | :--- | :--- | :--- |
| `id` | VARCHAR(50) / UUID | PRIMARY KEY | Mã tài khoản (VD: U001) |
| `full_name` | NVARCHAR(100) | NOT NULL | Họ và tên hiển thị |
| `email` | VARCHAR(100) | NOT NULL, UNIQUE | Email dùng để đăng nhập |
| `phone_number` | VARCHAR(20) | NULL | Số điện thoại liên hệ |
| `department` | NVARCHAR(100) | NULL | Phòng ban trực thuộc |
| `role_id` | VARCHAR(50) | FOREIGN KEY | Liên kết tới bảng `roles` (Vai trò/Nhóm quyền) |
| `status` | VARCHAR(20) | DEFAULT 'ACTIVE' | Trạng thái truy cập ('ACTIVE', 'LOCKED') |
| `avatar_url` | VARCHAR(255) | NULL | Đường dẫn URL lưu trữ file ảnh đại diện |
| `last_login_at` | TIMESTAMP | NULL | Thời điểm đăng nhập thành công gần nhất |
| `created_at` | TIMESTAMP | DEFAULT CURRENT_TIMESTAMP | Thời gian khởi tạo tài khoản |
| `updated_at` | TIMESTAMP | DEFAULT CURRENT_TIMESTAMP ON UPDATE | Thời gian cập nhật gần nhất |

## Mối quan hệ (Relationships)
- **Users - Roles**: 1 - N (Nhiều User thuộc 1 Role). `users.role_id` trỏ tới `roles.id`. Khi truy vấn danh sách, JOIN bảng `roles` để lấy tên Vai trò (Role Name) hiển thị thay vì chỉ hiển thị ID.

## Ràng buộc đặc biệt (Constraints)
- Index: Unique index trên cột `email`.