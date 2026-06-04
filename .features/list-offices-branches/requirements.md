# Yêu cầu hệ thống - Danh mục Phòng ban / Chi nhánh

## 1. Yêu cầu chức năng (Functional Requirements)
- **Xem danh sách đơn vị**: Hiển thị bảng danh sách các phòng ban và chi nhánh. Thông tin gồm Mã đơn vị, Tên đơn vị, Phân loại, Trưởng đơn vị, Quy mô (số nhân sự), Trạng thái và Thao tác.
- **Thêm đơn vị mới**: Người quản trị có thể thêm mới một phòng ban hoặc chi nhánh bằng cách nhập đầy đủ: Mã (duy nhất), Tên, Phân loại, Trưởng đơn vị.
- **Sửa thông tin đơn vị**: Quản trị viên cập nhật thông tin đơn vị (Tên, Phân loại, Trưởng đơn vị, Trạng thái). Không được thay đổi Mã đơn vị sau khi tạo.
- **Xóa đơn vị**: Xóa một phòng ban hoặc chi nhánh khỏi hệ thống.

## 2. Yêu cầu phi chức năng (Non-functional Requirements)
- **Giao diện/Trải nghiệm (UI/UX)**:
  - Các thao tác Thêm, Sửa mở trực tiếp qua Modal form không reload trang.
  - Các loại badge trạng thái và phân loại (Phòng ban/Chi nhánh) cần có màu sắc nhận diện rõ ràng.
- **Ràng buộc dữ liệu**:
  - Mã đơn vị (Code) là duy nhất không phân biệt hoa thường và không chứa dấu cách, ký tự đặc biệt.
  - Báo lỗi rõ ràng bằng Toast/Alert khi trùng mã đơn vị.

## 3. Quy tắc nghiệp vụ (Business Rules)
- **Trưởng đơn vị**: Được lấy từ danh sách người dùng (User) hiện có trong hệ thống. Một User có thể làm trưởng đơn vị hoặc để trống (null).
- **Quy mô (Số nhân sự)**: Được tính tự động (Count) dựa trên số lượng người dùng (Users) được gán vào đơn vị đó.
- **Kiểm tra trước khi xóa**: Hệ thống KHÔNG cho phép xóa đơn vị nếu đơn vị đó đang có nhân sự (Quy mô > 0). Chỉ được xóa các đơn vị rỗng.