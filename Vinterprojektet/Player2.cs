

public class Player2 : GameObject
{
   
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
            speed *= 0.005f;
        }
    }

    private float speed;

    Texture2D player2Image = Raylib.LoadTexture("Spaceship.png");
    Rectangle rect2 = new Rectangle(400, 300, 50, 50);

    Vector2 movement2 = new Vector2();

    public override void Update()
    {
        Raylib.DrawRectangle(7, 9, 158, 20, Color.BEIGE);
        Raylib.DrawText(name, 10, 10, 20, Color.WHITE);   // API name gets put into the game
        Raylib.DrawTexture(player2Image, (int)rect2.x, (int)rect2.y, Color.WHITE);

        bool moveX = false;
        bool moveY = false;

        moveX = false;
        moveY = false;

        movement2 = ReadMovement();
        rect2.x += movement2.X;     
        rect2.y += movement2.Y;

        if (rect2.x < 0 || rect2.x + rect2.width > Raylib.GetScreenWidth())
        {
            moveX = true;  // rect2.x -= movement.X;                                           // Collision detection av borders
        }
        if (rect2.y < 0 || rect2.y + rect2.height > Raylib.GetScreenHeight())
        {
            moveY = true; //rect2.y -= movement.Y;
        }

        if (moveX == true) rect2.x -= movement2.X;
        if (moveY == true) rect2.y -= movement2.Y;


    }
    Vector2 ReadMovement()  //static rect2angle ReadMovement(rect2angle rect, float speed)
    {
        Vector2 movement2 = new Vector2();
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W)) movement2.Y = -speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S)) movement2.Y = speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A)) movement2.X = -speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D)) movement2.X = speed;

        return movement2;
    }
}


