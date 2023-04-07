using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yêu cầu nhập dữ liệu từ người dùng
            Console.Write("Nhap vao so hang cua ma tran: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao so cot cua ma tran: ");
            int y = Convert.ToInt32(Console.ReadLine());

            // Tạo một ma trận với các phần tử ngẫu nhiên dựa trên số hàng và số cột
            Random random = new Random();
            int[,] matrix = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                }
            }

            /* Tạo một ma trận với các phần tử được nhập từ người dùng dựa trên số hàng và số cột
             
            int[,] matrix = new int[x, y];

            for (int i = 0; i < x; ++i)
            {
                for (int j = 0; j < y; ++j)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            */

            // Xuất ma trận ra màn hình
            Console.WriteLine();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(matrix[i, j] + ", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Tìm Max và tọa độ của Max
            int posx = matrix.GetLength(0);
            int poxy = matrix.GetLength(1);

            int max = matrix.Cast<int>().Max();

            for (int i = 0; i < posx; ++i)
            {
                for (int j = 0; j < poxy; ++j)
                {
                    if (matrix[i, j].Equals(max))
                    {
                        Console.WriteLine("Toa do cua phan tu lon nhat la o hang " + (i + 1) + " cot " + (j + 1));
                        Console.WriteLine("Phan tu lon nhat la: " + max);
                    }
                }
            }
        }
    }
}
