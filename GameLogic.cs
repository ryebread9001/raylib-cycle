class GameLogic {
    public GameLogic() {}

    public bool MoveAvailable(Cycle c, int moveX, int moveY) {
        if (c.velX ==  -1 && moveX == 1) {
            return false;
        }
        if (c.velX ==  1 && moveX == -1) {
            return false;
        }
        if (c.velY ==  -1 && moveY == 1) {
            return false;
        }
        if (c.velY ==  1 && moveY == -1) {
            return false;
        }
        return true;
    }
}