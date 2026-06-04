# Thiết kế API - Quản trị Tài khoản

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
      "role_id": "G001",
      "role_name": "Admin (Giám đốc)",
      "status": "ACTIVE",
      "avatar_url": null,
      "last_login_at": "2026-03-18T10:00:00Z"
    }
  ]
}
```

## 2. Tạo tài khoản mới
- **URL**: `/api/users`
- **Method**: `POST`
- **Request Body**:
```json
{
  "full_name": "Trần Kế Toán",
  "email": "ketoan@xsktd.vn",
  "department": "Phòng Tài vụ",
  "role_id": "G002"
}
```
- **Response**: `201 Created` (Trả về dữ liệu user vừa tạo)

## 3. Cập nhật thông tin tài khoản
- **URL**: `/api/users/{id}`
- **Method**: `PUT`
- **Request Body**:
```json
{
  "full_name": "Trần Kế Toán Mới",
  "email": "ketoan@xsktd.vn",
  "department": "Phòng Tài vụ",
  "phone_number": "0987654321"
}
```
- **Response**: `200 OK`

## 4. Xóa tài khoản
- **URL**: `/api/users/{id}`
- **Method**: `DELETE`
- **Response**: `200 OK`

## 5. Cập nhật trạng thái (Khóa/Mở khóa)
- **URL**: `/api/users/{id}/status`
- **Method**: `PATCH`
- **Request Body**:
```json
{
  "status": "LOCKED" // hoặc "ACTIVE"
}
```
- **Response**: `200 OK`

## 6. Đổi ảnh đại diện
- **URL**: `/api/users/{id}/avatar`
- **Method**: `POST`
- **Content-Type**: `multipart/form-data`
- **Payload**: `avatar` (File)
- **Response**: `200 OK`
```json
{
  "success": true,
  "avatar_url": "/uploads/avatars/U002.jpg"
}
```