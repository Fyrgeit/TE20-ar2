using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine("Gillar du kebab?");
            string svar = Console.ReadLine();
            Console.WriteLine($"\"{svar}\"? Vilket dåligt svar.");
        }
    }
}
