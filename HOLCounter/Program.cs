using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "hello world!".ToLower();

            int counterH = 0;
            int counterO = 0;
            int counterL = 0;

            for (int i = 0; i < helloworld.Length; i++)
            {
                if (helloworld[i] == 'h')
                {
                    counterH++;
                }
                else if (helloworld[i] == 'o')
                {
                    counterO++;
                }
                else if (helloworld[i] == 'l')
                {
                    counterL++;
                }
                else
                {
                    continue;
                }

                Console.WriteLine($"lauses {helloworld} on {counterH} 'h' tähte, {counterO} 'o' tähte ja {counterL} 'l' tähte");


            }
        }
    }
}
