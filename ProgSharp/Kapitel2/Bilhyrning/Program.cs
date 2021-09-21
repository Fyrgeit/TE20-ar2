using System;

namespace Bilhyrning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jaså det är dags att hyra en bil!");
            Console.WriteLine("Hur många dagar vill min unge herre hyra bilen?");

            int dagar = int.Parse(Console.ReadLine());

            Console.WriteLine("Absolut, absolut.");
            Console.WriteLine("Och hur många kilometer har ni tänkt köra?");

            int kilometer = int.Parse(Console.ReadLine());
            
            int hyra = 300 + (dagar - 1) * 500 + kilometer;

            Console.WriteLine($"Ja, då stiger hyran upp till hela {hyra} riksdaler!");
        }
    }
}
