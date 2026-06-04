# Thiết kế Cơ sở dữ liệu - Nhóm Quyền

## Bảng: `roles` (Hoặc RoleGroups)

| Tên cột | Kiểu dữ liệu | Ràng buộc | Mô tả |
| :--- | :--- | :--- | :--- |
| `id` | VARCHAR(50) / UUID | PRIMARY KEY | Mã nhóm quyền (VD: G001) |
| `name` | VARCHAR(100) | NOT NULL, UNIQUE | Tên nhóm quyền |
| `description` | NVARCHAR(255) | NULL | Mô tả nhóm quyền |
| `color_code` | VARCHAR(10) | NULL | Mã màu HEX để hiển thị UI |
| `created_at` | TIMESTAMP | DEFAULT CURRENT_TIMESTAMP | Thời gian tạo |
| `updated_at` | TIMESTAMP | DEFAULT CURRENT_TIMESTAMP ON UPDATE | Thời gian cập nhật cuối |

## Bảng: `role_permissions`
*(Bảng quan hệ lưu danh sách phân hệ được phép của từng nhóm)*

| Tên cột | Kiểu dữ liệu | Ràng buộc | Mô tả |
| :--- | :--- | :--- | :--- |
| `role_id` | VARCHAR(50) | FOREIGN KEY (roles.id) | Mã nhóm quyền |
| `permission_code` | VARCHAR(50) | NOT NULL | Mã phân hệ (VD: 'dashboard', 'phathanh') |

*Ràng buộc: Khóa chính kép (role_id, permission_code).*

## Mở rộng Bảng `users` (Đã có)
- Bảng `users` cần khóa ngoại `role_id` trỏ tới bảng `roles` (thay thế trường `role` dạng text cũ) để JOIN tính tổng số thành viên (`MemberCount`).