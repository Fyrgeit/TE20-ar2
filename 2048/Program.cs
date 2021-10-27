using System;

namespace _2048
{
    class Program
    {
        public static int getnum(int n, string map)
        {
            return (int)map[n]-97;
        }

        static void Main(string[] args)
        {
            string map = "aaabaacbacddbbde";

            for (var y = 0; y < 4; y++)
            {
                for (var x = 0; x < 4; x++)
                {
                    Console.Write(getnum(x+y*4, map));
                }   
                Console.Write("\n");
            }

            // /------\
            // |      |
            // |-2048-|
            // |      |
            // \------/
        }
    }
}
