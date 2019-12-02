using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна__8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                ClassGarage garage = new ClassGarage();

                Console.WriteLine("To get started, add one car to the garage.");
                garage.AddCar();

                int n;

                do
                {
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("1)Add a car.");
                    Console.WriteLine("2)Remove the car.");
                    Console.WriteLine("3)Take the car.");
                    Console.WriteLine("4)End a program.");
                    do
                    {
                        n = Convert.ToInt32(Console.ReadLine());
                        if (n < 1 || n > 4)
                            Console.WriteLine("N must be anumber from 1 to 4.");
                    } while (n < 1 || n > 4);
                    switch (n)
                    {
                        case 1:
                            {
                                garage.AddCar();
                                break;
                            }
                        case 2:
                            {
                                garage.DeleteCar();
                                break;
                            }
                        case 3:
                            {
                                garage.GetCar();
                                break;
                            }
                        case 4:
                            {
                                break;
                            }
                    }
                } while (n != 4);
                Console.ReadKey();
            }
        }
    }
}
