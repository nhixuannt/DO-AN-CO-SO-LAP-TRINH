using System.Text;

namespace _Canhan_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai báo biến dòng và cột của 2 ma trận A và B
            int m, n1, n2, p;
            // Output hỗ trợ tiếng việt
            Console.OutputEncoding = Encoding.Unicode;
            // Vòng lặp bắt lỗi nhập sai dữ liệu số dòng, số cột của ma trận A
            do
            {
                Console.Write("Nhập vào số dòng của ma trận A:");
                string dA = Console.ReadLine();
                Console.Write("Nhập vào số cột của ma trận A:");
                string cA = Console.ReadLine();
                int.TryParse(dA, out m);
                int.TryParse(cA, out n1);
                if (m <= 0 || n1 <= 0 || (m <= 0 && n1 <= 0))
                {
                    Console.WriteLine("Dữ liệu nhập vào sai, vui lòng nhập lại!!!");
                }
            }
            while (m <= 0 || n1 <= 0 || (m <= 0 && n1 <= 0));
        // Vòng lặp bắt lỗi nhập sai dữ liệu các phần tử của ma trận A
        checkA:
            int[,] A = new int[m, n1];
            string[,] A1 = new string[m, n1];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    Console.Write("Nhập vào phần tử A[{0},{1}]: ", i, j);
                    A1[i, j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n1; j++)
            {
                    foreach (char pt in A1[i, j])
                    {
                        if (!char.IsDigit(pt))
                        {
                            Console.WriteLine("Dữ liệu nhập vào sai, vui lòng nhập lại!!!");
                            goto checkA;
                        }
                        else
                        {
                            A[i, j] = int.Parse(A1[i, j]);
                        }
                    }
                }
            }
            // In ma trận A
            Console.WriteLine("\nMa trận A:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    Console.Write("{0} ", A1[i, j]);
                }
                Console.WriteLine("");
            }
            // Vòng lặp bắt lỗi nhập sai dữ liệu số dòng, số cột của ma trận B
            do
            {
                Console.WriteLine("");
                Console.Write("Nhập vào số dòng của ma trận B:");
                string dB = Console.ReadLine();
                Console.Write("Nhập vào số cột của ma trận B:");
                string cB = Console.ReadLine();
                int.TryParse(dB, out n2);
                int.TryParse(cB, out p);
                if (n2 <= 0 || p <= 0 || (n2 <= 0 && p <= 0))
                {
                    Console.WriteLine("Dữ liệu nhập vào sai, vui lòng nhập lại!!!");
                }
            else
                {
                    if (n2 != n1)
                    {
                        Console.WriteLine("\nKhông thể nhân 2 ma trận trên. Vui lòng nhập lại!");
                       
                        Console.Write("Số dòng của ma trận B phải bằng số cột của ma trận A");
                    }
                }
            }
            while (n2 <= 0 || p <= 0 || (n2 <= 0 && p <= 0) || n2 != n1);
        // Vòng lặp bắt lỗi nhập sai dữ liệu các phần tử của ma trận B
        checkB:
            int[,] B = new int[n2, p];
            string[,] B1 = new string[n2, p];
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write("Nhập vào phần tử B[{0},{1}]: ", i, j);
                    B1[i, j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    foreach (char pt in B1[i, j])
                    {
                        if (!char.IsDigit(pt))
                        {
                            Console.WriteLine("Dữ liệu nhập vào sai, vui lòng nhập lại!!!");
                            goto checkB;
                        }
                        else
                        {
                            B[i, j] = int.Parse(B1[i, j]);
                        }
                    }
                }
            }
            // In ma trận B
            Console.WriteLine("\nMa trận B:");
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write("{0} ", B[i, j]);
                }
                Console.WriteLine("");
            }
            // Tính toán các phần tử của ma trận tích
            double[,] AB = new double[m, p];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    AB[i, j] = 0;
                    for (int k = 0; k < n2; k++)
                    {
                        AB[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            // In ma trận tích AB 
            Console.WriteLine("\nTích của 2 ma trận trên là: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write("{0} ", AB[i, j]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
