using System;

namespace dontpanic
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            string dontpanic = "don't panic!".ToUpper();

            for (int i = dontpanic.Length - 1; i >= 0; i--)
            {
                Console.Write(dontpanic[i]);
            }




        }
    }
}
