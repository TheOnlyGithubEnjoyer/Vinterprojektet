
public class Map
{
    
    private Player player;
    private Asteroid asteroid;
    string level = "1";
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

        // player = new Player();
        asteroid = new Asteroid();
        
    }
    
    public void Update()
    {
        // Player2.Update();
        if (Raylib.CheckCollisionRecs(player.rect, asteroid.rect))
        {
            level = "2";
        }
        player.Update();
        asteroid.Update();

    }
    public void Draw()
    {
        if (level == "1")
        {
        Raylib.ClearBackground(Color.BLACK);
        player.Draw();
        asteroid.Draw();
        }
        if (level == "2")
        {
        Raylib.ClearBackground(Color.BLACK);
        Raylib.DrawText("GAME OVER", 300, 400, 40, Color.WHITE);
        }
    }
}






