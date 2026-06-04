# Thiết kế Cơ sở dữ liệu - Phòng ban / Chi nhánh

## Bảng: `offices` (Đơn vị)

| Tên cột | Kiểu dữ liệu | Ràng buộc | Mô tả |
| :--- | :--- | :--- | :--- |
| `id` | VARCHAR(50) / UUID | PRIMARY KEY | Mã ID nội bộ của hệ thống |
| `code` | VARCHAR(50) | NOT NULL, UNIQUE | Mã đơn vị (VD: BGD, PTV, CNHCM) |
| `name` | NVARCHAR(100) | NOT NULL | Tên phòng ban / chi nhánh |
| `type` | VARCHAR(50) | NOT NULL | Loại ('DEPARTMENT' / 'BRANCH') |
| `manager_id` | VARCHAR(50) | FOREIGN KEY | ID người dùng làm Trưởng đơn vị, trỏ tới bảng `users` |
| `status` | VARCHAR(20) | DEFAULT 'ACTIVE' | Trạng thái ('ACTIVE', 'INACTIVE') |
| `created_at` | TIMESTAMP | DEFAULT CURRENT_TIMESTAMP | Thời gian tạo |
| `updated_at` | TIMESTAMP | DEFAULT CURRENT_TIMESTAMP ON UPDATE | Thời gian cập nhật |

## Cập nhật Bảng `users`
- Thay đổi cột `department` (kiểu chuỗi văn bản thuần) thành `office_id` (Kiểu FK trỏ tới `offices.id`).
- Thiết lập quan hệ **1-N** giữa `offices` và `users`: Một Đơn vị có nhiều Nhân sự.
- Khi lấy thông tin `EmployeeCount` (Quy mô), hệ thống sẽ `COUNT` số bản ghi `users` có `office_id` tương ứng.