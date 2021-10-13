using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string username = Console.ReadLine();

                Console.WriteLine("Sisesta palun PIN kood:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Sisesta parool:");
                string password = Console.ReadLine();
            
                if (username != "user1" || password != "password1" || userPIN == 1532)
                {
                    Console.WriteLine("Vale password või kastutaja nimi. Proovi uuesti.");
                }
                else if (username != "user1" || password != "password1" || userPIN != 1532)
                {
                    Console.WriteLine("Midagi läks valesti! Proovi uuesti.");
                }
                else
                {
                    i = i + 1; 
                        Console.WriteLine($"Proovi uuesti. {3 - i} katset jäänud");
                }
            }
            
            
            Console.WriteLine("Head päeva!");
        } 
    }
}
