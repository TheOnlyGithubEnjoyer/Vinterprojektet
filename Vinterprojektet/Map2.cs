
public class Map2
{
    
    private Player2 player2;

    private Asteroid asteroid;

    public string level = "1";
public Map2()
{

        RestClient shipClient = new("https://swapi.py4e.com/api/");     
        RestRequest request = new("starships/2/");
        RestResponse response = shipClient.GetAsync(request).Result;

        if (response.StatusCode == HttpStatusCode.OK)                             // API Anrop for player
        {
            player2 = JsonSerializer.Deserialize<Player2>(response.Content);
            Console.WriteLine(player2.name);
            Console.WriteLine(player2.max_atmosphering_speed);

            Console.WriteLine(response.Content);
        }
        else
        {
            Console.WriteLine("What?");
        }

        asteroid = new Asteroid();

}
    public void Update()
    {
        
    if (level == "1")
    {
        player2.Update();           
        asteroid.Update();
    }
        
    }

    public void Draw()
    {
            
        for (int i = 0; i < 0; i++)
    {
        if (Raylib.CheckCollisionRecs(player2.rect, asteroid.Asteroids[i]))
        {
            level = "2";
        }
    }
        if (level == "1")
        {
        Raylib.ClearBackground(Color.BLACK);
        player2.Draw();                                 
        asteroid.Draw();
        }
        if (level == "2")
        {
        Raylib.ClearBackground(Color.BLACK);
        Raylib.DrawText("GAME OVER", 300, 400, 40, Color.WHITE);
        }
    }
}
