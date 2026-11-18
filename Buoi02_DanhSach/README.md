# Buổi 02 – Mảng và Danh sách liên kết
Họ tên: Bùi Thị Thùy Trang - MSV: 12425083

## Bài đã làm
- **Bài tập chương 4** Bài 1, Bài 2, Bài 3, Bài 4, Bài 5
- **Bài tập tự thực hành cuối sách:** Bài 7, Bài 8, Bài 9, Bài 10, Bài 11, Bài 12, Bài 13, Bài 14, Bài 15, Bài 16, Bài 17, Bài 18

## Cách chạy
dotnet run --project Buoi02_DanhSach

## Kết quả chạy

=======BÀI TẬP CHƯƠNG 4: MẢNG VÀ DANH SÁCH LIÊN KẾT=======
BÀI TẬP 1: MẢNG SỐ NGUYÊN DƯƠNG & CHÈN PHẦN TỬ
Nhập số phần tử n: 4
Nhập a[1]: 10
Nhập a[2]: 20
Nhập a[3]: 30
Nhập a[4]: 40
Danh sách vừa nhập: 10 20 30 40
Nhập giá trị x cần chèn: 90
Nhập vị trí k cần chèn (1 -> 5): 2
Dãy số sau khi chèn 90 vào vị trí 2: 10 90 20 30 40

BÀI TẬP 2: QUẢN LÝ DANH SÁCH NHÂN VIÊN
Danh sách nhân viên ban đầu:
 NV01  | Nhữ Hà Thanh      | 1995 | Kinh doanh  | LCB: 8,000,000 | Thưởng: 1,500,000 | Thực lĩnh: 9,500,000
 NV02  | Trần Thị Bình     | 1998 | Kế toán     | LCB: 7,000,000 | Thưởng: 1,000,000 | Thực lĩnh: 8,000,000
 NV03  | Lê Hoàng Cường    | 1992 | Kinh doanh  | LCB: 9,500,000 | Thưởng: 2,000,000 | Thực lĩnh: 11,500,000
 NV04  | Phạm Minh Dung    | 1999 | Kỹ thuật    | LCB: 7,000,000 | Thưởng: 1,200,000 | Thực lĩnh: 8,200,000
 NV05  | Hoàng Hải Yến     | 1996 | Kỹ thuật    | LCB: 8,500,000 | Thưởng:  800,000 | Thực lĩnh: 9,300,000

a.Tổng thực lĩnh tháng của công ty: 46,500,000 VNĐ

b.Nhân viên có lương cơ bản thấp nhất (7,000,000 VNĐ):
 - NV02 | Trần Thị Bình | Phòng: Kế toán
 - NV04 | Phạm Minh Dung | Phòng: Kỹ thuật

c. Số lượng nhân viên có thưởng >= 1.200.000đ: 3

d. Danh sách tăng dần theo phòng ban, giảm dần theo Mã NV:
 NV02  | Trần Thị Bình     | 1998 | Kế toán     | LCB: 7,000,000 | Thưởng: 1,000,000 | Thực lĩnh: 8,000,000
 NV03  | Lê Hoàng Cường    | 1992 | Kinh doanh  | LCB: 9,500,000 | Thưởng: 2,000,000 | Thực lĩnh: 11,500,000
 NV01  | Nhữ Hà Thanh      | 1995 | Kinh doanh  | LCB: 8,000,000 | Thưởng: 1,500,000 | Thực lĩnh: 9,500,000
 NV05  | Hoàng Hải Yến     | 1996 | Kỹ thuật    | LCB: 8,500,000 | Thưởng:  800,000 | Thực lĩnh: 9,300,000
 NV04  | Phạm Minh Dung    | 1999 | Kỹ thuật    | LCB: 7,000,000 | Thưởng: 1,200,000 | Thực lĩnh: 8,200,000

e. Danh sách sau khi cập nhật tăng lương cơ bản lên 5%:
 NV02  | Trần Thị Bình     | 1998 | Kế toán     | LCB: 7,350,000 | Thưởng: 1,000,000 | Thực lĩnh: 8,350,000
 NV03  | Lê Hoàng Cường    | 1992 | Kinh doanh  | LCB: 9,975,000 | Thưởng: 2,000,000 | Thực lĩnh: 11,975,000
 NV01  | Nhữ Hà Thanh      | 1995 | Kinh doanh  | LCB: 8,400,000 | Thưởng: 1,500,000 | Thực lĩnh: 9,900,000
 NV05  | Hoàng Hải Yến     | 1996 | Kỹ thuật    | LCB: 8,925,000 | Thưởng:  800,000 | Thực lĩnh: 9,725,000
 NV04  | Phạm Minh Dung    | 1999 | Kỹ thuật    | LCB: 7,350,000 | Thưởng: 1,200,000 | Thực lĩnh: 8,550,000


