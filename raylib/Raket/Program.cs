using System;
using System.Numerics;
using Raylib_cs;

namespace Raket
{
    class Program
    {
        static void Main(string[] args)
        {
            const int screenWidth = 800;
            const int screenHeight = 500;

            Raylib.InitWindow(screenWidth, screenHeight, "raket");
            Raylib.SetTargetFPS(60);

            //Camera2D camera = { 0 };

            Rectangle rocketSqr = new Rectangle();
            rocketSqr.x = 100;
            rocketSqr.y = 100;
            rocketSqr.width = 20;
            rocketSqr.height = 50;
            
            Vector2 origin = new Vector2(10, 25);
            Vector2 velocity = new Vector2(0, 0);

            float angle = 0;

            Color rocketClr = new Color(255, 0, 0, 255);
            Color bgClr = new Color(255, 255, 255, 64);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.DrawRectangle(0, 0, screenWidth, screenHeight, bgClr);
                Raylib.DrawRectangle(0, 0, 100, 100, Color.WHITE);

                rocketClr = Color.BLACK;

                Raylib.DrawRectangle(0, 450, screenWidth, 50, Color.BLUE);

                if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
                {
                    velocity.X += (float)(0.25*Math.Sin(angle*Math.PI/180));
                    velocity.Y -= (float)(0.25*Math.Cos(angle*Math.PI/180));

                    rocketClr = Color.RED;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                    angle += 3;
                    
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                    angle -= 3;

                //gravity
                
                velocity.Y += 0.1f;

                //simulate
                rocketSqr.x += velocity.X;
                rocketSqr.y += velocity.Y;

                if (rocketSqr.y >= 450)
                {
                    rocketSqr.y -= velocity.Y;
                    velocity.Y *= -0.5f;
                    velocity.X *= 0.5f;
                    while (rocketSqr.y < 449)
                    {
                        rocketSqr.y ++;
                    }
                }

                Raylib.DrawRectanglePro(rocketSqr, origin, angle, rocketClr);

                Raylib.DrawText($"X: {rocketSqr.x}", 10, 5, 10, Color.BLACK);
                Raylib.DrawText($"Y: {rocketSqr.y}", 10, 15, 10, Color.BLACK);
                Raylib.DrawText($"XV: {velocity.X}", 10, 25, 10, Color.BLACK);
                Raylib.DrawText($"YV: {velocity.Y}", 10, 35, 10, Color.BLACK);

                //camera.target = position;

                Raylib.EndDrawing();
            }
        }
    }
}
