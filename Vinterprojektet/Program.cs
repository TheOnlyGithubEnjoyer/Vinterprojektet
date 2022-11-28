global using Raylib_cs; // global using Raylib_cs;

Raylib.SetTargetFPS(60);
Raylib.InitWindow(800, 600, "Asteroid Game");

Player myplayer = new Player();

Map space = new Map();

while (!Raylib.WindowShouldClose())
{
    //LOGIK
    space.Update();

    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.BLACK);

    space.Draw();

    Raylib.EndDrawing();
    //GRAFIK
}