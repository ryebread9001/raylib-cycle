using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

class Segment {
    public int posX;
    public int posY;

    
    Color color;

    public Segment(int x, int y, Color c) {
        this.color = c;
        this.posX = x;
        this.posY = y;
    }

    
    public void Draw() {
        DrawRectangle(posX,posY,1,1,color);
    }
}