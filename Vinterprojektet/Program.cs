global using Raylib_cs; 
global using System.Numerics;
global using System.Collections.Generic;
global using RestSharp;
global using System.Text.Json;
global using System.Net;

Raylib.SetTargetFPS(60);
Raylib.InitWindow(800, 600, "Asteroid Game");

Map space = new Map();
Map2 space2 = new Map2();

static void Centered(string text)
{
    int numberOfSpaces = Console.WindowWidth / 2 - text.Length /2;

    int i = 0;                    //Makes the introduction more clean with centered writing
    while (i < numberOfSpaces)
    {
        i++;
        Console.Write(" ");
    }
    Console.WriteLine(text);
}


int character = 0;
bool success = false;

while (success != true)
{
Centered("Pick a Spaceship! 1 or 2");
string input = Console.ReadLine();

success = int.TryParse(input, out character); // Tryparse for choosing character between numbers 1 and 2
}
if (success == true)
{
    if (character == 1)                
{
    Centered("Press Enter To Continue"); 
}
    if (character == 2)
    {
    Centered("Press Enter to Continue");
    }
    
}
    else {
        success = false;
    }


while (!Raylib.WindowShouldClose())
{

    //LOGIK
    if (character == 1)     // Depending on the character, is the type of map that will be used
    {
        space.Update();
    }
    if (character == 2)       
    {
        space2.Update();
    }

    Raylib.BeginDrawing();

    if (character == 1)
    {
        space.Draw();
    }

    if (character == 2)
    {
        space2.Draw();
    }

    Raylib.EndDrawing();

}





