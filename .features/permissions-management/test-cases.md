# Test Cases - Quản trị Nhóm Quyền

## 1. Xem danh sách
| ID | Tên Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-01 | Xem danh sách nhóm | Truy cập màn hình "Quản trị Nhóm Quyền" | Hiển thị tất cả nhóm, tổng số quyền (X/11) và member count chính xác. |
| TC-02 | UI Badge phân hệ | Kiểm tra 1 card | Phân hệ có quyền sáng màu, không có quyền xám/gạch ngang. |

## 2. Thêm nhóm
| ID | Tên Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-03 | Thêm thành công | Bấm "Thêm", nhập tên, chọn 3 quyền, lưu. | Load lại list có nhóm mới, member count = 0, quyền lưu đúng. |
| TC-04 | Lỗi trùng tên | Thêm nhóm có tên đã tồn tại | Báo lỗi "Tên nhóm đã tồn tại" |

## 3. Sửa nhóm
| ID | Tên Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-05 | Hiển thị form sửa | Bấm nút "Sửa" | Modal hiện lên, tích sẵn đúng các quyền hiện tại. |
| TC-06 | Lưu thay đổi quyền | Bỏ chọn 1 quyền, thêm 1 quyền mới, lưu. | Giao diện Card cập nhật badge quyền ngay lập tức. |

## 4. Xóa nhóm
| ID | Tên Test Case | Các bước thực hiện | Kết quả mong đợi |
|---|---|---|---|
| TC-07 | Xóa nhóm trống | Xóa nhóm có MemberCount = 0 | Xóa thành công, mất khỏi giao diện. |
| TC-08 | Chặn xóa nhóm có user | Xóa nhóm có MemberCount > 0 | API trả lỗi, UI hiện Toast báo không thể xóa. |