# Thiết kế Cơ sở dữ liệu - Quản trị Người dùng

## Bảng: `users`

| Tên cột | Kiểu dữ liệu | Ràng buộc | Mô tả |
| :--- | :--- | :--- | :--- |
| `id` | VARCHAR(50) / UUID | PRIMARY KEY | Mã tài khoản (VD: U001) |
| `full_name` | VARCHAR(100) | NOT NULL | Họ và tên |
| `email` | VARCHAR(100) | NOT NULL, UNIQUE | Email đăng nhập |
| `phone_number` | VARCHAR(20) | NULL | Số điện thoại |
| `department` | VARCHAR(100) | NULL | Phòng ban |
| `role` | VARCHAR(50) | NULL | Nhóm quyền (Vai trò) |
| `status` | VARCHAR(20) | DEFAULT 'ACTIVE' | Trạng thái ('ACTIVE', 'LOCKED') |
| `avatar_url` | VARCHAR(255) | NULL | Đường dẫn ảnh đại diện |
| `last_login_at` | TIMESTAMP | NULL | Thời gian đăng nhập cuối |
| `created_at` | TIMESTAMP | DEFAULT CURRENT_TIMESTAMP | Thời gian tạo |
| `updated_at` | TIMESTAMP | DEFAULT CURRENT_TIMESTAMP ON UPDATE | Thời gian cập nhật cuối |

### Enum / Hằng số tham khảo
**Phòng ban (`department`)**:
- Ban Giám Đốc
- Phòng Tài vụ
- Phòng Kế hoạch Phát hành
- Phòng Trả thưởng
- Phòng Thanh Tra
- Chi nhánh

**Vai trò (`role`)**:
- Admin
- Nhân viên Kế toán
- Nhân viên Thẩm định
- Chuyên viên Phát hành
- Thủ kho vé
- Giám sát viên