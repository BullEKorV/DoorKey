using System;
using Raylib_cs;
using System.Numerics;
public class Key
{
    public Rectangle rect;
    public bool isPickedUp = false;
    public Door targetDoor;
    public Key(Door target)
    {
        this.targetDoor = target;
        rect.x = 600;
        rect.y = 500;
        rect.width = 25;
        rect.height = 25;
    }
    public bool CheckCollision(Rectangle otherRectangle)
    {
        return Raylib.CheckCollisionRecs(this.rect, otherRectangle);
    }
    public void UpdatePosition(Vector2 movement)
    {
        rect.x += movement.X;
        rect.y += movement.Y;

        if (targetDoor.CheckCollision(this.rect))
        {
            targetDoor.isLocked = false;
        }
    }
    public void Draw()
    {
        Raylib.DrawRectangle((int)rect.x, (int)rect.y, (int)rect.width, (int)rect.height, Color.YELLOW);
    }
}