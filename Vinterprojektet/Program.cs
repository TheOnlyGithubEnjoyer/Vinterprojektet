global using Raylib_cs; // global using Raylib_cs;
global using System.Numerics;
global using System.Collections.Generic;

Raylib.SetTargetFPS(60);
Raylib.InitWindow(800, 600, "Asteroid Game");

Map space = new Map();

while (!Raylib.WindowShouldClose())
{

    //LOGIK
    space.Update();

    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.BLACK);

    space.Draw();

    Raylib.EndDrawing();

}





