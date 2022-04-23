using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вкажить будь ласка ширину масиву");
            int N = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine();

            Console.WriteLine("Вкажить будь ласка висоту масиву");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            int[,] num = new int[M, N];
            num[M / 2, N / 2] = 1;
            int k = M * N;

            for (int y = 0; y < N; y++)
            {
                for (int x = M - y - 1; x > y; x--)
                {
                    num[x, y] = k--;
                }
                for (int x = y; x <= M - y - 1; x++)
                {
                    num[y, x] = k--;
                }
                for (int x = y + 1; x <= M - y - 1; x++)
                {
                    num[x, M - 1 - y] = k--;
                }
                for (int x = M - 2 - y; x > y; x--)
                {
                    num[M - 1 - y, x] = k--;
                }
            }
            for (int y = 0; y < N; y++)
            {
                for (int x = 0; x < M; x++)
                {
                    Console.Write(num[y, x]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}
