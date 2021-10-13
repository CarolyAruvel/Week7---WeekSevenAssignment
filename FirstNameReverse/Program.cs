using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string username = Console.ReadLine();

            for (int i = username.Length - 1; i >= 0; i--)
            {
                if (username.Length > 5)
                {
                    Console.Write(username[i]);
                }
                else
                {
                    Console.WriteLine(username);
                    break;
                }
            }
        }
    }
}
