public class GameObject
{
    protected Rectangle PlayerRect;
    protected Rectangle AsteroidRect;

    protected Color color;

    public GameObject()
    {
        AsteroidRect = new Rectangle(300,200, 40, 40);
        PlayerRect = new Rectangle(400, 300, 50, 50);
    }
    public void Draw()
    {
        Raylib.DrawRectangleRec(PlayerRect, color);
    }
        public virtual void Update() 
    {
       
    }

}
