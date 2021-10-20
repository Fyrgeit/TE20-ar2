using System;

namespace Ceasar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Input a string that you want to cipher.");
            string input = Console.ReadLine();

            int letter = 40;
            int shortPunct = 200;    
            int longPunct = 500;    

            for (var i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
                
                if (input[i] == '.' || input[i] == '!' || input[i] == '?')
                {
                    System.Threading.Thread.Sleep(longPunct);
                }
                else if (input[i] == ',')
                {
                    System.Threading.Thread.Sleep(shortPunct);
                }
                else
                {
                    System.Threading.Thread.Sleep(letter);
                }
            }
        }
    }
}
