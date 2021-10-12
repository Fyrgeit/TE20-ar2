using System;

namespace _4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket är Europas folkrikaste land?");

            int gissningar = 1;
            string ans;

            while (gissningar < 6)
            {
                ans = Console.ReadLine();

                if (ans.ToLower() == "ryssland")
                {
                    Console.WriteLine($"{ans} är rätt! Du klarade det på {gissningar} gissning(ar)."); 
                    break;  
                } 
                else
                {
                    Console.WriteLine("Fel svar!");
                    gissningar++;
                }
            }

            if (gissningar > 5)
            {
                Console.WriteLine($"Du klarade det inte ens på fem gissningar :(");
            }
        }
    }
}
