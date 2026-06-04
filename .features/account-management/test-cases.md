# Test Cases - Quản trị Tài khoản

## 1. Màn hình danh sách
| ID | Mô tả Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-01 | Hiển thị danh sách | Mở module Quản trị Tài khoản | Hiển thị bảng danh sách, avatar mặc định, tổng số tài khoản đúng thực tế CSDL. |
| TC-02 | Nhãn tài khoản bản thân | Kiểm tra tài khoản đang login | Có hiển thị huy hiệu "Bạn" nhỏ ở cạnh tên. |

## 2. Thêm mới tài khoản
| ID | Mô tả Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-03 | Thêm thành công | Bấm "Thêm", nhập đủ Tên, Email, Role. Bấm Lưu. | Modal đóng. Tài khoản mới hiển thị trên bảng (Trạng thái Active). |
| TC-04 | Bỏ trống thông tin | Để trống ô Họ tên hoặc Email, bấm Lưu. | UI báo lỗi Require, không gọi API. |
| TC-05 | Lỗi trùng Email | Thêm 1 tài khoản với Email đã tồn tại. | Gọi API, báo lỗi "Email đã tồn tại" trên Toast. |

## 3. Sửa thông tin
| ID | Mô tả Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-06 | Load form sửa | Bấm nút Sửa trên 1 dòng. | Modal hiện lên, các trường điền đúng thông tin cũ. |
| TC-07 | Sửa thành công | Đổi tên, SĐT và bấm Lưu. | Tên mới được cập nhật lập tức vào bảng. |

## 4. Khóa/Mở Khóa
| ID | Mô tả Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-08 | Khóa tài khoản | Bấm nút Khóa (Màu đỏ) trên tài khoản đang "Hoạt động". | Nút đổi thành Mở khóa (Xanh). Trạng thái đổi thành "Bị khóa" màu đỏ/cam. |
| TC-09 | Mở khóa tài khoản | Bấm nút Mở khóa trên tài khoản "Bị khóa". | Trạng thái chuyển lại "Hoạt động". |

## 5. Xóa tài khoản
| ID | Mô tả Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-10 | Xóa thành công | Bấm nút Xóa (Thùng rác), Xác nhận. | Dòng tài khoản biến mất. Số tổng cập nhật giảm đi 1. |
| TC-11 | Xóa bản thân | Thử tìm nút Xóa trên dòng có nhãn "Bạn". | Không có nút Xóa / Hoặc API chặn báo lỗi. |

## 6. Avatar
| ID | Mô tả Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-12 | Cập nhật Avatar | Bấm nút camera nhỏ ở ảnh, chọn file PNG/JPG. | Upload thành công, ảnh đại diện thay đổi mà không cần reload trang. |