using System;

namespace mans_1._3_1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("\"Hej\" hörde jag någon säga på stan.");
            Console.WriteLine("Efter en stund svarade någon annan också med ett \"Hej\".");

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("lorem ipsum dolor sit amet");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Du är nästan klar med kapitel 1."); //skriver ut den första raden
            Console.WriteLine("Du har lärt dig skriva ut tecken som \" och \\."); // skriver ut den andra raden och tecknet '\' används för att skriva tecken som vanligtvis har funktioner

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("  WINDOWS HAS UNEXPECTEDLY CRASHED  ");
            Console.WriteLine("          ERROR_0x_173_5            ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("   /\\   ");
            Console.WriteLine("  /  \\  ");
            Console.WriteLine(" / \"\" \\ ");
            Console.WriteLine("/______\\");

            Console.ReadKey();
        }
    }
}
