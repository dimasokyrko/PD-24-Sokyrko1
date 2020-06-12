using System;
using System.IO;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 99; i++)
            {
                DirectoryInfo folder = new DirectoryInfo($"Folder_{i}");
                folder.Create();
                if (folder.Exists)
                {
                    Console.WriteLine("FullName      : {0}", folder.FullName);
                    Console.WriteLine("Name          : {0}", folder.Name);
                    Console.WriteLine(new string('-', 50));
                }
                else
                {
                    Console.WriteLine("A directory with the name: {0} does not exist", folder.FullName);
                }
            }
            Console.WriteLine("Press any key to delete directories");
            Console.ReadKey();
            for (int i = 0; i <= 99; i++)
            {
                DirectoryInfo folder = new DirectoryInfo($"Folder_{i}");
                folder.Delete();
            }
            Console.WriteLine("Folders deleted successfully");
        }
    }
}