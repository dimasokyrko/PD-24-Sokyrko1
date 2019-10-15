using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*21. Дані два числа k1 і k2 і матриця розміру 4 x 10. Поміняти місцями
рядки(стовпчики) матриці з номерами k 1 і k 2*/
namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 10];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = rnd.Next(0,100);
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(String.Format("{0,3}", arr[i, j]));
                    Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("__________________________________________________");
            Console.WriteLine();
            /*Заміна рядків
            int[] a = new int[10];
            int k1;
            int k2;
               do {
                Console.Write("k1:");
                k1 = int.Parse(Console.ReadLine());
                if (k1 < 0 && k1 > 4)
                    Console.WriteLine("k1 must be >0 and <N ");
            } while (k1 < 0 && k1 > 4);
            do
            {
                Console.Write("k2:");
                k2 = int.Parse(Console.ReadLine());
                if (k2 < 0 && k2 > 4)
                    Console.WriteLine("k2 must be >0 and <N ");
            } while (k2 < 0 && k2 > 4);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    a[j] = arr[k1, j];
                    
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[k1, j] = arr[k2, j];

                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[k2, j] = a[j];
                }
            }*/
            /*Заміна стовбчиків
             * int[] a = new int[4];
            int k1;
            int k2;
               do {
                Console.Write("k1:");
                k1 = int.Parse(Console.ReadLine());
                if (k1 < 0 && k1 > 10)
                    Console.WriteLine("k1 must be >0 and <N ");
            } while (k1 < 0 && k1 > 10);
            do
            {
                Console.Write("k2:");
                k2 = int.Parse(Console.ReadLine());
                if (k2 < 0 && k2 > 10)
                    Console.WriteLine("k2 must be >0 and <N ");
            } while (k2 < 0 && k2 > 10);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    a[i] = arr[i, k1];

                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i, k1] = arr[i, k2];

                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i, k2] = a[i];
                }
            }*/
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(String.Format("{0,3}", arr[i, j]));
                    Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
