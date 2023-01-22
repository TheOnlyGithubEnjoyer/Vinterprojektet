
public class Map
{
    public int level = 1;
    private Player player;
    // private Player2 player2;
    private Asteroid asteroid;
    

    public Map()
    {
// static void Centered(string text)
// {
//     int numberOfSpaces = Console.WindowWidth / 2 - text.Length /2;

//     int i = 0;                    //Makes the introduction more clean with centered writing
//     while (i < numberOfSpaces)
//     {
//         i++;
//         Console.Write(" ");
//     }
//     Console.WriteLine(text);
// }


// int character = 0;
// bool success = false;

// while (success != true)
// {
// Centered("Pick a Spaceship! 1 or 2");
// string input = Console.ReadLine();

// success = int.TryParse(input, out character); // Tryparse for choosing character between numbers 1 and 2
// }
// if (success == true)
// {
//     if (character == 1)                
// {
//     Centered("Press Enter To Continue"); 
// }
//     if (character == 2)
//     {
//         Centered("Press Enter to Continue");
//     }
// }

// Console.ReadLine();
        

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


        // RestClient ship2Client = new("https://swapi.dev/api/");
        // RestRequest request2 = new("starships/2/");
        // RestResponse response2 = ship2Client.GetAsync(request).Result;

        // if (response.StatusCode == HttpStatusCode.OK)
        // {
        //     player2 = JsonSerializer.Deserialize<Player2>(response.Content);
        //     Console.WriteLine(player2.name);
        //     Console.WriteLine(player2.max_atmosphering_speed);

        //     Console.WriteLine(response.Content);
        // }

        // else
        // {
        //     Console.WriteLine("What?");
        // }

        // player = new Player();
        asteroid = new Asteroid();
        
    }
    
    public void Update()
    {
        // Player2.Update();
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






