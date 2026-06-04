# Kế hoạch triển khai - Quản trị Nhóm Quyền

## Giai đoạn 1: Database & Model
1. Tạo model `Role` và `RolePermission`.
2. Bổ sung `RoleId` vào model `User` thay cho cột Role string cũ.
3. Tạo EF Migration và Update Database (Chạy seed data cho 11 phân hệ và các nhóm quyền mặc định).

## Giai đoạn 2: API (Backend)
1. Tạo DTOs: `RoleDto`, `CreateRoleDto`, `UpdateRoleDto`.
2. Tạo `RolesController`:
   - `GET`: Lấy Roles kèm `Include(Users)` để đếm member, và danh sách Permissions.
   - `POST`: Lưu Role và insert vào `RolePermissions`.
   - `PUT`: Xóa Permissions cũ, insert Permissions mới.
   - `DELETE`: Check `_context.Users.Any(u => u.RoleId == id)`. Nếu có, chặn xóa.

## Giai đoạn 3: Frontend (UI)
1. Gọi `GET /api/roles`, lặp qua data để render CSS Grid Card.
2. So sánh danh sách quyền trả về với mảng tĩnh 11 quyền để render class badge phù hợp (màu nổi hoặc gạch ngang).
3. Gắn event mở modal Form Thêm/Sửa.
4. Call API khi Submit và xử lý Alert báo lỗi (ví dụ khi xóa nhóm có người dùng).