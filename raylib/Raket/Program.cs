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

            Camera2D camera = new Camera2D();
            camera.zoom = 1f;
            camera.offset = new Vector2(screenWidth / 2, screenHeight/2);

            float gridScale = 100;

            Texture2D rocket = Raylib.LoadTexture(@"./rocket.png");

            Rectangle rocketSqr = new Rectangle();
            rocketSqr.x = 100;
            rocketSqr.y = 100;
            rocketSqr.width = 20;
            rocketSqr.height = 50;
            
            Vector2 origin = new Vector2(10, 25);
            Vector2 velocity = new Vector2(0, 0);

            float angle = 0;
            float throttle = 0;

            Color rocketClr = new Color(255, 0, 0, 255);
            Color bgClr = new Color(255, 255, 255, 255);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.BeginMode2D(camera);

                Raylib.ClearBackground(bgClr);
                Raylib.DrawRectangle(0, 0, 100, 100, Color.WHITE);

                rocketClr = Color.BLACK;

                Raylib.DrawRectangle(0, 450, screenWidth, 50, Color.BLUE);

                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP) && throttle < 100)
                    throttle += 2;
                
                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN) && throttle > 0)
                    throttle -= 2;

                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                    angle += 3;
                    
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                    angle -= 3;

                //thrust
                velocity.X += (float)((throttle/100)*0.25*Math.Sin(angle*Math.PI/180));
                velocity.Y -= (float)((throttle/100)*0.25*Math.Cos(angle*Math.PI/180));

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

                //grid
                for (var i = ((int)Math.Round((rocketSqr.x - screenWidth) / gridScale)); i < ((int)Math.Round((rocketSqr.x + screenWidth) / gridScale)); i++)
                {
                    Raylib.DrawLine((int)(i * gridScale), (int)(rocketSqr.y - screenHeight / 2), (int)(i * gridScale), (int)(rocketSqr.y + screenHeight / 2), Color.GRAY);
                }
                for (var i = ((int)Math.Round((rocketSqr.y - screenHeight) / gridScale)); i < ((int)Math.Round((rocketSqr.y + screenHeight) / gridScale)); i++)
                {
                    Raylib.DrawLine((int)(rocketSqr.x - screenWidth / 2), (int)(i * gridScale), (int)(rocketSqr.x + screenWidth / 2), (int)(i * gridScale), Color.GRAY);
                }

                //raketen
                Raylib.DrawTexture(rocket, (int)rocketSqr.x - 50, (int)rocketSqr.y - 90, Color.WHITE);
                Raylib.DrawRectanglePro(rocketSqr, origin, angle, rocketClr);

                Raylib.EndMode2D();

                Raylib.DrawText($"X: {rocketSqr.x}", 10, 5, 10, Color.BLACK);
                Raylib.DrawText($"Y: {rocketSqr.y}", 10, 15, 10, Color.BLACK);
                Raylib.DrawText($"XV: {velocity.X}", 10, 25, 10, Color.BLACK);
                Raylib.DrawText($"YV: {velocity.Y}", 10, 35, 10, Color.BLACK);

                Raylib.DrawRectangle(0, screenHeight-100, 40, 100, Color.GRAY);
                Raylib.DrawRectangle(0, (int)(screenHeight-throttle), 40, (int)throttle, Color.GREEN);

                camera.target = new Vector2(rocketSqr.x, rocketSqr.y);

                Raylib.EndDrawing();
            }
        }
    }
}
