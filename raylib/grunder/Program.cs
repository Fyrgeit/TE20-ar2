using System;
using Raylib_cs;

namespace grunder
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 500, "raylibtest");

            Raylib.SetTargetFPS(60);

            int x = 50;
            int y = 50;

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.BLUE);

                if (Raylib.IsKeyPressed(KEY_RIGHT))
                {
                    x++;
                }

                Raylib.DrawRectangle(x, y, 50, 50, Color.WHITE);

                Raylib.EndDrawing();
            }
        }
    }
}
