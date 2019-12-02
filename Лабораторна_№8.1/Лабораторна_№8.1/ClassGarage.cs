using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна__8._1
{
    class ClassGarage
    {
        List<ClassCars> cars = new List<ClassCars>();

        protected ClassCars Enter_Information()
        {
            string name;
            string color;
            int speed = 0;
            int year = 0;

            do
            {
                Console.Write("Enter name of car: ");
                name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("Please enter a name.");
                }
            } while (name == "");

            do
            {
                Console.Write("Enter color of car: ");
                color = Console.ReadLine();
                if (color == "")
                {
                    Console.WriteLine("Pleas enter a color.");
                }
            } while (color == "");

            do
            {
                Console.Write("Enter speed of car: ");
                try
                {
                    speed = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                if (speed <= 0 || speed>=1230)
                {
                    Console.WriteLine("Speed cannot be negative or = 0 or more than 1230(record of speed on car).");
                }
            } while (speed <= 0 || speed >= 1230);

            do
            {
                Console.Write("Enter year of creation of car: ");
                try
                {
                    year = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                if (year < 1768 || year > DateTime.Today.Year)
                {
                    Console.WriteLine("Year of creation can be in the range from 1768(year of first car creating) to present day.");
                }
            } while (year < 1768 || year > DateTime.Today.Year);

            return new ClassCars(name, color, speed, year);
        }


        public void AddCar()
        {
            cars.Add(Enter_Information());
        }

        public void ViewCars()
        {
            Console.WriteLine("All your cars:");
            Console.WriteLine(" Number  Name    Color   Speed   Year of creation\n");
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {cars[i].Namecar} - {cars[i].Colorcar} - {cars[i].Carspeed} - {cars[i].Graduationyear}");
            }
        }

        public void DeleteCar()
        {
            ViewCars();
            int a;
            if (cars.Count == 0)
            {
                Console.WriteLine("You cannot remove a car because you do not have it.");
            }
            else
            {
                do
                {
                    Console.Write("Enter number of car what You want to delete=");
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a < 1 || a > cars.Count + 1)
                    {
                        Console.WriteLine("Please try again.");
                    }
                    else
                    {
                        Console.WriteLine("You delete a car number {0} from garage.", a);
                    }
                } while (a < 1 || a > cars.Count + 1);
                cars.RemoveAt(a - 1);
            }
        }


        public void GetCar()
        {
            ViewCars();
            int a;
            if (cars.Count == 0)
            {
                Console.WriteLine("You can't take a car because you don't have one.");
            }
            else
            {
                do
                {
                    Console.Write("What number of car do you want to take=");
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a - 1 < 0 || a - 1 > cars.Count)
                    {
                        Console.WriteLine("Please try again.");
                    }
                    else
                    {
                        Console.WriteLine("You pick a car number {0} from the garage.", a);
                    }
                } while (a - 1 < 0 || a - 1 > cars.Count);
            }
        }
    }
}
