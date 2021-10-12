using System;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket är världens folkrikaste land?");

            string ans;

            ans = Console.ReadLine();

            while (ans.ToLower() != "kina")
            {
                Console.WriteLine($"Fel, gissa igen!");
                ans = Console.ReadLine();
            }

            Console.WriteLine($"{ans} är rätt svar!");
        }
    }
}
