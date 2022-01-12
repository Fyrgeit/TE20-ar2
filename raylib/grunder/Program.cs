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

            Color blue = new Color(0, 9, 171, 255);
            Color red = new Color(222, 33, 16, 255);

            int x = 50;
            int y = 50;

            int speed = 5;

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.WHITE);
                
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {x+=speed;}
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {x-=speed;}
                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {y+=speed;}
                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {y-=speed;}

                Raylib.DrawCircle(400, 250, 200, red);
                Raylib.DrawCircle(400, 250, 130, Color.WHITE);
                Raylib.DrawRectangle(150, 210, 500, 80, blue);
                Raylib.DrawText("UNDERGROUND", 175, 223, 60, Color.WHITE);
                
                Raylib.DrawCircle(x, y, 30, Color.BLUE);

                Raylib.EndDrawing();
            }
        }
    }
}
