using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada eesnime
            //programm kuvab juhuslikku tähte eesnimes

            Console.WriteLine("Sisesta eesnimi:");
            string username = Console.ReadLine();
            Random rnd = new Random();

            int i = rnd.Next(0, username.Length - 1);
            Console.WriteLine(username[i]);
        }
    }
}
