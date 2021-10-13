using System;

namespace FullNameIntials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string username = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi");
            string lastname = Console.ReadLine();

            Console.WriteLine($"Tere {username[0]}. {lastname[0]}.");
        }
    }
}
