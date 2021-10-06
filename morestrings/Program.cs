using System;

namespace morestrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi:");
            string firstname = Console.ReadLine();
            Console.WriteLine("sisesta oma pereknnanimi:");
            string lastname = Console.ReadLine();

            Console.WriteLine($"tere tulemast {firstname[0]}{lastname[0]}");





        }
    }
}
