using System.Text;

namespace _Nhom_Bubblesort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            int n = 0;
            bool check = false;
            while (check == false)
            {
                Console.Write("Nhập số lượng học sinh N : ");
                //kiểm tra tính hợp lệ của N
                string tmp = Console.ReadLine();
                int nt = tmp.Length;
                check = true;
                for (int i = 0; i < nt; i++)
                {
                    if (!(tmp[i] == '+' || (tmp[i] >= '0' && tmp[i] <= '9')))
                    {
                        Console.WriteLine("N phải là số nguyên, xin mời nhập lại!");
                        check = false;
                        break;
                    }
                }
                if (check) n = int.Parse(tmp);
                if (n < 1 && check)
                {
                    check = false;
                    Console.WriteLine("N >= 1, xin mời nhập lại!");
                }
            }
            //khai báo mảng để nhập thông tin
            string[,] ThongTinHocSinh = new string[n, 5];
            int[] thuhang = new int[n];
           // Nhập thông tin
            for (int i = 0; i < n; i++)
            {
                thuhang[i] = i + 1;
                Console.WriteLine("Nhập thông tin học sinh thứ {0}: ", i + 1);
                bool check_tt = false;
                //kiểm tra tên học sinh thứ i có hợp lệ hay không
                do
                {
                    Console.Write("Nhập họ tên học sinh thứ {0}: ", i + 1);
                    ThongTinHocSinh[i, 0] = Console.ReadLine();
                    check_tt = true;
                    string s_tmp0 = ThongTinHocSinh[i, 0];
                    int len = ThongTinHocSinh[i, 0].Length;
                    for (int j = 0; j < len; j++)
                    {
                        if (s_tmp0[j] >= '0' && s_tmp0[j] <= '9')
                        {
                            check_tt = false;
                            Console.WriteLine("Tên học sinh không được có số, xin mời nhập lại!");
                        break;
                        }
                    }
                }
                while (check_tt == false);
                //kiểm tra năm sinh có là số nguyên dương hay không
                do
                {
                    Console.Write("Nhập năm sinh học sinh thứ {0}: ", i + 1);
                    ThongTinHocSinh[i, 1] = Console.ReadLine();
                    check_tt = true;
                    string s_tmp1 = ThongTinHocSinh[i, 1];
                    int len = s_tmp1.Length;
                    for (int j = 0; j < len; j++)
                    {
                        if (!(s_tmp1[j] >= '0' && s_tmp1[j] <= '9'))
                        {
                            check_tt = false;
                            Console.WriteLine("Năm sinh phải là số nguyên dương, xin mời nhập lại!");
                        break;
                        }
                    }
                }
                while (check_tt == false);
                //Kiểm tra điểm trung bình có là số thực hay không
                do
                {
                    Console.Write("Nhập điểm trung bình học sinh thứ {0}(sau phần thập phân là dấu '.'): ", i + 1);
                ThongTinHocSinh[i, 2] = Console.ReadLine();
                    check_tt = true;
                    string s_tmp2 = ThongTinHocSinh[i, 2];
                    int len = s_tmp2.Length;
                    for (int j = 0; j < len; j++)
                    {
                        if (!((s_tmp2[j] >= '0' && s_tmp2[j] <= '9') || s_tmp2[j] ==
                       '.' || s_tmp2[j] == '+'))
                        {
                            check_tt = false;
                            Console.WriteLine("Điểm trung bình phải là số thực, xin mời nhập lại!");
                        break;
                        }
                    }
                }
                while (check_tt == false);
                //Kiểm tra xếp loại có thuộc Giỏi, khá, trung bình, yếu
                do
                {
                    Console.Write("Nhập xếp loại học sinh thứ {0} (Giỏi, Khá, TB, Yếu): ", i + 1);
                ThongTinHocSinh[i, 3] = Console.ReadLine();
                    check_tt = true;
                    string s_tmp4 = ThongTinHocSinh[i, 3];
                    if (!(s_tmp4 == "Giỏi" || s_tmp4 == "Khá" || s_tmp4 == "TB" ||
                   s_tmp4 == "Yếu"))
                    {
                        check_tt = false;
                        Console.WriteLine("Xếp loại phải thuộc {Giỏi, Khá, TB, Yếu}, xin mời nhập lại!");
                    }
                }
                while (check_tt == false);
                ThongTinHocSinh[i, 4] = i.ToString();
                Console.WriteLine();
            }
            //Xử lí dữ liệu - bubble short
            for (int i = 0; i < n - 1; i++)
            {
                double tmp_i = double.Parse(ThongTinHocSinh[i, 2]);
                for (int j = i + 1; j < n; j++)
                {
                    double tmp_j = double.Parse(ThongTinHocSinh[j, 2]);
                    if (tmp_i < tmp_j)
                    {
                        string swap = "";
                        for (int k = 0; k < 5; k++)
                        {
                            swap = ThongTinHocSinh[i, k];
                            ThongTinHocSinh[i, k] = ThongTinHocSinh[j, k];
                            ThongTinHocSinh[j, k] = swap;
                        }
                        //đổi thông tin thì phải đổi luôn tmp
                        double swap_tmp = tmp_i;
                        tmp_i = tmp_j;
                        tmp_j = swap_tmp;
                    }
                }
                Console.WriteLine();
            }
            int loop = 0;
            while (loop < n)
            {
                if (loop + 1 < n && ThongTinHocSinh[loop, 2] == ThongTinHocSinh[loop
               + 1, 2])
                {
                    thuhang[loop + 1] = thuhang[loop];
                }
                ++loop;
            }
            //Xuất dữ liệu
            //ghép thứ hạng đã sắp xếp vào thứ hạng ban đầu nhập từ bàn phím
            string[,] xuatdulieu = new string[n, 5];
            for (int i = 0; i < n; i++)
            {
                int xuat_id = int.Parse(ThongTinHocSinh[i, 4]);
                for (int j = 0; j < 4; j++)
                {
                    xuatdulieu[xuat_id, j] = ThongTinHocSinh[i, j];
                }
                xuatdulieu[xuat_id, 4] = thuhang[i].ToString();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("BẢNG ĐIỂM TỐT NGHIỆP");
                Console.WriteLine("Cấp cho sinh viên {0}, năm sinh {1}.",
               xuatdulieu[i, 0], xuatdulieu[i, 1]);
                Console.WriteLine("Trong kì thi tốt nghiệp 2021, sinh viên trên đã đạt điểm trung bình là { 0}, và được xếp loại { 1}.", xuatdulieu[i, 2], xuatdulieu[i, 3]);
            Console.WriteLine("Sinh viên có thứ hạng {1} trong lớp.",
           xuatdulieu[i, 3], xuatdulieu[i, 4]);
            Console.WriteLine("Hiệu Trưởng Trường Đại học ABC.");
            Console.WriteLine("Kí tên, Đóng dấu");
            Console.WriteLine("--------------------");
        }
        Console.ReadKey();
        }
}
}
