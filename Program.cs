using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.KeyboardKey;
using static Raylib_cs.MouseButton;
using static Raylib_cs.Color;


const int screenWidth = 800;
const int screenHeight = 450;


InitWindow(screenWidth, screenHeight, "raylib-project");
SetTargetFPS(60);
InitAudioDevice();      // Initialize audio device

Sound fxWav = LoadSound("sound1.wav");         // Load WAV audio file
Sound fx2Wav = LoadSound("sound2.wav");        // Load OGG audio file
Sound fx3Wav = LoadSound("hitHurt.wav");
SetSoundVolume(fxWav, 0.2f);

Cycle player1 = new Cycle(100,100, RED);
player1.ChangeVel(-1,0);
Cycle player2 = new Cycle(300,100, BLUE);
player2.ChangeVel(-1,0);
Collisions col = new Collisions();
GameLogic game = new GameLogic();
Input input = new Input();
Actors actors = new Actors();
MainScreen mainscreen = new MainScreen();
actors.AddActor(player1);
actors.AddActor(player2);
int gamestate = 1;
while (!WindowShouldClose())    // Detect window close button or ESC key
{
    input.CheckKeyBoardInput(player1, player2, game);
    if (gamestate == 2 && col.GetPrevWin() == 0){
        BeginDrawing();
        ClearBackground(BLACK);
        col.CheckCollisionEnemy(player1, player2);
        
        actors.UpdateActors();
        //Console.WriteLine("FRAME");
        EndDrawing();
            //WaitTime(0.01);
        
    } else {
        mainscreen.Draw(col.GetPrevWin()); // gamestate 1 is home screen
        if (IsMouseButtonPressed(MOUSE_LEFT_BUTTON))
        {
            //if (hlth.health == 0) hlth.health+=10;
            col.SetWinState(0);
            gamestate = 2;
            
        } 
    }
    
    
}