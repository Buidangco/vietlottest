# Test Cases - Quản trị Người dùng

## 1. Xem danh sách tài khoản
| ID | Tên Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-01 | Xem danh sách mặc định | Mở trang "Quản trị tài khoản" | Hiển thị danh sách, tổng số lượng, thông tin đúng với DB |
| TC-02 | Hiển thị avatar mặc định | Kiểm tra user chưa có ảnh đại diện | Avatar hiển thị chữ cái đầu của tên (ui-avatars) |
| TC-03 | Nhận diện tài khoản đăng nhập | Đăng nhập và xem danh sách | Có nhãn "Bạn" ở tài khoản đang đăng nhập |

## 2. Thêm mới tài khoản (Create)
| ID | Tên Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-04 | Thêm tài khoản thành công | 1. Bấm "Thêm Tài Khoản"<br>2. Nhập Tên, Email, chọn Phòng ban, Vai trò<br>3. Bấm "Tạo Tài Khoản" | Modal đóng, danh sách cập nhật user mới (trạng thái Hoạt động) |
| TC-05 | Bỏ trống trường bắt buộc | 1. Mở Modal Thêm<br>2. Bỏ trống Tên/Email<br>3. Bấm "Tạo" | Báo lỗi yêu cầu nhập đủ, không gọi API |
| TC-06 | Trùng Email | 1. Mở Modal Thêm<br>2. Nhập Email đã tồn tại<br>3. Bấm "Tạo" | API báo lỗi, hiển thị thông báo "Email đã tồn tại" |
| TC-07 | Đóng form thêm | Mở Modal Thêm, bấm "Hủy" hoặc "X" | Modal đóng, không lưu dữ liệu |

## 3. Sửa thông tin tài khoản (Update)
| ID | Tên Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-08 | Mở form sửa | Bấm nút "Sửa" trên 1 user | Modal mở, dữ liệu cũ tự động điền sẵn |
| TC-09 | Sửa thành công | 1. Đổi Tên/SĐT<br>2. Bấm "Lưu" | Modal đóng, danh sách hiển thị thông tin mới |

## 4. Xóa tài khoản (Delete)
| ID | Tên Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-10 | Xóa tài khoản | 1. Bấm nút "Xóa"<br>2. Bấm Xác nhận | Tài khoản bị xóa khỏi danh sách và DB |

## 5. Khóa / Mở khóa
| ID | Tên Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-11 | Khóa tài khoản | Bấm nút "Khóa" trên user đang "Hoạt động" | Trạng thái thành "Bị khóa", chặn đăng nhập |
| TC-12 | Mở khóa tài khoản | Bấm nút "Mở khóa" trên user "Bị khóa" | Trạng thái thành "Hoạt động", cho phép đăng nhập |

## 6. Đổi ảnh đại diện
| ID | Tên Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-13 | Đổi avatar thành công | 1. Bấm icon máy ảnh<br>2. Chọn file ảnh | Giao diện cập nhật ảnh mới ngay lập tức |