using System;
using Raylib_cs;

class Program
{
    static void Main(string[] args)
    {
        bool hasWon = false;

        Avatar player = new Avatar();
        Door door = new Door();
        Key key = new Key(door);

        Raylib.InitWindow(1280, 720, "UWUs");
        Raylib.SetTargetFPS(60);

        while (!Raylib.WindowShouldClose())
        {
            if (!hasWon)
            {
                player.Update();

                player.CheckKeyCollision(key);

                if (player.CheckDoorCollision(door) && !door.isLocked)
                {
                    hasWon = true;
                }
            }
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            if (!hasWon)
            {
                player.Draw();
                door.Draw();
                key.Draw();
            }
            else
            {
                Raylib.DrawText("WON", 0, 0, 100, Color.BLUE);
            }
            Raylib.EndDrawing();
        }
    }
}