BÀI TẬP 3: MA TRẬN VUÔNG CẤP N
Ma trận vuông cấp n =4:
   2   5   8  10
  -3   4   7  12
   6   1   9  15
  11  -2   3  20

a. Tổng tất cả các phần tửu của ma trận: 108

b. Gía trị dương nhỏ nhất của ma trận: 1

c. Tổng các phần tử trên đường chéo phụ: 29
d. Đường chéo chính (2,4,9,20) có tăng dần không? Có

BÀI TẬP 4: DANH SÁCH LIÊN KẾT ĐƠN (pHead)
Danh sách pHead ban đầu: 12->5->8->5->20->3->5->NULL
a. Số lượng phần tử bằng 5 trong danh sách : 3
b. Phần tử dương nhỏ nhất trong danh sách: 3
c. Danh sách sau khi xóa số 5 đầu tiên: 12->8->5->20->3->5->NULL


BÀI TẬP 5: DANH SÁCH LIÊN KẾT ĐƠN
Danh sách l ban đầu: -7->0->11->4->-2->7->0->15->2->NULL
a. Phần tử lớn nhất danh sách: 15
b. Tổng các phần tử trong danh sách : 30
c. Số lượng số nguyên tố trong danh sách: 3
d. Số âm: 2 | Số dương: 5 | Số bằng 0: 2
e. Số lượng phần tử bằng 0: 2
f. Phần tử dương nhỏ nhất trong danh sách: 2

=======BÀI TẬP TỰ THỰC HÀNH: MẢNG VÀ DANH SÁCH LIÊN KẾT=======
BÀI 7: QUẢN LÝ NHIỆT ĐỘ
Nhiệt độ cao nhất 32.4 độ C (Ngày 3) | Thấp nhất: 7 độ C (Ngày 7) | Trung bình: 29.34 độ C

BÀI 8: THỐNG KÊ TẦN SUẤT TỪ
Văn bản: "Cấu trúc dữ liệu và giải thuật"
[cấu: 1] [trúc: 1] [dữ: 1] [liệu: 1] [và: 1] [giải: 1] [thuật: 1]

BÀI 9: XỬ LÝ SỐ NGUYÊN (NGUYÊN TỐ, CHẴN, HOÀN HẢO
Dãy số: 2, 6, 7, 12, 28, 15, 17, 20
- Số nguyên tố: 2 7 17
- Số chẵn: 2 6 12 28 20
- Số hoàn hảo: 6 28

BÀI 10: IN MA TRẬN THEO THỨ TỰ XOẮN ỐC
Kết quả duyệt xoắn ốc: 1 2 3 4 8 12 11 10 9 5 6 7

Bài 11: Kiểm tra ma trận đơn vị và ma trận đối xứng
Ma trận đơn vị: False | Ma trận đối xứng: True

Bài 12: Game Minesweeper (Đếm mìn 8 hướng)
Bảng Minesweeper (* là mìn):
 1  *  1  0
 1  2  2  1
 1  2  *  1
 *  2  1  1


Bài 13: Đảo ngược danh sách liên kết đơn (3 con trỏ)
Ban đầu: 1->2->3->4->5->NULL
Sau khi đảo ngược: 5->4->3->2->1->NULL


Bài 14: Gộp hai danh sách đã sắp xếp
Danh sách sau khi gộp: 1->2->3->4->7->8->NULL


Bài 15: Phát hiện chu trình (Rùa và Thỏ)
Danh sách 2->3->4->5->6->2 có chu trình không? => True

Bài 16: Lịch sử duyệt web (Back/Forward)
Trang hiện tại: stackoverflow.com
Nhấn Back -> github.com
Nhấn Back -> google.com
Nhấn Forward -> github.com

Bài 17: Playlist nhạc (Next/Previous/Thêm/Xóa) =
Đang phát: Bài hát 1
Next -> Đang phát: Bài hát 2
Sau khi xóa Bài hát 2, chuyển sang: Bài hát 3

Bài 18: Hệ thống đặt hàng (Chuyển trạng thái)
Trạng thái ban đầu: Đơn hàng #DH01 [Chờ xử lý]
Cập nhật tiếp theo -> [Đang giao]
Cập nhật tiếp theo -> [Hoàn thành]