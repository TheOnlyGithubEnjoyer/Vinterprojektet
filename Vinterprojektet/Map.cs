public class Map
{
    private Player player;
    private Asteroid asteroid;

    public Map()
    {
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
        player.Draw();
        asteroid.Draw();
    }
}
