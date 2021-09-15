using System.Data;
using System;

namespace arrows
{
    class Program
    {
        static void Main(string[] args)
        {
            string key;
            
            while (true)
            {
                key = Convert.ToString(Console.ReadKey(false));

                if (key == Convert.ToString(ConsoleKey.RightArrow))
                {
                    Console.WriteLine("right");
                }
            }
        }
    }
}
