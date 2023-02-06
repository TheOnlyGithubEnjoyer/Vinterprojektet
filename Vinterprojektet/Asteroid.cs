public class Asteroid: GameObject
{


public List<Rectangle> Asteroids = new List<Rectangle>();
List<float> AsteroidSpeed = new List<float>();              // List of asteroids
Random generator = new Random();
Texture2D AsteroidImage = Raylib.LoadTexture("Rock.png");

    public Asteroid()
    {
    for (int i = 0; i < 18; i++)
    {
    int x = generator.Next (Raylib.GetScreenWidth());
    int y = generator.Next (Raylib.GetScreenHeight());
    int size = generator.Next(35, 45);
    Asteroids.Add(new Rectangle (x, y, size, size));            // Randomly create asteroids
    
    float speed = (float) (generator.NextDouble() + 4);
    AsteroidSpeed.Add(speed);
    }
    }
        public override void Update()
        {

    for (int i = 0; i < Asteroids.Count; i++)
    {
        Rectangle rectangle = Asteroids[i];
        rectangle.y += AsteroidSpeed[i];
    

    if (rectangle.y > Raylib.GetScreenHeight())
    {
        int x = generator.Next (Raylib.GetScreenWidth());   // Every Asteroid spawns in a different x-value
        rectangle.y = -8;
        rectangle.x = x;
    }
    Asteroids[i] = rectangle;

    Raylib.DrawTexture(AsteroidImage, (int)rectangle.x, (int)rectangle.y, Color.WHITE);        // draw asteroid

    }
        
    
        }
    }

    

  

