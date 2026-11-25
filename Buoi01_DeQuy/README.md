# Buổi 01 – Tổng hợp Bài tập chương 1,2,3
Họ tên: Bùi Thị Thùy Trang - MSV: 12425083

## Bài đã làm
- **chương 1: Tổng quan về cấu trúc dữ liệu và giải thuật:** Bài 1, 2, 3, 4, 5
- **Chương 2: Phân tích giải thuật:** Bài 1, 2, 3, 4, 5, 6
- **Chương 3 Đệ quy:** Bài 1, 2, 3, 4, 5, 6, 7, 8
- **Phần 4: Bài tập tự luyện đệ quy:** Bài Bài 1, 2, 3, 4, 5, 6, 7,

--
## Phần lý thuyết Chương 2: Phân tích giải thuật

### Bài 1: Tháp Hà Nội
- **Hệ thức truy hồi:** $T(n) = 2T(n-1) + 1$, với trường hợp cơ sở $T(1) = 1$.
- **Giải bằng phương pháp lặp:**
  $$T(n) = 2[2T(n-2) + 1] + 1 = 2^2T(n-2) + 2 + 1 = \dots = 2^{n-1}T(1) + 2^{n-2} + \dots + 2 + 1 = 2^n - 1$$
- **Kết luận độ phức tạp:** **$O(2^n)$**.

### Bài 2: Tìm kiếm nhị phân (Binary Search)
- **Hệ thức truy hồi:** $T(n) = T(n/2) + 1$, với trường hợp cơ sở $T(1) = 1$.
- **Giải bằng phương pháp lặp (đặt $n = 2^k \Rightarrow k = \log_2 n$):**
  $$T(n) = T(n/2) + 1 = T(n/4) + 2 = \dots = T(1) + k = 1 + \log_2 n$$
- **Kết luận độ phức tạp:** **$O(\log n)$**.

### 3. Bảng tổng hợp ký pháp tiệm cận (Bài 3, 4, 5, 6)

| Bài toán | Giải thuật 1 | Độ phức tạp GT1 | Giải thuật 2 | Độ phức tạp GT2 |
| :--- | :--- | :--- | :--- | :--- |
| **Bài 3: Số nguyên tố** | Duyệt $2 \to n-1$ | $O(n)$, $\Omega(1)$ | Duyệt $2 \to \sqrt{n}$ | $O(\sqrt{n})$, $\Omega(1)$ |
| **Bài 4: Số hoàn hảo** | Tìm ước $1 \to num-1$ | $\Theta(N^2)$ | Tìm ước $2 \to \sqrt{num}$ | $\Theta(N\sqrt{N})$ |
| **Bài 5: Fibonacci** | Đệ quy trực tiếp | $\Theta(2^n)$ | Vòng lặp | $\Theta(n)$ |
| **Bài 6: Sắp xếp dãy** | Bubble Sort | $O(n^2)$, $\Omega(n)$ | Selection Sort | $\Theta(n^2)$ |

---

## Cách chạy
dotnet run --project Buoi01_DeQuy.

## Kết quả chạy
CHƯƠNG 1: TỔNG QUAN VỀ CẤU TRÚC DỮ LIỆU VÀ GIẢI THUẬT
Bài 1: Tìm Min, Max trong 1000 số ngẫu nhiên
Số lớn nhất: 9995 | Số nhỏ nhất: 22

Bài 2: FizzBuzz từ 1 đến 100
1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz

Bài 3: Đảo ngược chuỗi
Chuỗi gốc: "Cấu trúc dữ liệu và giải thuật" => Đảo ngược: "tậuht iảig àv uệil ữd cúrt uấC"

Bài 4: Mảng 1000 số ngẫu nhiên & Sắp xếp tăng
15 phần tử đầu trước khi sắp xếp: 1691 3915 1218 1701 7340 1765 1705 7081 9317 5192 4194 1015 5487 2736 683
15 phần tử đầu sau khi sắp xếp tăng: 22 30 43 53 61 62 63 70 85 107 111 115 121 122 134

Bài 5: Số Fibonacci thứ 10
F(10) = 55

------------------------------------------------------
CHƯƠNG 2: PHÂN TÍCH GIẢI THUẬT
Bài 3: Kiểm tra số nguyên tố (n = 1000003)
- Giải thuật 1 (Duyệt đến n-1): Kết quả = True | Thời gian = 6.2405 ms
- Giải thuật 2 (Duyệt đến căn n): Kết quả = True | Thời gian = 0.0142 ms

Bài 4: Liệt kê số hoàn hảo nhỏ hơn 10000
- Giải thuật 1 (Cơ bản - O(N^2)): 6 28 496 8128 | Thời gian = 315.4754 ms
- Giải thuật 2 (Cải tiến căn bậc 2 - O(N*sqrt(N))): 6 28 496 8128 | Thời gian = 12.9278 ms

Bài 5: So sánh tính Fibonacci thứ 35 ===
- Giải thuật 1 (Đệ quy trực tiếp O(2^n)): F(35) = 9227465 | Thời gian = 888.8768 ms
- Giải thuật 2 (Vòng lặp O(n)): F(35) = 9227465 | Thời gian = 0.5778 ms

Bài 6: So sánh 2 giải thuật sắp xếp (n = 5000 phần tử) ===
- Giải thuật 1 (Bubble Sort - O(n^2)): Thời gian = 384.4578 ms
- Giải thuật 2 (Selection Sort - O(n^2)): Thời gian = 212.0240 ms

------------------------------------------------------
CHƯƠNG 3: ĐỆ QUY
Bài 1: S(n) = 1 + 2 + ... + n
Với n = 5 => S(5) = 15

Bài 2: S(n) = 1^2 + 2^2 + ... + n^2
Với n = 4 => S(4) = 30

Bài 3: S(n) = 1 + 1/2 + ... + 1/n
Với n = 5 => S(5) = 2.2833

Bài 4: S(x, n) = x^n
Với x = 2, n = 3 => S(2, 3) = 8
Với x = 2, n = -2 => S(2, -2) = 0.25

Bài 5: Ước số lẻ lớn nhất của n
Ước lẻ lớn nhất của 100 là: 25

Bài 6: Ước chung lớn nhất (UCLN)
UCLN(48, 18) = 6

Bài 7: Đếm số chữ số của n
Số chữ số của 123456 là: 6

Bài 8: Tổng căn bậc hai lồng nhau
Với n = 4 => S(4) = 1.7488


------------------------------------------------------
PHẦN 4: BÀI TẬP TỰ THỰC HÀNH ĐỆ QUY
Bài 1: Tính tổng S(n) = 1 + 2 + ... +n
Với n = 6 => S(6) = 21

Bài 2: Đảo ngược chuỗi kí tự
Chuỗi gốc: "hello" => Đảo ngược: "olleh"

Bài 3: Tính lũy thừa x^n
Với x=3, n=4 => 3^4 = 81

Bài 4: Tìm số lướn nhất trong mảng
Mảng: [12,45,7,89,23,56] => Max = 89

Bài 5: Tính số chữ số của số nguyên dương n
Số chữ số của 98765 là: 5
Bài 6: giải bài toán Tháp Hà Nội (n=3 đĩa)
Chuyển 1 đĩa từ A -> C
Chuyển 1 đĩa từ A -> B
Chuyển 1 đĩa từ C -> B
Chuyển 1 đĩa từ A -> C
Chuyển 1 đĩa từ B -> A
Chuyển 1 đĩa từ B -> C
Chuyển 1 đĩa từ A -> C

Bài 7: Liệt kê các dãy nhị phân độ dài n = 3
000 001 010 011 100 101 110 111