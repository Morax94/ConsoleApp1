using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length==0)
        {
            Console.Write("Brak parametru");
            Console.ReadKey();
            Environment.Exit(0);
        }
        else
        { 
            if (Directory.Exists(args[0]))
            {
                Console.Write("Katalog istnieje");
                DirectoryInfo[] path = new DirectoryInfo(args[0]).GetDirectories();
                for (int i=0; i< path.Length; i++)
                {
                   
                        Console.WriteLine(path[i]);
                }               
                Console.ReadKey();
            }
            else
            {
                Console.Write("Katalog nie istnieje");
            }

        }

    }
}