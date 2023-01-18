public class Asteroid: GameObject
{
List<Rectangle> Asteroids = new List<Rectangle>();
List<float> AsteroidSpeed = new List<float>();
Random generator = new Random();

    public Asteroid()
    {
    for (int i = 0; i < 15; i++)
    {
    int x = generator.Next (Raylib.GetScreenWidth());
    int y = generator.Next (Raylib.GetScreenHeight());
    int size = generator.Next(20, 40);
    Asteroids.Add(new Rectangle (x, y, size, size));

    float speed = (float) (generator.NextDouble() + 0.5);
    AsteroidSpeed.Add(speed);
    }
    }
        public override void Update()
        {

      for (int i = 0; i < Asteroids.Count; i++)
    {
    Rectangle ast = Asteroids[i];
    ast.y += AsteroidSpeed[i];

    if (ast.y > Raylib.GetScreenHeight())
    {
        ast.y = -15;
    }
    Asteroids[i] = ast;

    Raylib.DrawRectangleRec(Asteroids[i], Color.GRAY);
    }
        }
    }
  

