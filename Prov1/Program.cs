using System;

namespace Prov1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans = "y";
            
            while (ans == "y")
            {
                while (true)
                {
                    //Rensar consolen
                    Console.Clear();
                    
                    //Första frågan
                    Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~  ");
                    Console.WriteLine("-| Uträkning av bruttolön |-");
                    Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~  ");
                    Console.Write("Vad heter du? ");

                    //Hämtar namnet
                    string namn = Console.ReadLine();
                    
                    //De andra frågorna
                    Console.Write("Ange din bruttolön i kr (10000kr - 45000kr): ");
                    int bruttoLön = int.Parse(Console.ReadLine());

                    if (bruttoLön < 10000)
                    {
                        Console.WriteLine($"{namn}, bruttolön måste vara mer än 10000kr!");
                        Console.WriteLine($"Vänligen försök igen.");
                        break;
                    }

                    if (bruttoLön > 45000)
                    {
                        Console.WriteLine($"{namn}, bruttolön måste vara mindre än 45000kr!");
                        Console.WriteLine($"Vänligen försök igen.");
                        break;
                    }

                    Console.Write("Ange din skattesats i % (10% - 40%): ");
                    float skatteSats = int.Parse(Console.ReadLine());

                    if (skatteSats < 10f)
                    {
                        Console.WriteLine($"{namn}, skattesatsen måste vara mer än 10%!");
                        Console.WriteLine($"Vänligen försök igen.");
                        break;
                    }

                    if (skatteSats > 40f)
                    {
                        Console.WriteLine($"{namn}, bruttolön måste vara mindre än 40%!");
                        Console.WriteLine($"Vänligen försök igen.");
                        break;
                    }

                    //Beräkning
                    double nettoLön = Math.Round(bruttoLön - (100f - skatteSats)/100f);

                    //Skriv ut reslutat
                    Console.WriteLine($"{namn}, din nettolön är {nettoLön}kr!");
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                }
                Console.Write("Kör igen? (y/n) ");
                ans = Console.ReadLine(); 
            }            
        }
    }
}
