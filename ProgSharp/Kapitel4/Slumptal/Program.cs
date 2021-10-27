using System;

namespace Slumptal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int tal1 = 0, tal2 = 0;
            int result;
            int täljare = 0;
            int nämnare = 100000;
            
            for (int i = 0; i < nämnare; i++)
            {
                tal1 = random.Next(0, 7);
                tal2 = random.Next(0, 7);
                result = tal1 + tal2;
                Console.WriteLine($"{i}: [{tal1} + {tal2} = {result}]");
                if (result == 12)
                {
                    täljare++;
                }
                //System.Threading.Thread.Sleep(10);
            }

            Console.WriteLine($"Hittade {täljare} tolvor på {nämnare} tärningskast.");
            
        }
    }
}
