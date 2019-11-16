using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*6.Створити ліст інтових змінних, який може вміщати тільки 1 і 0,
заповнити його з клавіатури.Порахувати кількість 1 і 0. Скопіювати
отриманий ліст в масив.*/
namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int K;
            int size;
            int a = 0;
            int b = 0;
            List<int> list = new List<int>();
            do
            {
                Console.Write("Size of list:");
                size = int.Parse(Console.ReadLine());
                if (size < 1)
                    Console.WriteLine("size must be >0");
            } while (size < 1);
            int N = size;
            int[] arr = new int[N];
            do
            {
                do
                {
                    Console.Write("Number that you need to add to list:");
                    K = int.Parse(Console.ReadLine());
                    if ((K != 1) && (K != 0))
                        Console.WriteLine("Number must be 1 or 0");
                } while ((K != 1) && (K != 0));
                list.Add(K);
                size--;
            } while (size != 0);
            foreach (int i in list)
            {
                Console.Write("{0}  ", i);
            }
            foreach (int i in list)
            {
                if (i == 0)
                    a++;
                else
                    b++;
            }
            Console.WriteLine();
            Console.WriteLine("kilkist 0 = {0}",a);
            Console.WriteLine("kilkist 1 = {0}",b);
            int j = 0;
            foreach (int i in list)
            {
                arr[j] = i;
                j++;
            }
            for(int i = 0; i < N; i++)
            {
                Console.WriteLine("arr[{0}]={1}", i, arr[i]);
            }
            Console.ReadLine();
        }
    }
}