using System;
using Raylib_cs;

namespace Raket
{
    class Program
    {
        static void Main(string[] args)
        {
            const int screenWidth = 800;
            const int screenHeight = 500;

            float x = 200;
            float y = 200;

            Raylib.InitWindow(screenWidth, screenHeight, "raket");
            
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.WHITE);
                Raylib.DrawRectangle((int)x, (int)y, 20, 50, Color.RED);


                Raylib.EndDrawing();
            }
        }
    }
}
