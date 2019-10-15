using System;

/*6.Поміняти місцями мінімальний і максимальний елементи масиву
розміру N.*/

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Size of arr:");
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            var max=0;
            var min=0;
            var a=0;
            var b=0;
            for (int i = 0; i < N; i++)
            {
                Console.Write("arr[{0}]=", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("_________________________________");
            for (int i = 0; i < N; i++)
            {
                min = max = arr[0];
                if (min < arr[i])
                {
                    a = i;
                    min = arr[i];
                }
                if (max > arr[i])
                {
                    b = i;
                    max = arr[i];
                }
            }
            arr[a] = max;
            arr[b] = min;
                for (int i = 0; i < N; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
