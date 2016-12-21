using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args[0] == null)
        {
            System.Console.Write("Brak parametru");
            Environment.Exit(0);
        }
        else
        {
            if (Directory.Exists(args[0]))
            {
                System.Console.Write("Katalog istnieje");
            }
            else
            {
                System.Console.Write("Katalog nie istnieje");
            }

        }

    }
}