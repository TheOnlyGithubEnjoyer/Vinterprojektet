public class GameObject
{
    protected Rectangle rect;

    protected Color color;

    public GameObject()
    {
        rect = new Rectangle(400, 300, 50, 50);
    }
    public void Draw()
    {
        Raylib.DrawRectangleRec(rect, color);
    }
        public virtual void Update() 
    {
       
    }

}
