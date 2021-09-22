using System;

namespace InteraktivBerättelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("Du vaknar upp i en skogsglänta och det gör ont i hela kroppen.");
            Console.WriteLine("Ditt ansikte är blodigt. Längre fram i skogen finns en stig.");
            Console.WriteLine("Följer du stigen eller torkar du ansiktet först? (stig, torka)");

            string ans1 = Console.ReadLine().ToLower();
            
            if(ans1 == "stig")
            {
                Console.WriteLine("Du följer stigen ett tag tills du kommer framm till en präktig borg.");
                Console.WriteLine("Framför borgen står en hotfull vakt. Han stirrar argt på dig");
                Console.WriteLine("Går du fram till vakten eller går du längs med borgen på avstånd? (vakt, gå)");
                
                string ans2 = Console.ReadLine().ToLower();

                if(ans2 == "vakt")
                {
                    Console.WriteLine("Du närmar dig vakten. Vakten utropar:");
                    Console.WriteLine("\"Hur vågar du närma dig drottningens slott när du ser ut så i ansiktet!\"");
                    Console.WriteLine("Sedan spetsar han dig med sin lans. Du är död. Berättelsen är över.");
                }
                else if(ans2 == "gå")
                {
                    Console.WriteLine("Du följer borgens murar ett tag tills du kommer till en damm.");
                    Console.WriteLine("Vid dammen sitter drottningen som är ute på promenad.");
                    Console.WriteLine("\"Vem e du? Du ska dö tyvärr\", säger hon.");
                    Console.WriteLine("Sedan spetsar hon dig med sin lans. Du är död. Berättelsen är över.");
                }
                else
                {
                    Console.WriteLine($"[kunde inte förstå svaret \"{ans2}\". Börja om.]");
                }
            }
            else if(ans1 == "torka")
            {
                Console.WriteLine("Du torkar ansiktet och följer sedan stigen ett tag tills du kommer framm till en präktig borg.");
                Console.WriteLine("Framför borgen står en hotfull vakt. Han ler lungt till dig");
                Console.WriteLine("Går du fram till vakten eller står du kvar och stirrar intensivt på honom? (vakt, stirra)");

                string ans2 = Console.ReadLine().ToLower();

                if(ans2 == "vakt")
                {
                    Console.WriteLine("Ni blir goda vänner och lever lyckliga i alla era dar. Du vann!");
                }
                else if(ans2 == "stirra")
                {
                    Console.WriteLine("Vakten stirrar tillbaka ännu mer intensivt.");
                    Console.WriteLine("Du kan inte hantera hans stirr. Du är död. Berättelsen är över.a");
                    
                }
                else
                {
                    Console.WriteLine($"[kunde inte förstå svaret \"{ans2}\". Börja om.]");
                }
            }
            else
            {
                Console.WriteLine($"[kunde inte förstå svaret \"{ans1}\". Börja om.]");
            }
            
            Console.ReadKey();
        }
    }
}
