using System;

namespace Labb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("Skriv in ett meddelande du vill kryptera.");
            string input = Console.ReadLine();

            Console.WriteLine($"Med hur många steg vill du förskjuta meddelandet?");
            int shift = int.Parse(Console.ReadLine());

            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            Console.WriteLine($"Vill du använda det vanliga engelska alfabetet? (j/n)");
            
            if (Console.ReadLine() == "n")
            {
                Console.WriteLine($"Skriv in det alfabetet du vill använda. (Alla bokstäver, inga mellanslag)");
                alphabet = Console.ReadLine().ToLower();
            }

            int intput = 0;
            string output = "";
            
            input = input.ToLower();

            for (var i = 0; i < input.Length; i++)
            {
                if (alphabet.Contains(input[i]))
                {
                    for (var j = 0; j < alphabet.Length; j++)
                    {
                        if (input[i] == alphabet[j])
                        {
                            intput = j;
                        }
                    }

                    intput += shift;

                    if (intput >= alphabet.Length)
                    {
                        intput -= alphabet.Length;
                    }

                    output += alphabet[intput];
                }
                else
                {
                    output += input[i];
                }
            }

            Console.WriteLine($"Ditt krypterade meddelande är:");
            Console.WriteLine($"{output}");
        }
    }
}
