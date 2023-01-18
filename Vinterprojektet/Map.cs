
public class Map
{

m();
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

        player.Draw();
        asteroid.Draw();
    }
}






