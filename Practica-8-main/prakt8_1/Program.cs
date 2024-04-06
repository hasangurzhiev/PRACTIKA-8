using System;
using System.IO;
namespace ConsoleApplication1
{
    class Class1
    {
        static void DirInfo(DirectoryInfo di)
        {  
            Console.WriteLine("===== Directory Info=====");
            Console.WriteLine(" Full Name: " + di.FullName);
            Console.WriteLine(" Name: " + di.Name);
            Console.WriteLine(" Parent: " + di.Parent);
            Console.WriteLine("Creation: " + di.CreationTime);
            Console.WriteLine(" Attributes: " + di.Attributes);
            Console.WriteLine(" Root: " + di.Root);
            Console.WriteLine("====================");
        }
        static void Main()
        {
            DirectoryInfo di1 = new DirectoryInfo(@"D:\IS-22\MyDir");
            DirectoryInfo di2 = new DirectoryInfo(@"D:\IS-22\MyDir\temp");
            try
            {  
                di1.Create();
                di2.Create();
                DirInfo(di1);
                DirInfo(di2);     
                Console.WriteLine("Попытка удалить {0}.", di1.Name);
                di1.Delete();
            }
            catch (Exception)
            { Console.WriteLine("Попытка не удалась "); }
        }
    }
}
