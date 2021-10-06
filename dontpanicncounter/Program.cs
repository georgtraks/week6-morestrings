using System;

namespace dontpanicncounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string dontpanic = "don't panic!".ToUpper();
            int counter = 0;

            for (int i = 0; i < dontpanic.Length; i++)
            {
                if (dontpanic[i] == 'n')
                {
                    counter++;
                }
            }

            Console.WriteLine($"sõnas {dontpanic} on {counter} 'n' tähte.");


        }
    }
}
