using System;
//6. Перевірити істинність вислову: "Дане ціле число є непарним тризначним числом". 
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvesty chislo : ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 != 1 || (a <= 999 || a >= 100))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            Console.ReadLine();
        }
    }
}