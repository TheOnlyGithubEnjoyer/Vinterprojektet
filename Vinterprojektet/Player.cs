
public class Player : GameObject
{
    // Speed, Position, Picture, Hitbox, HP
     
    public string name { get; set; }
    public string max_atmosphering_speed
    {
        get
        {
            return speed.ToString();
        }
        set
        {
            float.TryParse(value, out speed);
        }
    }

     private float speed;


    Texture2D playerImage = Raylib.LoadTexture("Arrow.png");
    Rectangle rect = new Rectangle(400, 300, 50, 50);

    // float speed = "max_atmosphering_speed";

    Vector2 movement = new Vector2();

    public override void Update()
    {
        
        Raylib.DrawTexture(playerImage, (int)rect.x, (int)rect.y, Color.WHITE);

        bool moveX = false;
        bool moveY = false;

        moveX = false;
        moveY = false;

        movement = ReadMovement(speed); 
        rect.x += movement.X;
        rect.y += movement.Y;

        if (rect.x < 0 || rect.x + rect.width > Raylib.GetScreenWidth())
        {
            moveX = true;  // rect.x -= movement.X;                                           // Collision detection av borders
        }
        if (rect.y < 0 || rect.y + rect.height > Raylib.GetScreenHeight())
        {
            moveY = true; //rect.y -= movement.Y;


        }

        if (moveX == true) rect.x -= movement.X;
        if (moveY == true) rect.y -= movement.Y;

    
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
}




