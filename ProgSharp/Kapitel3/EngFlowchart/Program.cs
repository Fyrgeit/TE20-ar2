using System;
using System.Text;

namespace EngFlowchart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.OutputEncoding = Encoding.UTF8;

            int sum = 0;

            Console.WriteLine("🔧 Welcome to the engineering flowchart! 🔩");
            Console.WriteLine("Does it move? 🤔 (y/n)");
            
            string ans1 = Console.ReadLine().ToLower();

            if (ans1 == "y")
            {
                sum ++;
            }
            else if (ans1 == "n")
            {
                
            }
            else
            {
                Console.WriteLine($"'{ans1}' is not a valid answer.");
            }

            Console.WriteLine("Should it move? 🤔 (y/n)");
            
            string ans2 = Console.ReadLine().ToLower();

            if (ans2 == "y")
            {

            }
            else if (ans2 == "n")
            {
                sum ++;
            }
            else
            {
                Console.WriteLine($"'{ans2}' is not a valid answer.");
            }

            switch (sum)
            {
                case 0:
                    Console.WriteLine("Använd olja 😁");
                    break;
                case 1:
                    Console.WriteLine("Inga problem! ✅");
                    break;
                case 2:
                    Console.WriteLine("Använd silvertejp 😁");
                    break;
                default:
                    break;
            }
        }
    }
}
