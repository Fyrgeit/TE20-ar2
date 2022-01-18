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

            //float x = 200;
            //float y = 200;

            float xv = 0;
            float yv = 0;
            float x = 0;
            float y = 0;

            Raylib.InitWindow(screenWidth, screenHeight, "raket");
            Raylib.SetTargetFPS(60);

            Rectangle raket = new Rectangle();
            raket.x = 200;
            raket.y = 200;
            raket.width = 20;
            raket.height = 50;
            
            


            
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
                {
                    yv -= 0.25f;
                }

                //gravity
                yv += 0.1f;

                //simulate
                x += xv;
                y += yv;

                Raylib.DrawRectangleRec(raket, (Vector2){x, y}, 0, Color.RED);

                Raylib.EndDrawing();
            }
        }
    }
}
