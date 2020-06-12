using System;
using System.IO;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = $"Folder_{0}";
            for (int i = 0; i < 10; i++)
            {
                DirectoryInfo folder = new DirectoryInfo(temp);
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
                temp += $"/Folder_{i + 1}";
            }
            Console.WriteLine("Press any key to delete directories");
            Console.ReadKey();
            Directory.Delete($"Folder_{0}", true);
        }
    }
}