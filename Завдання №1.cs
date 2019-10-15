using System;
/*6.Обчислити об'єм циліндра за відомими висотою та радіусом основи*/
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radius: ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Visota: ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("Obiem = ");
            Console.WriteLine(Math.PI * r * r * h);
            Console.ReadKey();
        }
    }
}