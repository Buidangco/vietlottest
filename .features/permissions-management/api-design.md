# Thiết kế API - Quản trị Nhóm Quyền

## 1. Lấy danh sách nhóm quyền
- **URL**: `/api/roles`
- **Method**: `GET`
- **Response**: `200 OK`
```json
{
  "success": true,
  "data": [
    {
      "id": "G001",
      "name": "Admin (Giám đốc)",
      "description": "Toàn quyền hệ thống",
      "color_code": "#7c3aed",
      "permissions": ["dashboard", "phathanh", "thuhoi", "trathuong", "ketoan", "thamdinh", "daily", "baocao", "hethong", "nhatky", "congkhach"],
      "member_count": 1
    }
  ]
}
```

## 2. Thêm nhóm quyền mới
- **URL**: `/api/roles`
- **Method**: `POST`
- **Request Body**:
```json
{
  "name": "Kế toán viên",
  "description": "Chỉ xem báo cáo kế toán",
  "color_code": "#1d4ed8",
  "permissions": ["dashboard", "ketoan", "baocao"]
}
```
- **Response**: `201 Created`

## 3. Cập nhật nhóm quyền
- **URL**: `/api/roles/{id}`
- **Method**: `PUT`
- **Request Body**:
```json
{
  "name": "Kế toán viên (Sửa)",
  "description": "Xem báo cáo và chi trả",
  "permissions": ["dashboard", "ketoan", "baocao", "trathuong"]
}
```
- **Response**: `200 OK`

## 4. Xóa nhóm quyền
- **URL**: `/api/roles/{id}`
- **Method**: `DELETE`
- **Response**:
  - `200 OK`: Xóa thành công.
  - `400 BadRequest`: Nếu nhóm đang có người dùng (`{ "success": false, "message": "Không thể xóa nhóm đang có thành viên." }`).