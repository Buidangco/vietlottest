# Test Cases - Danh mục Phòng ban / Chi nhánh

## 1. Màn hình danh sách
| ID | Mô tả Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-01 | Hiển thị danh sách | Vào màn hình "Phòng ban / Chi nhánh" | Bảng load đủ dữ liệu các đơn vị. Cột quy mô nhân sự tính chính xác. |
| TC-02 | Giao diện phân loại | Kiểm tra cột Phân loại | Huy hiệu "Chi nhánh" khác màu so với "Phòng ban". |

## 2. Thêm đơn vị
| ID | Mô tả Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-03 | Thêm thành công | Mở Modal Thêm, nhập Mã (duy nhất), Tên, chọn loại, trưởng phòng. Bấm Lưu. | Load lại bảng, Đơn vị mới xuất hiện, Quy mô = 0. |
| TC-04 | Trùng mã đơn vị | Mở Modal Thêm, nhập Mã đã có (VD: BGD). Bấm Lưu. | API trả lỗi, UI hiện thông báo lỗi "Mã đơn vị đã tồn tại". |

## 3. Sửa đơn vị
| ID | Mô tả Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-05 | Kiểm tra Form Sửa | Bấm Sửa trên 1 dòng đơn vị. | Modal điền sẵn thông tin cũ. Input Mã đơn vị bị làm mờ (disabled). |
| TC-06 | Đổi trạng thái | Chọn trạng thái "Ngừng hoạt động", bấm Lưu. | UI bảng cập nhật trạng thái mới. |

## 4. Xóa đơn vị
| ID | Mô tả Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-07 | Xóa đơn vị rỗng | Bấm Xóa một đơn vị có Quy mô = 0. | Xóa thành công, biến mất khỏi danh sách. |
| TC-08 | Chặn xóa đơn vị có người | Bấm Xóa một đơn vị có Quy mô > 0. | UI hiện Toast lỗi "Không thể xóa do đang có nhân sự" và không xóa CSDL. |