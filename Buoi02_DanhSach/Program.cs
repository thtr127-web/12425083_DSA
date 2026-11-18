using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_DanhSach
{
    // cấu trúc dữ liệu dùng ở bài 2, 4, 5
    struct NhanVien
    {
        public string MaNV;
        public string Hoten;
        public int Namsinh;
        public string Phongban;
        public int LuongCB;
        public int Thuong;
    }

    // cấu trúc một nút trong danh sách liên kết đơn (bài 4, 5, 13, 14, 15)
    class Node
    {
        public int Data;
        public Node Next;
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    //Node ds liên kết kép (b16, 17, 18)
    class DNode
    {
        public string Info;
        public string Extra;
        public DNode Prev;
        public DNode Next;

        public DNode (string info, string extra ="")
        {
            Info = info;
            Extra = extra;
            Prev = null;
            Next = null;
        }
    }

    internal class Program
    {
        static NhanVien[] DS;
        static Node pHead = null;
        static Node l = null;
        
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.InputEncoding=Encoding.UTF8;
            Console.WriteLine();

            Console.WriteLine("=======BÀI TẬP CHƯƠNG 4: MẢNG VÀ DANH SÁCH LIÊN KẾT======= ");
            BaiTap1();
            BaiTap2();
            BaiTap3();
            BaiTap4();
            BaiTap5();

            Console.WriteLine("=======BÀI TẬP TỰ THỰC HÀNH: MẢNG VÀ DANH SÁCH LIÊN KẾT======= ");
            Bai7_QuanLyNhietDo();
            Bai8_ThongKeTu();
            Bai9_XuLySoNguyen();
            Bai10_MaTranXoanOc();
            Bai11_MaTranDacBiet();
            Bai12_GameMinesweeper();
            Bai13_DaoNguocDanhSach();
            Bai14_GopDanhSach();
            Bai15_PhatHienChuTrinh();
            Bai16_LichSuDuyetWeb();
            Bai17_PlaylistNhac();
            Bai18_HeThongDatHang();
            Console.ReadLine();

        }

        static void BaiTap1()
        {
            Console.WriteLine("BÀI TẬP 1: MẢNG SỐ NGUYÊN DƯƠNG & CHÈN PHẦN TỬ");
            // a. Nhập từ bàn phím
            Console.Write("Nhập số phần tử n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i<=n-1; i++)
            {
                Console.Write($"Nhập a[{i+1}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            // b. Hiển thị danh sách ra màn hình
            Console.Write("Danh sách vừa nhập: ");
            for (int i=0; i<=n-1;i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            // c. Chèn phần tử x vào vị trí k của dãy
            Console.Write("Nhập giá trị x cần chèn: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write($"Nhập vị trí k cần chèn (1 -> {a.Length +1}): ");
            int k = int.Parse(Console.ReadLine());

            if (k<0 || k>a.Length +1)
            {
                Console.WriteLine("Vị trí k không hợp lệ\n");
                return;
            }
            int[] tmp = new int[a.Length + 1];
            for (int i=0; i<=k-1;i++)
            {
                tmp[i] = a[i];
            }
            tmp[k-1] = x;
            for (int i=k; i<=a.Length;i++)
            {
                tmp[i] = a[i-1];
            }
            a = tmp;

            Console.Write($"Dãy số sau khi chèn {x} vào vị trí {k}: ");
            for (int i=0; i<a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("\n");
        }

        // Bài 2: Quản lý danh sách nhân viên
        static int thuclinh(int i)
        {
            return DS[i].LuongCB + DS[i].Thuong;
        }

        static void BaiTap2()
        {
            Console.WriteLine("BÀI TẬP 2: QUẢN LÝ DANH SÁCH NHÂN VIÊN");
            DS = new NhanVien[5];
            DS[0] = new NhanVien { MaNV = "NV01", Hoten = "Nhữ Hà Thanh", Namsinh = 1995, Phongban = "Kinh doanh", LuongCB = 8000000, Thuong = 1500000 };
            DS[1] = new NhanVien { MaNV = "NV02", Hoten = "Trần Thị Bình", Namsinh = 1998, Phongban = "Kế toán", LuongCB = 7000000, Thuong = 1000000 };
            DS[2] = new NhanVien { MaNV = "NV03", Hoten = "Lê Hoàng Cường", Namsinh = 1992, Phongban = "Kinh doanh", LuongCB = 9500000, Thuong = 2000000 };
            DS[3] = new NhanVien { MaNV = "NV04", Hoten = "Phạm Minh Dung", Namsinh = 1999, Phongban = "Kỹ thuật", LuongCB = 7000000, Thuong = 1200000 };
            DS[4] = new NhanVien { MaNV = "NV05", Hoten = "Hoàng Hải Yến", Namsinh = 1996, Phongban = "Kỹ thuật", LuongCB = 8500000, Thuong = 800000 };

            Console.WriteLine("Danh sách nhân viên ban đầu:");
            InDS_NhanVien(false);

            // a. Tính tổng thực lĩnh tháng của tất cả các nhân viên
            long tongThucLinh = 0;
            for (int i=0; i<DS.Length; i++)
            {
                tongThucLinh += thuclinh(i);
            }
            Console.WriteLine($"\na.Tổng thực lĩnh tháng của công ty: {tongThucLinh:N0} VNĐ");

            //b. In danh sách những nhân viên có mức lương cơ bản thấp nhất
            int min = int.MaxValue;
            for (int i=0; i<DS.Length; i++)
            {
                if (min > DS[i].LuongCB)
                {
                    min = DS[i].LuongCB;
                }    
            }
            Console.WriteLine($"\nb.Nhân viên có lương cơ bản thấp nhất ({min:N0} VNĐ):");
            for (int i=0; i<DS.Length; i++)
            {
                if (DS[i].LuongCB == min)
                {
                    Console.WriteLine($" - {DS[i].MaNV} | {DS[i].Hoten} | Phòng: {DS[i].Phongban}");
                }    
            }

            // c. Đếm số lượng nhân viên có mức thưởng >=1200000
            int dem = 0;
            for (int i=0; i<DS.Length; i++)
            {
                if (DS[i].Thuong >= 1200000)
                {
                    dem++;
                }    
            }
            Console.WriteLine($"\nc. Số lượng nhân viên có thưởng >= 1.200.000đ: {dem}");

            //d. In danh sách tăng dần theo phòng ban, trùng phòng ban thì giảm dần theo mã NV
            for (int i=0; i<DS.Length-1;i++)
            {
                for (int j=i+1; j<DS.Length; j++)
                {
                    int cmpPhong = string.Compare(DS[i].Phongban, DS[j].Phongban);
                    if (cmpPhong > 0 || (cmpPhong == 0 && string.Compare(DS[i].MaNV, DS[j].MaNV) < 0))
                    {
                        NhanVien temp = DS[i];
                        DS[i] = DS[j];
                        DS[j] = temp;
                    }    
                }    
            }
            Console.WriteLine("\nd. Danh sách tăng dần theo phòng ban, giảm dần theo Mã NV: ");
            InDS_NhanVien(false);

            //e. Cập nhật tăng lương của tất cả các nhân vien lên 5%
            for (int i=0; i<DS.Length; i++)
            {
                DS[i].LuongCB = (int)(DS[i].LuongCB * 1.05);
            }
            Console.WriteLine("\ne. Danh sách sau khi cập nhật tăng lương cơ bản lên 5%: ");
            InDS_NhanVien(true);
            Console.WriteLine("\n");
        }

        static void InDS_NhanVien (bool sauTangLuong)
        {
            for (int i=0; i<DS.Length; i++)
            {
                Console.WriteLine($" {DS[i].MaNV, -5} | {DS[i].Hoten,-17} | {DS[i].Namsinh} | {DS[i].Phongban,-11} | LCB: {DS[i].LuongCB,9:N0} | Thưởng: {DS[i].Thuong,8:N0} | Thực lĩnh: {thuclinh(i),9:N0}");
            }    
        }

        // Bài 3: Ma trận vuông cấp n
        static void BaiTap3()
        {
            Console.WriteLine("BÀI TẬP 3: MA TRẬN VUÔNG CẤP N");
            int n = 4;
            int[,] a =
            {
                {2, 5, 8,10 },
                {-3, 4, 7, 12 },
                {6, 1, 9, 15 },
                {11, -2, 3, 20 }
            };
            Console.WriteLine($"Ma trận vuông cấp n ={n}:");
            for (int i=0; i<n; i++)
            {
                for (int j=0; j<n; j++)
                {
                    Console.Write($"{a[i,j],4}");
                }
                Console.WriteLine();   
            }

            //a. Tính tổng tất cả các phần tử của ma trận
            int t = 0;
            for (int i=0; i<n; i++)
            {
                for (int j=0; j<n; j++)
                {
                    t += a[i, j];
                }    
            }
            Console.WriteLine($"\na. Tổng tất cả các phần tửu của ma trận: {t}");

            //b. Tìm giá trị dương nhỏ nhất
            int min = int.MaxValue;
            for (int i=0; i<n;i++)
            {
                for (int j=0; j<n;j++)
                {
                    if (a[i,j] < min && a[i,j] >0)
                    {
                        min = a[i, j];
                    }    
                } 
            }
            Console.WriteLine($"\nb. Gía trị dương nhỏ nhất của ma trận: {min}");

            //c. Tính tổng các phần tử nằm trên đường chéo phụ (j=n-1-i)
            int tongCheoPhu = 0;
            for (int i=0;i<n;i++)
            {
                for (int j=0; j<n;j++)
                {
                    if (j==(n-1)-i)
                    {
                        tongCheoPhu += a[i, j];
                    }    
                }    
            }
            Console.WriteLine($"\nc. Tổng các phần tử trên đường chéo phụ: {tongCheoPhu}");

            //d. Kiểm tra đường chéo chính có tăng dần hay không
            int[] tg = new int[n];
            for (int i=0;i<n;i++)
            {
                tg[i] = a[i, i];
            }
            bool tangDan = true;
            for (int i=0; i<= n-2; i++)
            {
                for (int j=i+1; j<=n-1; j++)
                {
                    if (tg[i] >= tg[j])
                    {
                        tangDan = false;
                        break;
                    }    
                }

                if (!tangDan) break;
            }
            Console.WriteLine($"d. Đường chéo chính ({string.Join(",",tg)}) có tăng dần không? {(tangDan? "Có": "Không")}\n");
        }

        // Bài 4: Danh sách liên kết đơn
        static void ThemCuoi(ref Node head, int val)
        {
            Node newNode = new Node(val);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node p = head;
            while (p.Next!=null)
            {
                p = p.Next;
            }
            p.Next = newNode;
        }

        static void InDSLK (Node head)
        {
            Node p = head;
            while (p!=null)
            {
                Console.Write(p.Data + "->");
                p = p.Next;
            }
            Console.WriteLine("NULL");
        }
        static void BaiTap4()
        {
            Console.WriteLine("BÀI TẬP 4: DANH SÁCH LIÊN KẾT ĐƠN (pHead)");
            int[] duLieu = { 12, 5, 8, 5, 20, 3, 5 };
            for (int i=0;  i<duLieu.Length; i++)
            {
                ThemCuoi(ref pHead, duLieu[i]);
            }
            Console.Write("Danh sách pHead ban đầu: ");
            InDSLK(pHead);

            //a. Đếm xem trong danh sách có bao nhiêu số bằng x
            int x = 5;
            int d = 0;
            Node p = pHead;
            while (p!=null)
            {
                if (p.Data == x) d = d + 1;
                p = p.Next;
            }
            Console.WriteLine($"a. Số lượng phần tử bằng {x} trong danh sách : {d}");

            // b. Tìm phần tử dương nhỏ nhất trong danh sách
            int minDuong = int.MaxValue;
            p = pHead;
            while (p != null)
            {
                if (p.Data > 0 && p.Data < minDuong)
                {
                    minDuong = p.Data;
                }
                p = p.Next;
            }
            Console.WriteLine($"b. Phần tử dương nhỏ nhất trong danh sách: {minDuong}");

            // c. Xóa phần tử x xuất hiện đầu tiên trong danh sách
            int xCanXoa = 5;
            p = pHead;
            Node t = null;
            while (p!=null && p.Data != xCanXoa)
            {
                t = p;
                p = p.Next;
            } 

            if (p!=null)
            {
                if (p== pHead)
                {
                    pHead = pHead.Next;
                }
                else
                {
                    t.Next = p.Next;
                }
            }
            Console.Write($"c. Danh sách sau khi xóa số {xCanXoa} đầu tiên: ");
            InDSLK(pHead);
            Console.WriteLine("\n");
        }

        //Bài 5: DANH SÁCH LIÊN KẾT ĐƠN
        static bool KTNT (int n)
        {
            if (n<2) return false;
            for (int i=2; i*i<=n; i++)
            {
                if (n % i == 0) return false;
            }    
            return true;
        }

        static void BaiTap5()
        {
            Console.WriteLine("BÀI TẬP 5: DANH SÁCH LIÊN KẾT ĐƠN");
            int[] duLieu = { -7, 0, 11, 4, -2, 7, 0, 15, 2 };
            for (int i = 0; i < duLieu.Length; i++)
            {
                ThemCuoi(ref l, duLieu[i]);
            }
            Console.Write("Danh sách l ban đầu: ");
            InDSLK(l);

            //a. Tìm phần tử lớn nhất danh sách l
            int max = int.MinValue;
            Node p = l;
            while (p != null)
            {
                if (p.Data > max) max = p.Data;
                p = p.Next;
            }
            Console.WriteLine($"a. Phần tử lớn nhất danh sách: {max}");

            //b. Tính tổng các phần tử của danh sách l
            int t = 0;
            p = l;
            while (p != null)
            {
                t += p.Data;
                p = p.Next;
            }
            Console.WriteLine($"b. Tổng các phần tử trong danh sách : {t}");

            //c. Đếm xem trong danh sách l có bao nhiêu số nguyên tố
            int demNT = 0;
            p = l;
            while (p!= null)
            {
                if (KTNT(p.Data)) demNT++;
                p = p.Next;
            }
            Console.WriteLine($"c. Số lượng số nguyên tố trong danh sách: {demNT}");

            //d. Đếm số âm, số dương, số bằng 0
            int demAm = 0, demDuong = 0, demKhong = 0;
            p = l;
            while (p!=null)
            {
                if (p.Data < 0) demAm++;
                else if (p.Data > 0) demDuong++;
                else demKhong++;
                p = p.Next;
            }
            Console.WriteLine($"d. Số âm: {demAm} | Số dương: {demDuong} | Số bằng 0: {demKhong}");

            //e. Đếm xem trong danh sách có bao nhiêu số bằng x
            int x = 0;
            int demX = 0;
            p = l;
            while (p!=null)
            {
                if (p.Data == x) demX++;
                p = p.Next;
            }
            Console.WriteLine($"e. Số lượng phần tử bằng {x}: {demX}");

            //f. Tìm phần tử dương nhỏ nhất trong danh sách
            int minduong = int.MaxValue;
            p = l;
            while (p != null)
            {
                if (p.Data > 0  && p.Data < minduong)
                {
                    minduong = p.Data;
                }
                p = p.Next;
            }
            Console.WriteLine($"f. Phần tử dương nhỏ nhất trong danh sách: {minduong}\n");
        }

        // Bài 7: Quản lý nhiệt độ
        static void Bai7_QuanLyNhietDo()
        {
            Console.WriteLine("BÀI 7: QUẢN LÝ NHIỆT ĐỘ");
            double[] nhietDo = { 28.5, 30.0, 32.4, 27.0, 29.8, 31.2, 26.5 };
            double max = nhietDo[0], min = nhietDo[0], tong = 0;
            int ngayMax = 1, ngayMin = 1;

            for (int i = 0;i<nhietDo.Length;i++)
            {
                tong += nhietDo[i];
                if (nhietDo[i] > max) { max = nhietDo[i]; ngayMax = i + 1; }
                if (nhietDo[i] < min) { min = nhietDo[i]; ngayMin = i + 1; }
            }
            double trungBinh = tong / nhietDo.Length;
            Console.WriteLine($"Nhiệt độ cao nhất {max} độ C (Ngày {ngayMax}) | Thấp nhất: {ngayMin} độ C (Ngày {ngayMin}) | Trung bình: {trungBinh:F2} độ C\n");
        }

        //Bài 8: Thống kê từ
        static void Bai8_ThongKeTu()
        {
            Console.WriteLine("BÀI 8: THỐNG KÊ TẦN SUẤT TỪ");
            string vanBan = "Cấu trúc dữ liệu và giải thuật";
            string chuanHoa = vanBan.ToLower();
            string[]cacTu = chuanHoa.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> tanSuat = new Dictionary<string, int>();
            for (int i = 0; i < cacTu.Length; i++)
            {
                if (tanSuat.ContainsKey(cacTu[i]))
                    tanSuat[cacTu[i]]++;
                else
                    tanSuat[cacTu[i]] = 1;
            }
            Console.WriteLine($"Văn bản: \"{vanBan}\"");

            foreach (var item in tanSuat)
            {
                Console.Write($"[{item.Key}: {item.Value}] ");
            }
            Console.WriteLine("\n");  
        }

        // Bài 9: Xử lý số nguyên
        static bool LaSoHoanHao(int n)
        {
            if (n < 2) return false;
            int tongUoc = 1;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    tongUoc += i;
                    if (i * i != n) tongUoc += n / i;
                }
            }
            return tongUoc == n;
        }

        static void Bai9_XuLySoNguyen()
        {
            Console.WriteLine("BÀI 9: XỬ LÝ SỐ NGUYÊN (NGUYÊN TỐ, CHẴN, HOÀN HẢO");
            int[] daySo = { 2, 6, 7, 12, 28, 15, 17, 20 };
            Console.Write("Dãy số: " + string.Join(", ", daySo) + "\n- Số nguyên tố: ");
            foreach (int x in daySo) if (KTNT(x)) Console.Write(x + " ");
            Console.Write("\n- Số chẵn: ");
            foreach (int x in daySo) if (x % 2 == 0) Console.Write(x + " ");
            Console.Write("\n- Số hoàn hảo: ");
            foreach (int x in daySo) if (LaSoHoanHao(x)) Console.Write(x + " ");
            Console.WriteLine("\n");
        }

        // Bài 10: Ma trận xoắn ốc
        static void Bai10_MaTranXoanOc()
        {
            Console.WriteLine("BÀI 10: IN MA TRẬN THEO THỨ TỰ XOẮN ỐC");
            int[,] mat = {
                    { 1,  2,  3,  4 },
                    { 5,  6,  7,  8 },
                    { 9, 10, 11, 12 }
            };
            int top = 0, bottom = mat.GetLength(0) - 1;
            int left = 0, right = mat.GetLength(1) - 1;
            Console.Write("Kết quả duyệt xoắn ốc: ");
            while (top <= bottom && left <= right)
            {
                for (int i = left; i <= right; i++) Console.Write(mat[top, i] + " ");
                top++;
                for (int i = top; i <= bottom; i++) Console.Write(mat[i, right] + " ");
                right--;
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--) Console.Write(mat[bottom, i] + " ");
                    bottom--;
                }
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--) Console.Write(mat[i, left] + " ");
                    left++;
                }
            }
            Console.WriteLine("\n");
        }

        // Bài 11: Ma trận đặc biệt
        static void Bai11_MaTranDacBiet()
        {
            Console.WriteLine("Bài 11: Kiểm tra ma trận đơn vị và ma trận đối xứng");
            int[,] matrix = {
                { 1, 2, 3 },
                { 2, 5, 6 },
                { 3, 6, 9 }
            };
            int n = matrix.GetLength(0);
            bool laDonVi = true, laDoiXung = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i == j && matrix[i, j] != 1) || (i != j && matrix[i, j] != 0)) laDonVi = false;
                    if (matrix[i, j] != matrix[j, i]) laDoiXung = false;
                }
            }
            Console.WriteLine($"Ma trận đơn vị: {laDonVi} | Ma trận đối xứng: {laDoiXung}\n");
        }

        // Bài 12: Game Minesweeper 
        static void Bai12_GameMinesweeper()
        {
            Console.WriteLine("Bài 12: Game Minesweeper (Đếm mìn 8 hướng)");
            int m = 4, n = 4;
            int[,] banDo = new int[m, n]; // -1 là có mìn
            banDo[0, 1] = -1;
            banDo[2, 2] = -1;
            banDo[3, 0] = -1;
            int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (banDo[i, j] == -1) continue;
                    int soMin = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        int ni = i + dx[k], nj = j + dy[k];
                        if (ni >= 0 && ni < m && nj >= 0 && nj < n && banDo[ni, nj] == -1) soMin++;
                    }
                    banDo[i, j] = soMin;
                }
            }
            Console.WriteLine("Bảng Minesweeper (* là mìn):");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(banDo[i, j] == -1 ? " * " : $" {banDo[i, j]} ");
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

        // Bài 13: Đảo ngược danh sách liên kết đơn không đệ quy 
        static void Bai13_DaoNguocDanhSach()
        {
            Console.WriteLine("Bài 13: Đảo ngược danh sách liên kết đơn (3 con trỏ)");
            Node head = null;
            for (int i = 1; i <= 5; i++) ThemCuoi(ref head, i);
            Console.Write("Ban đầu: "); InDSLK(head);
            Node previous = null, current = head, next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }
            head = previous;
            Console.Write("Sau khi đảo ngược: "); InDSLK(head);
            Console.WriteLine("\n");
        }

        // Bài 14: Gộp hai danh sách đã sắp xếp
        static void Bai14_GopDanhSach()
        {
            Console.WriteLine("Bài 14: Gộp hai danh sách đã sắp xếp ");
            Node l1 = null, l2 = null;
            ThemCuoi(ref l1, 1); ThemCuoi(ref l1, 4); ThemCuoi(ref l1, 7);
            ThemCuoi(ref l2, 2); ThemCuoi(ref l2, 3); ThemCuoi(ref l2, 8);
            Node dummy = new Node(0);
            Node tail = dummy;
            Node p1 = l1, p2 = l2;
            while (p1 != null && p2 != null)
            {
                if (p1.Data <= p2.Data) { tail.Next = p1; p1 = p1.Next; }
                else { tail.Next = p2; p2 = p2.Next; }
                tail = tail.Next;
            }
            tail.Next = (p1 != null) ? p1 : p2;
            Console.Write("Danh sách sau khi gộp: "); InDSLK(dummy.Next);
            Console.WriteLine("\n");
        }

        // Bài 15: Phát hiện chu trình - Floyd's Cycle-Finding
        static void Bai15_PhatHienChuTrinh()
        {
            Console.WriteLine("Bài 15: Phát hiện chu trình (Rùa và Thỏ)");
            Node n2 = new Node(2), n3 = new Node(3), n4 = new Node(4), n5 = new Node(5), n6 = new Node(6);
            n2.Next = n3; n3.Next = n4; n4.Next = n5; n5.Next = n6;
            n6.Next = n2; 
            Node rua = n2, tho = n2;
            bool coChuTrinh = false;
            while (tho != null && tho.Next != null)
            {
                rua = rua.Next;
                tho = tho.Next.Next;
                if (rua == tho) { coChuTrinh = true; break; }
            }
            Console.WriteLine($"Danh sách 2->3->4->5->6->2 có chu trình không? => {coChuTrinh}\n");
        }

        // Bài 16: Hệ thống lịch sử duyệt web - Danh sách kép 
        static void Bai16_LichSuDuyetWeb()
        {
            Console.WriteLine("Bài 16: Lịch sử duyệt web (Back/Forward)");
            DNode trang1 = new DNode("google.com");
            DNode trang2 = new DNode("github.com");
            DNode trang3 = new DNode("stackoverflow.com");
            trang1.Next = trang2; trang2.Prev = trang1;
            trang2.Next = trang3; trang3.Prev = trang2;
            DNode current = trang3;
            Console.WriteLine($"Trang hiện tại: {current.Info}");
            if (current.Prev != null) { current = current.Prev; Console.WriteLine($"Nhấn Back -> {current.Info}"); }
            if (current.Prev != null) { current = current.Prev; Console.WriteLine($"Nhấn Back -> {current.Info}"); }
            if (current.Next != null) { current = current.Next; Console.WriteLine($"Nhấn Forward -> {current.Info}\n"); }
        }

        // Bài 17: Playlist nhạc - Danh sách kép
        static void Bai17_PlaylistNhac()
        {
            Console.WriteLine("Bài 17: Playlist nhạc (Next/Previous/Thêm/Xóa) =");
            DNode b1 = new DNode("Bài hát 1");
            DNode b2 = new DNode("Bài hát 2");
            DNode b3 = new DNode("Bài hát 3");
            b1.Next = b2; b2.Prev = b1;
            b2.Next = b3; b3.Prev = b2;
            DNode current = b1;
            Console.WriteLine($"Đang phát: {current.Info}");
            current = current.Next; // Next
            Console.WriteLine($"Next -> Đang phát: {current.Info}");
            // Xóa bài hát 2 (current)
            if (current.Prev != null) current.Prev.Next = current.Next;
            if (current.Next != null) current.Next.Prev = current.Prev;
            current = current.Next;
            Console.WriteLine($"Sau khi xóa Bài hát 2, chuyển sang: {current.Info}\n");
        }

        // Bài 18: Hệ thống đặt hàng - Danh sách kép chuyển trạng thái
        static void Bai18_HeThongDatHang()
        {
            Console.WriteLine("Bài 18: Hệ thống đặt hàng (Chuyển trạng thái)");
            DNode tt1 = new DNode("Đơn hàng #DH01", "Chờ xử lý");
            DNode tt2 = new DNode("Đơn hàng #DH01", "Đang giao");
            DNode tt3 = new DNode("Đơn hàng #DH01", "Hoàn thành");
            tt1.Next = tt2; tt2.Prev = tt1;
            tt2.Next = tt3; tt3.Prev = tt2;
            DNode donHang = tt1;
            Console.WriteLine($"Trạng thái ban đầu: {donHang.Info} [{donHang.Extra}]");
            if (donHang.Next != null) { donHang = donHang.Next; Console.WriteLine($"Cập nhật tiếp theo -> [{donHang.Extra}]"); }
            if (donHang.Next != null) { donHang = donHang.Next; Console.WriteLine($"Cập nhật tiếp theo -> [{donHang.Extra}]"); }
            Console.WriteLine("\n");
        }
    }
}
