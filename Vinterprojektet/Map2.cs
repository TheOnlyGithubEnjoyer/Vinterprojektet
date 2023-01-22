
public class Map2
{
    public int level = 2;
    private Player2 player2;

    private Asteroid asteroid;


public Map2()
{


        RestClient shipClient = new("https://swapi.py4e.com/api/");
        RestRequest request = new("starships/2/");
        RestResponse response = shipClient.GetAsync(request).Result;

        if (response.StatusCode == HttpStatusCode.OK)
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
        // Player2.Update();
        player2.Update();
        asteroid.Update();

    }

    public void Draw()
    {

        Raylib.ClearBackground(Color.BLACK);
        player2.Draw();
        asteroid.Draw();
        
        

    }
}



