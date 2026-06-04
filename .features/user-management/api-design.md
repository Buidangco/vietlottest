# Thiết kế API - Quản trị Người dùng

## 1. Lấy danh sách tài khoản
- **URL**: `/api/users`
- **Method**: `GET`
- **Response**: `200 OK`
```json
{
  "success": true,
  "total": 4,
  "data": [
    {
      "id": "U001",
      "full_name": "Nguyễn Quản Trị",
      "email": "admin@xsktd.vn",
      "department": "Ban Giám Đốc",
      "role": "Admin",
      "status": "ACTIVE",
      "avatar_url": null,
      "last_login_at": "2026-03-18T10:00:00Z"
    }
  ]
}
```

## 2. Thêm tài khoản
- **URL**: `/api/users`
- **Method**: `POST`
- **Request Body**:
```json
{
  "full_name": "Nguyễn Văn A",
  "email": "nva@xsktd.vn",
  "department": "Phòng Tài vụ",
  "role": "Nhân viên Kế toán"
}
```
- **Response**: `201 Created`

## 3. Cập nhật thông tin tài khoản
- **URL**: `/api/users/{id}`
- **Method**: `PUT`
- **Request Body**:
```json
{
  "full_name": "Nguyễn Văn A",
  "email": "nva@xsktd.vn",
  "department": "Phòng Tài vụ",
  "phone_number": "0901234567"
}
```
- **Response**: `200 OK`

## 4. Xóa tài khoản
- **URL**: `/api/users/{id}`
- **Method**: `DELETE`
- **Response**: `200 OK` / `204 No Content`

## 5. Cập nhật trạng thái (Khóa/Mở khóa)
- **URL**: `/api/users/{id}/status`
- **Method**: `PATCH`
- **Request Body**:
```json
{
  "status": "LOCKED" // Hoặc "ACTIVE"
}
```
- **Response**: `200 OK`

## 6. Cập nhật ảnh đại diện
- **URL**: `/api/users/{id}/avatar`
- **Method**: `POST`
- **Content-Type**: `multipart/form-data`
- **Request Body**: file ảnh (`avatar`)
- **Response**: `200 OK`
```json
{
  "success": true,
  "avatar_url": "/uploads/avatars/U001.jpg"
}
```