# Yêu cầu phân tích - Quản trị Tài khoản (Account Management)

## 1. Màn hình (Screens)
- Danh sách Tài khoản (`list.html`)
- Thêm Tài khoản (Modal trong `create.html` - dựa theo cấu trúc user-management vì account-management dùng chung spec ui với user-management)
- Sửa Tài khoản (Modal trong `edit.html`)

## 2. Thao tác người dùng (User Actions)
- Xem danh sách tài khoản: Hiển thị avatar, thông tin người dùng, phòng ban, vai trò, trạng thái, lần đăng nhập cuối.
- Nhận diện tài khoản bản thân (có huy hiệu "Bạn").
- Đổi ảnh đại diện (Bấm icon camera nhỏ ở góc avatar).
- Thêm tài khoản mới.
- Sửa tài khoản (Cập nhật thông tin).
- Khóa/Mở khóa tài khoản: Đổi trạng thái truy cập.
- Xóa tài khoản: Loại bỏ khỏi hệ thống.
- Phân quyền nhanh: Bấm icon khiên (user-shield) để phân vai trò (role) riêng cho user đó.

## 3. Biểu mẫu (Forms)
- **Form Thêm/Sửa Tài khoản**: (Suy luận từ UI tương tự) Bao gồm Tên, Email, SĐT, Phòng ban, Role, Trạng thái.

## 4. Bảng biểu (Tables)
### Bảng Danh sách Tài khoản
- Cột `TÀI KHOẢN`: Avatar, Tên in đậm, Huy hiệu "Bạn", Email nhạt màu.
- Cột `PHÒNG BAN`: Tên phòng ban.
- Cột `VAI TRÒ`: Tên Nhóm quyền / Vai trò dạng badge.
- Cột `TRẠNG THÁI`: Hoạt động (Xanh) hoặc Bị khóa (Đỏ/Cam).
- Cột `ĐĂNG NHẬP CUỐI`: Ngày tháng.
- Cột `THAO TÁC`: Sửa, Phân quyền, Khóa/Mở khóa, Xóa.

## 5. Bộ lọc (Filters)
- Hiện tại chưa có bộ lọc UI cụ thể. Có thể tìm kiếm theo tên/email, lọc theo trạng thái/phòng ban nếu cần ở API.

## 6. Thực thể nghiệp vụ (Business Entities)
### Tài khoản (Account / User)
- `Id`
- `FullName`
- `Email`
- `Department`
- `RoleId` (Vai trò)
- `Status` (ACTIVE/LOCKED)
- `AvatarUrl`
- `LastLoginAt`