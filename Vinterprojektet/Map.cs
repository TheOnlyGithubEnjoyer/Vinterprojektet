
public class Map
{

List<Rectangle> Asteroids = new List<Rectangle>();
List<float> AsteroidSpeed = new List<float>();
Random generator = new Random();
    private Player player;
    private Asteroid asteroid;
    public Map()
    {
        RestClient shipClient = new("https://swapi.py4e.com/api/");
        RestRequest request = new("starships/10/");
        RestResponse response = shipClient.GetAsync(request).Result;

        if (response.StatusCode == HttpStatusCode.OK)
        {
            player = JsonSerializer.Deserialize<Player>(response.Content);
            Console.WriteLine(player.name);
            Console.WriteLine(player.max_atmosphering_speed);

            Console.WriteLine(response.Content);
        }

        else
        {
            Console.WriteLine("What?");
        }

        for (int i = 0; i < 15; i++)
{
    int x = generator.Next (Raylib.GetScreenWidth());
    int y = generator.Next (Raylib.GetScreenHeight());
    int size = generator.Next(20, 40);
    Asteroids.Add(new Rectangle (x, y, size, size));

    float speed = (float) (generator.NextDouble() + 0.5);
    AsteroidSpeed.Add(speed);
}


        player = new Player();
        asteroid = new Asteroid();
    }
    public void Update()
    {
        player.Update();
        asteroid.Update();
    }
    public void Draw()
    {

        Raylib.ClearBackground(Color.BLACK);
            
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

        player.Draw();
        asteroid.Draw();
    }
}
}





