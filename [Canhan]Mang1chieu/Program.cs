using System.Text;

namespace _Canhan_Mang1chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai báo biến
            int t;
            string thang;
            // Output tiếng việt có dấu
            Console.OutputEncoding = Encoding.Unicode;
            // Vòng lặp bắt lỗi nhập sai dữ liệu
            do
            {
                Console.Write("Nhập vào tháng bất kì trong năm dưới dạng số từ 1-12:");
                thang = Console.ReadLine();
                int.TryParse(thang, out t);
                if (t <= 0 || t > 12) Console.WriteLine("\nDữ liệu nhập vào phải là số từ 1-12, vui lòng nhập lại!!!\n");
            }
            while (t <= 0 || t > 12);
            // Khai báo mảng gán các giá trị số ngày
            int[] songay = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            // In ra màn hình đáp án bài toán
            Console.WriteLine("Số ngày của tháng {0} là {1}", t, songay[t - 1]);
            Console.ReadKey();
        }
    }
}
