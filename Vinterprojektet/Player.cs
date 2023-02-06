
public class Player : GameObject
{
    

    public string name { get; set; }
    public string max_atmosphering_speed            // connection for the Api
    {
        get
        {
            return speed.ToString();
        }
        set
        {
            float.TryParse(value, out speed);
            speed *= 0.005f;                        // velocity of api information times 0.005 
        }
    }

    private float speed;


    Texture2D playerImage = Raylib.LoadTexture("Mil.png");
    Rectangle rect = new Rectangle(400, 300, 50, 50);

    Vector2 movement = new Vector2();

    public override void Update()
    {
        Raylib.DrawRectangle(7, 9, 177, 20, Color.BEIGE);       // background of the nametag
        Raylib.DrawText(name, 10, 10, 20, Color.WHITE);         // name of the spaceship
        Raylib.DrawTexture(playerImage, (int)rect.x, (int)rect.y, Color.WHITE); // character texture

        bool moveX = false;
        bool moveY = false;

        moveX = false;
        moveY = false;

        movement = ReadMovement();
        rect.x += movement.X;
        rect.y += movement.Y;

        if (rect.x < 0 || rect.x + rect.width > Raylib.GetScreenWidth())
        {
            moveX = true;  // rect.x -= movement.X;                            // Collision detection av borders
        }
        if (rect.y < 0 || rect.y + rect.height > Raylib.GetScreenHeight())
        {
            moveY = true; //rect.y -= movement.Y;
        }

        if (moveX == true) rect.x -= movement.X;
        if (moveY == true) rect.y -= movement.Y;


    }
    Vector2 ReadMovement()  //static Rectangle ReadMovement(Rectangle rect, float speed)
    {
        Vector2 movement = new Vector2();
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W)) movement.Y = -speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S)) movement.Y = speed;            // Speed of the movement of player
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A)) movement.X = -speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D)) movement.X = speed;

        return movement;
    }
}





