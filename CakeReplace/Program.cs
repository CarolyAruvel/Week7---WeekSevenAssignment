using System;

namespace CakeReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string cakeisalie = "The c4ke i3 4 l1e";
            cakeisalie = cakeisalie.Replace('1', 'i');
            cakeisalie = cakeisalie.Replace('4', 'a');
            cakeisalie = cakeisalie.Replace('3', 's');

            Console.WriteLine(cakeisalie);

            Console.ReadLine();
        }
    }
}
