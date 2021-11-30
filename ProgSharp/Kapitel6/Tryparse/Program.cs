using System;

namespace Tryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            int iTal = 0;
            bool intQ = false;

            while (true)
            { 
                Console.Clear();

                intQ = false;
                while (!intQ)
                {
                    Console.WriteLine("Välj ett tal mellan 1 och 10");
                    string sTal = Console.ReadLine();
                    intQ = int.TryParse(sTal, out iTal);
                }
                
                Random rnd = new Random();

                int slumptal = rnd.Next(10)+1;

                if (iTal == slumptal)
                {
                    Console.WriteLine($"GG!");
                    Console.WriteLine($"Talet var {slumptal}!");
                }
                else
                {
                    Console.WriteLine($"Fel.");
                    Console.WriteLine($"Talet var {slumptal}.");
                }

                Console.WriteLine($"Vill du köra igen? (y/n)");
                if (Console.ReadKey().KeyChar != 'y')
                {
                    break;
                }
            }
        }
    }
}


//bool = int.TryParse([input], out [output])