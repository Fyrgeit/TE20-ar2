using System;

namespace GissaTal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("Välkommen till gissa ett tal!");
            Console.WriteLine("Spelet där du gissar ett tal!");

            Console.WriteLine($"Skriv 'y' för att börja");
            string ans = Console.ReadLine();

            while (ans == "y")
            {
                Console.WriteLine("Jag tänker på ett tal mellan 0 och 999.");

                Random slump = new Random();
                int tal = slump.Next(1000);

                int gissning = 1000;

                while (gissning != tal)
                {  
                    Console.Write("Gissning? ");
                    gissning = int.Parse(Console.ReadLine());
                    
                    if (gissning > tal)
                    {
                        Console.WriteLine("För högt.");
                        
                    }
                    else if(gissning < tal)
                    {
                        Console.WriteLine("För lågt.");
                        
                    }
                    else
                    {
                        Console.WriteLine("Du gissade rätt!");
                    }
                }

                Console.WriteLine("Vill du spela igen? (y/n)");
                ans = Console.ReadLine();
            }

            Console.WriteLine("Thank you so much for a playing my game!");
        }
    }
}
