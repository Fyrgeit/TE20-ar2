using System;

namespace Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Välkommen till frågesporten!");
            Console.WriteLine();

            string[,] qna = {
                {"Vilket är världens största land till yta?", "ryssland"},
                {"Hur många invånare har Sverige? (Närmaste miljontal)", "10"},
                {"Vad heter Estlands huvudstad?", "tallin"},
                {"Hur många år gammal måste man vara för att ta körkort i Sverige?", "18"},
                {"I vilket land ligger Eiffeltornet?", "frankrike"}
            };

            string[] playerAnswers = new string[qna.GetLength(0)];
            int results = 0;

            for (var i = 0; i < qna.GetLength(0); i++)
            {
                Console.WriteLine($"{qna[i, 0]}");

                playerAnswers[i] = Console.ReadLine().ToLower();

                if (playerAnswers[i] == qna[i, 1])
                {
                    Console.WriteLine("Rätt svar!");
                }
                else
                {
                    Console.WriteLine($"Fel svar!");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Tryck på en tangent för att visa resultaten.");
            Console.ReadKey();
            Console.Clear();

            for (var i = 0; i < qna.GetLength(0); i++)
            {
                Console.Write($"Ditt svar: \"{playerAnswers[i]}\", rätt svar: \"{qna[i, 1]}\", ");

                if (playerAnswers[i] == qna[i, 1])
                {
                    Console.WriteLine($"du svarade rätt!");
                    results++;
                }
                else
                {
                    Console.WriteLine($"du svarade fel.");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Du fick {results}/{qna.GetLength(0)} poäng.");
            Console.ReadKey();
        }
    }
}
