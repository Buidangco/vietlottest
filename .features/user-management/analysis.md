# User Management UI Analysis

## 1. Screens
- List Users (`list.html`)
- Create User Modal (`create.html`)
- Edit User Modal (`edit.html`)
- Delete User (Implicit in `list.html`)

## 2. User Actions
- View users list
- Add new user (Opens modal)
- Edit user details (Opens modal)
- Delete user
- Lock/Unlock user status
- Change user avatar
- Assign roles/permissions (Opens permission form)
- View total user count

## 3. Forms
### Create User Form (`#form-them-user`)
Fields:
- Full Name (Text, required)
- Email (Email, required)
- Department (Select: Ban Giám Đốc, Phòng Tài vụ, Phòng KH Phát hành, Phòng Trả thưởng, Phòng Thanh tra, Chi nhánh)
- Role (Select: Admin, Nhân viên Kế toán, Nhân viên Thẩm định, Chuyên viên Phát hành, Thủ kho vé, Giám sát viên)

### Edit User Form
Fields:
- User ID (Hidden)
- Full Name (Text, required)
- Email (Email, required)
- Department (Select: Ban Giám Đốc, Phòng Tài vụ, Phòng KH Phát hành, Phòng Trả thưởng, Phòng Thanh tra, Chi nhánh)
- Phone Number (Tel, optional)

## 4. Tables
### Users Table
Columns:
- TÀI KHOẢN (Account info: Avatar, Name, Email, "Bạn" badge for current user)
- PHÒNG BAN (Department)
- VAI TRÒ (Role)
- TRẠNG THÁI (Status: Hoạt động / Bị khóa)
- ĐĂNG NHẬP CUỐI (Last Login)
- THAO TÁC (Actions: Edit, Permissions, Lock/Unlock, Delete)

## 5. Filters
None explicitly found in provided UI specs.

## 6. Business Entities
### User
Attributes:
- ID (e.g., U001)
- Name
- Email
- Phone Number
- Department
- Role
- Status (Active/Locked)
- Avatar URL
- Last Login Date