using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
class Cycle {
    public List<Segment> segments = new List<Segment>();
    public int headX;
    public int headY;

    public int velX;
    public int velY;

    Color color;

    public Cycle(int x, int y, Color c) {
        this.headX = x;
        this.headY = y;
        this.color = c;
    }

    public void UpdatePos() {
        Segment lastPos = new Segment(this.headX, this.headY, color);
        //adding self collision logic here
        //foreach (Segment seg in segments) {
        //    if (lastPos.posX == seg.posX && lastPos.posY == seg.posY) {
        //        Console.WriteLine("COLLISION WITH SELF");
        //    } else {
                segments.Add(lastPos);
        //    }
        //}
        
        
        this.headX += velX;
        this.headY += velY;
    }

    public void ChangeVel(int vX, int vY) {
        this.velX = vX;
        this.velY = vY;
    }


    public void DrawSegments() {
        foreach (Segment seg in segments)
        {
            seg.Draw();
        }
    }

}