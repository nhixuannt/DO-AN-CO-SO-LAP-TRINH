using System.Text;

namespace _Canhan_Tamgia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai báo biến
            string canh1, canh2, goc1;
            double a, b, c;
            double g1, g2, g3;
            double rad1, rad2;
            // Output tiếng việt có dấu
            Console.OutputEncoding = Encoding.Unicode;
            // Vòng lặp bắt lỗi nhập sai dữ liệu cạnh
            do
            {
                Console.Write("Nhập vào số đo cạnh a bất kì của 1 tam giác: ");
                canh1 = Console.ReadLine();
                Console.Write("Nhập vào số đo cạnh b của 1 tam giác: ");
                canh2 = Console.ReadLine();
                double.TryParse(canh1, out a);
                double.TryParse(canh2, out b);
                if (a <= 0 || b <= 0 || (a <= 0 && b <= 0))
                {
                    Console.WriteLine("\nDữ liệu nhập vào sai , vui lòng nhập lại!!!");
                    Console.WriteLine("Độ dài các cạnh nhập vào phải là số và cạnh>0\n");
                }
            }
            while (a <= 0 || b <= 0 || (a <= 0 && b <= 0));
            // Vòng lặp bắt lỗi nhập sai dữ liệu góc
            do
            {
                Console.Write("\nNhập vào góc xen giữa 2 cạnh vừa nhập(dưới dạng độ):");
                goc1 = Console.ReadLine();
                double.TryParse(goc1, out g1);
                if (g1 <= 0 || g1 >= 180)
                {
                    Console.WriteLine("\nDữ liệu nhập vào sai , vui lòng nhập lại!!!");
                    Console.WriteLine("Góc nhập vào phải là số và 0<góc<180");
                }
            }
            while (g1 <= 0 || g1 >= 180);

            // Tính toán các cạnh và góc
            rad1 = Math.PI * g1 / 180;
            c = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(rad1));
            rad2 = Math.Acos((b * b + c * c - a * a) / (2 * c * b));
            g2 = rad2 * 180 / Math.PI;
            g3 = 180 - g1 - g2;
            // In ra màn hình đáp án bài toán
            Console.WriteLine("\nChiều dài cạnh còn lại là:{0}", c);
            Console.WriteLine("Số đo của 2 góc còn lại lần lượt là: {0} độ, {1} độ",
           g2, g3);
            Console.ReadKey();

        }
    }
}
