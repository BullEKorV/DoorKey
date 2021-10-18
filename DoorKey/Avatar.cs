using System;
using System.Numerics;
using Raylib_cs;

public class Avatar
{
    public Rectangle rect;
    public Key carriedKey;
    private int speed = 5;
    public Avatar()
    {
        rect.x = 20;
        rect.y = 20;
        rect.height = 30;
        rect.width = 30;
    }
    public void Update()
    {
        Vector2 movement = new Vector2();
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            movement.X = -1;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            movement.X = 1;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            movement.Y = -1;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            movement.Y = 1;
        }

        movement *= speed;

        rect.x += movement.X;
        rect.y += movement.Y;

        if (carriedKey != null)
        {
            carriedKey.UpdatePosition(movement);
        }
    }

    public void CheckKeyCollision(Key key)
    {
        if (key.CheckCollision(this.rect))
        {
            carriedKey = key;
        }
    }

    public bool CheckDoorCollision(Door door)
    {
        return door.CheckCollision(this.rect);
    }
    public void Draw()
    {
        Raylib.DrawRectangle((int)rect.x, (int)rect.y, (int)rect.width, (int)rect.height, Color.BLUE);
    }

}