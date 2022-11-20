class Collisions {
    private int prevwin;
    public Collisions() {}
    public void CheckCollisionEnemy(Cycle cycle1, Cycle cycle2) {
        foreach (Segment seg1 in cycle1.segments) {
            foreach (Segment seg2 in cycle2.segments) {
                if (seg1.posX == seg2.posX && seg1.posY == seg2.posY) {
                    Console.WriteLine("COLLISION between Players 1 and 2");
                    if (cycle1.headX == seg1.posX && cycle1.headY == seg1.posY | cycle1.headX == seg2.posX && cycle1.headY == seg2.posY) {
                        prevwin = 2;
                    }
                    if (cycle2.headX == seg1.posX && cycle2.headY == seg1.posY | cycle2.headX == seg2.posX && cycle2.headY == seg2.posY) {
                        prevwin = 1;
                    }
                }
            }
        }
    }

    public int GetPrevWin() {
        return prevwin;
    }

    public void SetWinState(int n) {
        prevwin = n;
    }
    
}