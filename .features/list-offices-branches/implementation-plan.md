# Kế hoạch triển khai - Danh mục Phòng ban / Chi nhánh

## Giai đoạn 1: Database & Models (Backend)
1. **Tạo Model `Office`**: Định nghĩa các trường `Id`, `Code`, `Name`, `Type`, `ManagerId`, `Status`.
2. **Cập nhật Model `User`**: Xóa thuộc tính `Department` (string), thêm `OfficeId` làm Khóa ngoại trỏ đến bảng `Offices`. (Lưu ý: Migration này sẽ làm mất dữ liệu Department cũ, cần chú ý nếu có data quan trọng).
3. **Cập nhật `AppDbContext`**: Thiết lập quan hệ 1-N giữa `Office` và `User`. Seed data mặc định (VD: BGD, PTV).
4. Chạy EF Migration.

## Giai đoạn 2: API Endpoints (Backend)
1. Tạo `OfficeDto`, `CreateOfficeDto`, `UpdateOfficeDto`.
2. Cập nhật `UserDto` và `UsersController` để trả về `OfficeName` thay vì text cũ.
3. Tạo `OfficesController`:
   - `GET /api/offices`: Kèm `.Include(o => o.Users)` để Count ra `EmployeeCount`.
   - `POST /api/offices`: Logic check trùng `Code`.
   - `PUT /api/offices/{id}`: Không update field `Code`.
   - `DELETE /api/offices/{id}`: Logic check `_context.Users.Any(u => u.OfficeId == id)`. Trả về `BadRequest` nếu có.

## Giai đoạn 3: Tích hợp Frontend (UI)
1. Sửa `list.html` để Fetch data từ `/api/offices` render bảng.
2. Xử lý Logic Form Submit Thêm và Sửa trên JS.
3. Sửa Form Thêm User (`create.html` bên module User): Cập nhật Select box Phòng ban để gọi data từ `/api/offices` động thay vì danh sách HTML cứng.