# Thiết kế API - Danh mục Phòng ban / Chi nhánh

## 1. Lấy danh sách đơn vị
- **URL**: `/api/offices`
- **Method**: `GET`
- **Response**: `200 OK`
```json
{
  "success": true,
  "data": [
    {
      "id": "O001",
      "code": "BGD",
      "name": "Ban Giám Đốc",
      "type": "DEPARTMENT",
      "manager_id": "U001",
      "manager_name": "Nguyễn Văn A",
      "status": "ACTIVE",
      "employee_count": 3
    }
  ]
}
```

## 2. Thêm đơn vị mới
- **URL**: `/api/offices`
- **Method**: `POST`
- **Request Body**:
```json
{
  "code": "PTV",
  "name": "Phòng Tài vụ",
  "type": "DEPARTMENT",
  "manager_id": "U002"
}
```
- **Response**: `201 Created` / `400 Bad Request` (Nếu trùng Code)

## 3. Cập nhật thông tin đơn vị
- **URL**: `/api/offices/{id}`
- **Method**: `PUT`
- **Request Body**:
```json
{
  "name": "Phòng Tài vụ (Mới)",
  "type": "DEPARTMENT",
  "manager_id": "U002",
  "status": "INACTIVE"
}
```
*(Lưu ý: Không truyền `code` để cập nhật)*
- **Response**: `200 OK`

## 4. Xóa đơn vị
- **URL**: `/api/offices/{id}`
- **Method**: `DELETE`
- **Response**:
  - `200 OK`: Xóa thành công.
  - `400 Bad Request`: `{"success": false, "message": "Không thể xóa do đang có nhân sự"}`