using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args[0] == null)
        {
            Console.Write("Brak parametru");
            Environment.Exit(0);
        }
        else
        {
            if (Directory.Exists(args[0]))
            {
                Console.Write("Katalog istnieje");
            }
            else
            {
                Console.Write("Katalog nie istnieje");
            }

        }

    }
}