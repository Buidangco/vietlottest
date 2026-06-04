# Yêu cầu phân tích - Danh mục Phòng ban / Chi nhánh

## 1. Màn hình (Screens)
- Danh sách Phòng ban / Chi nhánh (`list.html`)
- Modal Thêm đơn vị mới (`create.html`)
- Modal Sửa thông tin đơn vị (`edit.html`)

## 2. Thao tác người dùng (User Actions)
- Xem danh sách Đơn vị (Phòng ban/Chi nhánh).
- Thêm Đơn vị mới: Nhập mã đơn vị, chọn phân loại, nhập tên và chọn trưởng đơn vị.
- Sửa thông tin Đơn vị: Thay đổi tên, phân loại, trưởng đơn vị, trạng thái (Không cho phép sửa Mã đơn vị).
- Xóa Đơn vị: Không thể xóa nếu đơn vị đang có nhân sự.

## 3. Biểu mẫu (Forms)
### Form Thêm Đơn Vị (`modal-them-donvi`)
- **Mã đơn vị** (Text, Bắt buộc, VD: BGD, CN_HCM...)
- **Phân loại** (Select: Phòng ban / Chi nhánh)
- **Tên đơn vị** (Text, Bắt buộc)
- **Trưởng đơn vị** (Select: Liệt kê User hiện có)

### Form Sửa Đơn Vị (`modal-sua-donvi`)
- **ID Đơn vị** (Hidden)
- **Mã đơn vị** (Text, Disabled - không được sửa)
- **Phân loại** (Select: Phòng ban / Chi nhánh)
- **Tên đơn vị** (Text, Bắt buộc)
- **Trưởng đơn vị** (Select: Liệt kê User hiện có)
- **Trạng thái** (Select: Hoạt động / Ngừng hoạt động)

## 4. Bảng biểu (Tables)
### Bảng Danh sách Đơn vị
- Cột `MÃ ĐƠN VỊ` (BGD, PTV, PKH, ...)
- Cột `TÊN ĐƠN VỊ` (Ban Giám Đốc, Phòng Tài vụ, ...)
- Cột `PHÂN LOẠI` (Phòng ban / Chi nhánh dạng badge)
- Cột `TRƯỞNG ĐƠN VỊ` (Tên người phụ trách)
- Cột `QUY MÔ` (Số lượng nhân sự đang trực thuộc)
- Cột `TRẠNG THÁI` (Hoạt động)
- Cột `THAO TÁC` (Nút Sửa, Xóa)

## 5. Bộ lọc (Filters)
- Chưa có thiết kế bộ lọc trên UI, có thể mở rộng (lọc theo Loại, Trạng thái).

## 6. Thực thể nghiệp vụ (Business Entities)
### Đơn vị (Office / Department)
- `Id` (Khóa chính)
- `Code` (Mã đơn vị: BGD, PTV... unique)
- `Name` (Tên đơn vị)
- `Type` (Phân loại: 'DEPARTMENT' / 'BRANCH')
- `ManagerId` (Trưởng đơn vị - ForeignKey tới bảng `Users`)
- `Status` (Hoạt động / Ngừng hoạt động)
- *(Quy mô nhân sự lấy từ Count(`Users.DepartmentId`))*