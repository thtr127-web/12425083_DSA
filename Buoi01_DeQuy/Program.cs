using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Buoi01_DeQuy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("CHƯƠNG 1: TỔNG QUAN VỀ CẤU TRÚC DỮ LIỆU VÀ GIẢI THUẬT");

            Bai1_1();
            Bai1_2();
            Bai1_3("Cấu trúc dữ liệu và giải thuật");
            Bai1_4();
            Bai1_5(10);

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("CHƯƠNG 2: PHÂN TÍCH GIẢI THUẬT");
            Bai2_3(1000003);
            Bai2_4(10000);
            Bai2_5(35);
            Bai2_6(5000);

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("CHƯƠNG 3: ĐỆ QUY");
            Console.WriteLine("Bài 1: S(n) = 1 + 2 + ... + n ");
            Console.WriteLine($"Với n = 5 => S(5) = {Bai3_1(5)}\n");

            Console.WriteLine("Bài 2: S(n) = 1^2 + 2^2 + ... + n^2");
            Console.WriteLine($"Với n = 4 => S(4) = {Bai3_2(4)}\n");

            Console.WriteLine("Bài 3: S(n) = 1 + 1/2 + ... + 1/n");
            Console.WriteLine($"Với n = 5 => S(5) = {Bai3_3(5):F4}\n");

            Console.WriteLine("Bài 4: S(x, n) = x^n");
            Console.WriteLine($"Với x = 2, n = 3 => S(2, 3) = {Bai3_4(2, 3)}");
            Console.WriteLine($"Với x = 2, n = -2 => S(2, -2) = {Bai3_4(2, -2)}\n");

            Console.WriteLine("Bài 5: Ước số lẻ lớn nhất của n");
            Console.WriteLine($"Ước lẻ lớn nhất của 100 là: {Bai3_5(100)}\n");

            Console.WriteLine("Bài 6: Ước chung lớn nhất (UCLN)");
            Console.WriteLine($"UCLN(48, 18) = {Bai3_6(48, 18)}\n");

            Console.WriteLine("Bài 7: Đếm số chữ số của n");
            Console.WriteLine($"Số chữ số của 123456 là: {Bai3_7(123456)}\n");

            Console.WriteLine("Bài 8: Tổng căn bậc hai lồng nhau");
            Console.WriteLine($"Với n = 4 => S(4) = {Bai3_8(1, 4):F4}\n");

            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("PHẦN 4: BÀI TẬP TỰ THỰC HÀNH ĐỆ QUY");
            Console.WriteLine("Bài 1: Tính tổng S(n) = 1 + 2 + ... +n ");
            Console.WriteLine($"Với n = 6 => S(6) = {Bai3_1(6)}\n");

            Console.WriteLine("Bài 2: Đảo ngược chuỗi kí tự");
            string chuoiGoc = "hello";
            Console.WriteLine($"Chuỗi gốc: \"{chuoiGoc}\" => Đảo ngược: \"{Bai4_2(chuoiGoc)}\"\n");

            Console.WriteLine("Bài 3: Tính lũy thừa x^n");
            Console.WriteLine($"Với x=3, n=4 => 3^4 = {Bai3_4(3,4)}\n");

            Console.WriteLine("Bài 4: Tìm số lướn nhất trong mảng");
            int[] mangSo = { 12, 45, 7, 89, 23, 56 };
            Console.WriteLine($"Mảng: [{string.Join(",", mangSo)}] => Max = {Bai4_4(mangSo, mangSo.Length)}\n");

            Console.WriteLine("Bài 5: Tính số chữ số của số nguyên dương n");
            int soCanDem = 98765;
            Console.WriteLine($"Số chữ số của {soCanDem} là: {Bai3_7(soCanDem)}");

            Console.WriteLine("Bài 6: giải bài toán Tháp Hà Nội (n=3 đĩa)");
            Bai4_6(3, 'A', 'C', 'B');
            Console.WriteLine();

            Console.WriteLine("Bài 7: Liệt kê các dãy nhị phân độ dài n = 3");
            int nNhiPhan = 3;
            int[] a = new int[nNhiPhan];
            Bai4_7(0, nNhiPhan, a);
            Console.WriteLine();

            Console.ReadLine();
        }

        static void Bai1_1()
        {
            Console.WriteLine("Bài 1: Tìm Min, Max trong 1000 số ngẫu nhiên");
            Random rnd = new Random();
            int[] arr = new int[1000];
            for (int i = 0; i < 1000; i++) arr[i] = rnd.Next(0, 10000);

            int max = arr[0], min = arr[0];
            for (int i = 1; i < 1000; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
            Console.WriteLine($"Số lớn nhất: {max} | Số nhỏ nhất: {min}\n");
        }

        static void Bai1_2()
        {
            Console.WriteLine("Bài 2: FizzBuzz từ 1 đến 100");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.Write("FizzBuzz ");
                else if (i % 3 == 0) Console.Write("Fizz ");
                else if (i % 5 == 0) Console.Write("Buzz ");
                else Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }

        static void Bai1_3(string s)
        {
            Console.WriteLine("Bài 3: Đảo ngược chuỗi");
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string daoNguoc = new string(charArray);
            Console.WriteLine($"Chuỗi gốc: \"{s}\" => Đảo ngược: \"{daoNguoc}\"\n");
        }

        static void Bai1_4()
        {
            Console.WriteLine("Bài 4: Mảng 1000 số ngẫu nhiên & Sắp xếp tăng");
            Random rnd = new Random();
            int[] arr = new int[1000];
            for (int i = 0; i < 1000; i++) arr[i] = rnd.Next(0, 10000);

            Console.Write("15 phần tử đầu trước khi sắp xếp: ");
            for (int i = 0; i < 15; i++) Console.Write(arr[i] + " ");
            Console.WriteLine();

            Array.Sort(arr);
            Console.Write("15 phần tử đầu sau khi sắp xếp tăng: ");
            for (int i = 0; i < 15; i++) Console.Write(arr[i] + " ");
            Console.WriteLine("\n");
        }

        static void Bai1_5(int n)
        {
            Console.WriteLine($"Bài 5: Số Fibonacci thứ {n}");
            long f0 = 0, f1 = 1, fn = 0;
            if (n == 0) fn = 0;
            else if (n == 1) fn = 1;
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    fn = f0 + f1;
                    f0 = f1;
                    f1 = fn;
                }
            }
            Console.WriteLine($"F({n}) = {fn}\n");
        }


        static void Bai2_3(int n)
        {
            Console.WriteLine($"Bài 3: Kiểm tra số nguyên tố (n = {n})");
            Stopwatch sw = Stopwatch.StartNew();
            bool kq1 = true;
            if (n < 2) kq1 = false;
            for (int i = 2; i <= n - 1; i++)
            {
                if (n % i == 0) { kq1 = false; break; }
            }
            sw.Stop();
            Console.WriteLine($"- Giải thuật 1 (Duyệt đến n-1): Kết quả = {kq1} | Thời gian = {sw.Elapsed.TotalMilliseconds:F4} ms");

            sw.Restart();
            bool kq2 = true;
            if (n < 2) kq2 = false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) { kq2 = false; break; }
            }
            sw.Stop();
            Console.WriteLine($"- Giải thuật 2 (Duyệt đến căn n): Kết quả = {kq2} | Thời gian = {sw.Elapsed.TotalMilliseconds:F4} ms\n");
        }

        static void Bai2_4(int N)
        {
            Console.WriteLine($"Bài 4: Liệt kê số hoàn hảo nhỏ hơn {N}");
            Stopwatch sw = Stopwatch.StartNew();
            Console.Write("- Giải thuật 1 (Cơ bản - O(N^2)): ");
            for (int num = 2; num < N; num++)
            {
                int sum = 0;
                for (int i = 1; i < num; i++) if (num % i == 0) sum += i;
                if (sum == num) Console.Write(num + " ");
            }
            sw.Stop();
            Console.WriteLine($"| Thời gian = {sw.Elapsed.TotalMilliseconds:F4} ms");

            sw.Restart();
            Console.Write("- Giải thuật 2 (Cải tiến căn bậc 2 - O(N*sqrt(N))): ");
            for (int num = 2; num < N; num++)
            {
                int sum = 1;
                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        sum += i;
                        if (i * i != num) sum += num / i;
                    }
                }
                if (sum == num) Console.Write(num + " ");
            }
            sw.Stop();
            Console.WriteLine($"| Thời gian = {sw.Elapsed.TotalMilliseconds:F4} ms\n");
        }

        static long Fib_DeQuy(int n)
        {
            if (n <= 1) return n;
            return Fib_DeQuy(n - 1) + Fib_DeQuy(n - 2);
        }

        static long Fib_Lap(int n)
        {
            if (n <= 1) return n;
            long a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++) { c = a + b; a = b; b = c; }
            return c;
        }

        static void Bai2_5(int n)
        {
            Console.WriteLine($"Bài 5: So sánh tính Fibonacci thứ {n} ===");
            Stopwatch sw = Stopwatch.StartNew();
            long kq1 = Fib_DeQuy(n);
            sw.Stop();
            Console.WriteLine($"- Giải thuật 1 (Đệ quy trực tiếp O(2^n)): F({n}) = {kq1} | Thời gian = {sw.Elapsed.TotalMilliseconds:F4} ms");

            sw.Restart();
            long kq2 = Fib_Lap(n);
            sw.Stop();
            Console.WriteLine($"- Giải thuật 2 (Vòng lặp O(n)): F({n}) = {kq2} | Thời gian = {sw.Elapsed.TotalMilliseconds:F4} ms\n");
        }

        static void Bai2_6(int n)
        {
            Console.WriteLine($"Bài 6: So sánh 2 giải thuật sắp xếp (n = {n} phần tử) ===");
            Random rnd = new Random();
            double[] arr1 = new double[n];
            double[] arr2 = new double[n];
            for (int i = 0; i < n; i++)
            {
                double val = rnd.NextDouble() * 1000;
                arr1[i] = val;
                arr2[i] = val;
            }

            // Bubble Sort
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr1[j] > arr1[j + 1]) { double t = arr1[j]; arr1[j] = arr1[j + 1]; arr1[j + 1] = t; }
            sw.Stop();
            Console.WriteLine($"- Giải thuật 1 (Bubble Sort - O(n^2)): Thời gian = {sw.Elapsed.TotalMilliseconds:F4} ms");

            // Selection Sort
            sw.Restart();
            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++) if (arr2[j] < arr2[minIdx]) minIdx = j;
                double t = arr2[minIdx]; arr2[minIdx] = arr2[i]; arr2[i] = t;
            }
            sw.Stop();
            Console.WriteLine($"- Giải thuật 2 (Selection Sort - O(n^2)): Thời gian = {sw.Elapsed.TotalMilliseconds:F4} ms\n");
        }


        static int Bai3_1(int n)
        {
            if (n == 1) return 1;
            return Bai3_1(n - 1) + n;
        }

        static int Bai3_2(int n)
        {
            if (n == 1) return 1;
            return Bai3_2(n - 1) + n * n;
        }
        static double Bai3_3(int n)
        {
            if (n == 1) return 1.0;
            return Bai3_3(n - 1) + 1.0 / n;
        }
        static double LuyThuaDuong(double x, int n)
        {
            if (n == 0) return 1.0;
            return LuyThuaDuong(x, n - 1) * x;
        }
        static double Bai3_4(double x, int n)
        {
            if (n < 0) return 1.0 / LuyThuaDuong(x, -n);
            return LuyThuaDuong(x, n);
        }
        static int Bai3_5(int n)
        {
            if (n % 2 == 1) return n;
            return Bai3_5(n / 2);
        }
        static int Bai3_6(int a, int b)
        {
            if (a % b == 0) return b;
            return Bai3_6(b, a % b);
        }
        static int Bai3_7(int n)
        {
            if (n == 0) return 0;
            return Bai3_7(n / 10) + 1;
        }
        static double Bai3_8(int i, int n)
        {
            if (i == n) return Math.Sqrt(n);
            return Math.Sqrt(i + Bai3_8(i + 1, n));
        }


        static string Bai4_2(string s)
        {
            if (s.Length <=1)
                return s;
            return Bai4_2(s.Substring(1)) + s[0];
        }

        static int Bai4_4(int[] arr, int n)
        {
            if (n==1)
                return arr[0];
            int maxConLai = Bai4_4(arr, n - 1);
            if (arr[n - 1] > maxConLai)
                return arr[n - 1];
            return maxConLai;
        }

        static void Bai4_6(int n, char cocNguon, char cocDich, char cocTrungGian)
        {
            if (n==1)
            { 
                Console.WriteLine($"Chuyển 1 đĩa từ {cocNguon} -> {cocDich}");
                return;
            }
            Bai4_6(n - 1, cocNguon, cocTrungGian, cocDich);
            Console.WriteLine($"Chuyển 1 đĩa từ {cocNguon} -> {cocDich}");
            Bai4_6(n - 1, cocTrungGian, cocDich, cocNguon);
        }

        static void Bai4_7(int i, int n, int[] a)
        {
            if (i==n)
            {
                for (int j = 0;j<n; j++)
                {
                    Console.Write(a[j]);
                }
                Console.Write(" ");
                return;
            }
            a[i] = 0;
            Bai4_7(i + 1, n, a);

            a[i] = 1;
            Bai4_7(i + 1, n, a);
        }
    }
}   
