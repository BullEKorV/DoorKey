using System;
using Raylib_cs;
public class Door
{
    public Rectangle rect;
    public bool isLocked = true;
    public Door()
    {
        rect.x = 50;
        rect.y = 100;
        rect.width = 35;
        rect.height = 50;
    }
    public bool CheckCollision(Rectangle otherRectangle)
    {
        return Raylib.CheckCollisionRecs(this.rect, otherRectangle);
    }
    public void Draw()
    {
        Raylib.DrawRectangle((int)rect.x, (int)rect.y, (int)rect.width, (int)rect.height, Color.RED);
    }
}