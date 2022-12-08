global using Raylib_cs; // global using Raylib_cs;
using System.Numerics;
using System.Collections.Generic;

Raylib.SetTargetFPS(60);
Raylib.InitWindow(800, 600, "Asteroid Game");

Player myplayer = new Player();
Rectangle rect = new Rectangle(400, 300, 50, 50);


Map space = new Map();

float speed = 3f;

Vector2 movement = new Vector2();

bool undoX = false;
bool undoY = false;

string level = "1";

while (!Raylib.WindowShouldClose())
{

    undoX = false;
    undoY = false;

    if (level == "1")
    {
    movement = ReadMovement(speed); 
    rect.x += movement.X;
    rect.y += movement.Y;

    if (rect.x < 0 || rect.x + rect.width > Raylib.GetScreenWidth())
    {
       undoX = true;  // rect.x -= movement.X;                                           // Collision detection av borders
    }
    if (rect.y < 0 || rect.y + rect.height > Raylib.GetScreenHeight()) 
    {
        undoY = true;  //rect.y -= movement.Y;

    }
}

if (undoX == true) rect.x -= movement.X;
if (undoY == true) rect.y -= movement.Y;

    

    //LOGIK
    space.Update();

    Raylib.BeginDrawing();
    
    if (level == "1")
    {
        Raylib.DrawRectangleRec(rect, Color.WHITE);

    }

    Raylib.ClearBackground(Color.BLACK);

    space.Draw();

    Raylib.EndDrawing();


    static Vector2 ReadMovement(float speed)  //static Rectangle ReadMovement(Rectangle rect, float speed)
{
    Vector2 movement = new Vector2();
    if (Raylib.IsKeyDown(KeyboardKey.KEY_W)) movement.Y = -speed;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_S)) movement.Y = speed;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_A)) movement.X = -speed;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_D)) movement.X = speed;     

    return movement;
}
}

