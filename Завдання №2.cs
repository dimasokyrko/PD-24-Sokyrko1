using System;
//Варіант №6
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn;
            int nk;
            do
            {
                Console.Write("nn= ");
                nn = int.Parse(Console.ReadLine());
                if (nn < 0)
                    Console.WriteLine("nn<0");
            } while (nn < 0);
            do
            {
                Console.Write("nk= ");
                nk = int.Parse(Console.ReadLine());
                if (nk < nn)
                    Console.WriteLine("nn<0");
            } while (nk < nn);
            double sum = 0.0;
            for (int k = nn; k <= nk + 1; k++)
            {
                double ak = ((-1) ^ (k ^ 2 + 1) * k ^ 2 - 2) / (3 * k ^ 2 - 2 * k);
                sum = sum + ak;
            }
            Console.WriteLine("all sum= {0}", sum);
            Console.ReadLine();
        }
    }
}