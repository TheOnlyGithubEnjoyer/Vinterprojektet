global using Raylib_cs; 
global using System.Numerics;
global using System.Collections.Generic;
global using RestSharp;
global using System.Text.Json;
global using System.Net;

Raylib.SetTargetFPS(60);
Raylib.InitWindow(800, 600, "Asteroid Game");

Map space = new Map();

while (!Raylib.WindowShouldClose())
{

    //LOGIK
    space.Update();

    Raylib.BeginDrawing();


    space.Draw();

    Raylib.EndDrawing();

}





