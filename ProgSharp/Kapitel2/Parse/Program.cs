using System;

namespace Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            //assign names of units
            string unit1name = "[unassigned unit]";
            string unit2name = "[unassigned unit]";
            
            //input unit1
            System.Console.WriteLine("Please enter first unit: (1-4)");
            System.Console.WriteLine("1: Meter");
            System.Console.WriteLine("2: Decimeter");
            System.Console.WriteLine("3: Centimeter");
            System.Console.WriteLine("4: Millimeter");

            int unit1 = int.Parse(Console.ReadLine());
        
            //input unit2
            System.Console.WriteLine("Please enter second unit: (1-4)");
            System.Console.WriteLine("1: Meter");
            System.Console.WriteLine("2: Decimeter");
            System.Console.WriteLine("3: Centimeter");
            System.Console.WriteLine("4: Millimeter");

            int unit2 = int.Parse(Console.ReadLine());

            //input input
            System.Console.WriteLine("Please enter a value");

            double input = double.Parse(Console.ReadLine());

            //initialize output
            double output = input;

            //convert to meter
            switch (unit1)
            {
                case 1:
                    output /= 1;
                    unit1name = "Meter(s)";
                    break;
                case 2:
                    output /= 10;
                    unit1name = "Decimeter(s)";
                    break;
                case 3:
                    output /= 100;
                    unit1name = "Centimeter(s)";
                    break;
                case 4:
                    output /= 1000;
                    unit1name = "Millimeter(s)";
                    break;
            }

            //convert to selected unit
            switch (unit2)
            {
                case 1:
                    output *= 1;
                    unit2name = "Meter(s)";
                    break;
                case 2:
                    output *= 10;
                    unit2name = "Decimeter(s)";
                    break;
                case 3:
                    output *= 100;
                    unit2name = "Centimeter(s)";
                    break;
                case 4:
                    output *= 1000;
                    unit2name = "Millimeter(s)";
                    break;
            }
            
            //round result
            output = Math.Round(output, 3);

            //print results
            System.Console.WriteLine($"{input} {unit1name} is equal to {output} {unit2name}.");
        }
    }
}