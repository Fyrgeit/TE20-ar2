using System;
using Raylib_cs;
using System.Numerics;

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

            Rectangle rocketSqr = new Rectangle();
            rocketSqr.x = 100;
            rocketSqr.y = 100;
            rocketSqr.width = 20;
            rocketSqr.height = 50;
            
            Vector2 position = new Vector2(10, 25);
            Vector2 velocity = new Vector2(0, 0);

            float angle = 0;

            Color rocketClr = new Color(255, 0, 0, 255);
            Color bgClr = new Color(255, 255, 255, 32);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.DrawRectangle(0, 0, screenWidth, screenHeight, bgClr);

                rocketClr = Color.BLACK;

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

                Raylib.DrawRectanglePro(rocketSqr, position, angle, rocketClr);

                Raylib.EndDrawing();
            }
        }
    }
}
