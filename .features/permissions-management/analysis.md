# Yêu cầu phân tích - Quản trị Nhóm Quyền

## 1. Màn hình (Screens)
- Danh sách Nhóm Quyền (`list.html`)
- Thêm Nhóm Quyền (Modal trong `create.html`)
- Sửa Nhóm Quyền (Modal trong `edit.html`)
- Xóa Nhóm Quyền (Inline trong `list.html`)

## 2. Thao tác người dùng (User Actions)
- Xem danh sách nhóm quyền (hiển thị dạng card/lưới).
- Xem chi tiết từng nhóm: Tên, Mô tả, Số lượng phân hệ được phép, Danh sách phân hệ được phép (badge nổi bật) và không được phép (gạch ngang, mờ).
- Xem tổng số thành viên thuộc nhóm.
- Thêm nhóm mới: Nhập Tên, Mô tả và check chọn phân hệ.
- Sửa nhóm: Chỉnh sửa Tên, Mô tả, check/uncheck các phân hệ.
- Xóa nhóm: Bấm icon thùng rác.

## 3. Biểu mẫu (Forms)
### Form Thêm/Sửa Nhóm Quyền (`#modal-edit-nhom`)
- **ID Nhóm** (Hidden)
- **Tên nhóm** (Text, Required)
- **Mô tả** (Text, Tùy chọn)
- **Phân hệ được phép truy cập** (Checkbox List, 11 lựa chọn):
  - Trang tổng quan (dashboard)
  - Quản lý Phát hành (phathanh)
  - Thu hồi vé (thuhoi)
  - Tra thưởng (trathuong)
  - Kế toán Chi trả (ketoan)
  - Thẩm định HS (thamdinh)
  - Quản lý Đại lý (daily)
  - Báo cáo (baocao)
  - Quản trị hệ thống (hethong)
  - Nhật ký Audit (nhatky)
  - Cổng Khách hàng (congkhach)

## 4. Bảng biểu (Tables)
- Không dùng `<table>` truyền thống. Hiển thị dạng `CSS Grid` với các `Card`.
- Mỗi Card chứa:
  - Header: Icon màu sắc riêng, Tên nhóm, Mô tả ngắn, Nút Sửa/Xóa.
  - Body: Thống kê số phân hệ (X/11), Danh sách thẻ badge các phân hệ (Có quyền = sáng màu, Không quyền = màu xám gạch ngang), Thống kê số thành viên.

## 5. Bộ lọc (Filters)
- Không có bộ lọc hiển thị rõ ràng trong giao diện HTML được cung cấp.

## 6. Thực thể nghiệp vụ (Business Entities)
### Nhóm Quyền (Role/Permission Group)
- `Id` (VD: G001)
- `Name` (Tên nhóm)
- `Description` (Mô tả)
- `Permissions` (Danh sách mã phân hệ được phép: mảng string hoặc quan hệ n-n)
- `Color` (Màu đại diện trên UI - suy luận từ các màu: #7c3aed, #1d4ed8, #0369a1, #047857, #b45309, #475569)
- `MemberCount` (Số lượng thành viên liên kết)