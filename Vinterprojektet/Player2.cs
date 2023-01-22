
public class Player2 : GameObject
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
            speed *= 0.005f;
        }
    }

    private float speed;

    Texture2D player2Image = Raylib.LoadTexture("Spaceship.png");
    Rectangle rect2 = new Rectangle(400, 300, 50, 50);

    // float speed = "max_atmosphering_speed";

    Vector2 movement2 = new Vector2();

    public override void Update()
    {

        Raylib.DrawTexture(player2Image, (int)rect.x, (int)rect.y, Color.WHITE);

        bool moveX = false;
        bool moveY = false;

        moveX = false;
        moveY = false;

        movement2 = ReadMovement();
        rect.x += movement2.X;
        rect.y += movement2.Y;

        if (rect.x < 0 || rect.x + rect.width > Raylib.GetScreenWidth())
        {
            moveX = true;  // rect.x -= movement.X;                                           // Collision detection av borders
        }
        if (rect.y < 0 || rect.y + rect.height > Raylib.GetScreenHeight())
        {
            moveY = true; //rect.y -= movement.Y;
        }

        if (moveX == true) rect.x -= movement2.X;
        if (moveY == true) rect.y -= movement2.Y;


    }
    Vector2 ReadMovement()  //static Rectangle ReadMovement(Rectangle rect, float speed)
    {
        Vector2 movement = new Vector2();
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W)) movement.Y = -speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S)) movement.Y = speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A)) movement.X = -speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D)) movement.X = speed;

        return movement;
    }
}
