using System;

namespace Övning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            
            
            Console.WriteLine("Skriv ett substantiv man kan sätta \"ett\" framför.");
            string sub1 = Console.ReadLine();
            
            Console.WriteLine("Skriv ett djur man kan sätta \"en\" framför.");
            string djur = Console.ReadLine();
            
            Console.WriteLine("Skriv ett namn.");
            string namn = Console.ReadLine();
            
            Console.WriteLine("Skriv ett sätt att färdas.");
            string färd = Console.ReadLine();

            Console.WriteLine("Skriv ett substantiv som man kan sätta \"en\" framför.");
            string sub2 = Console.ReadLine();

            Console.WriteLine("Skriv ett verb i dåtid.");
            string verb1 = Console.ReadLine();
            
            Console.WriteLine("Skriv ett adjektiv som slutar med ett \"t\".");
            string adj1 = Console.ReadLine();

            Console.WriteLine("Skriv ett adjektiv som *inte* slutar med ett \"t\".");
            string adj2 = Console.ReadLine();

            


            


            Console.WriteLine($"Det var en gång en {adj2} {djur} som hette {namn}.");
            Console.WriteLine($"{namn} bodde i ett {adj1} {sub1}.");
            Console.WriteLine($"Varje dag brukade {namn} {färd} till en {sub2} där han tyvärr {verb1}.");
        }

        static void lnbr()
        {
            Console.WriteLine();
        }
    }
}
