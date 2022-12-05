public class Player: GameObject
{
    // Speed, Position, Picture, Hitbox, HP
    public Player()
    {
        color = Color.WHITE;
    }



    public override void Update()
    {
        if(Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            PlayerRect.x -= 3;
        }
        if(Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            PlayerRect.x += 3;
        }
        if(Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            PlayerRect.y -= 3;
        }
        if(Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            PlayerRect.y += 3;
        }

    if (PlayerRect.x < 0 || PlayerRect.x + PlayerRect.width > Raylib.GetScreenWidth())
    {
        PlayerRect.x =- PlayerRect.x;                                           // Collision detection of borders
    }
    if (PlayerRect.y < 0 || PlayerRect.y + PlayerRect.height > Raylib.GetScreenHeight()) 
    {
        PlayerRect.y =- PlayerRect.y;
    }
    if (PlayerRect.x > 800 || PlayerRect.x - PlayerRect.width > Raylib.GetScreenWidth())
    {
        PlayerRect.x =- PlayerRect.x;                                           // Collision detection of borders
    }
    if (PlayerRect.y > 600 || PlayerRect.y - PlayerRect.height > Raylib.GetScreenHeight()) 
    {
        PlayerRect.y =- PlayerRect.y;
    }
    
    }
}
