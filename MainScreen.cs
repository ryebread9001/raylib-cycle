using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

class MainScreen {
    public MainScreen() {} 

    public void Draw(int player) {
        BeginDrawing();
        ClearBackground(BLACK);
        DrawText("CYCLE", 250, 50,  45, RED);
        DrawText($"prev winner: Player{player}", 250, 100, 15, WHITE);
        DrawText("click anywhere to start", 250, 350, 15, WHITE);
        
        
        EndDrawing();
    }
}