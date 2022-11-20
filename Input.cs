using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.KeyboardKey;
using static Raylib_cs.MouseButton;
class Input {
    public Input() {}

    public void CheckKeyBoardInput(Cycle p1, Cycle p2, GameLogic gm) {
        if (IsKeyDown(KeyboardKey.KEY_A)) {
            if (gm.MoveAvailable(p1, -1, 0)) p1.ChangeVel(-1,0);
        }
        if (IsKeyDown(KeyboardKey.KEY_D)) {
            if (gm.MoveAvailable(p1, 1, 0)) p1.ChangeVel(1,0);
        }
        if (IsKeyDown(KeyboardKey.KEY_S)) {
            if (gm.MoveAvailable(p1, 0, 1)) p1.ChangeVel(0,1);
        }
        if (IsKeyDown(KeyboardKey.KEY_W)) {
            if (gm.MoveAvailable(p1, 0, -1)) p1.ChangeVel(0,-1);
        }

        if (IsKeyDown(KeyboardKey.KEY_J)) {
            if (gm.MoveAvailable(p2, -1, 0)) p2.ChangeVel(-1,0);
        }
        if (IsKeyDown(KeyboardKey.KEY_L)) {
            if (gm.MoveAvailable(p2, 1, 0)) p2.ChangeVel(1,0);
        }
        if (IsKeyDown(KeyboardKey.KEY_K)) {
            if (gm.MoveAvailable(p2, 0, 1)) p2.ChangeVel(0,1);    
        }
        if (IsKeyDown(KeyboardKey.KEY_I)) {
            if (gm.MoveAvailable(p2, 0, -1)) p2.ChangeVel(0,-1);
        }
    }
}