public class GameObject
{
    public Rectangle rect;

    protected Color color;
    public GameObject()
    {
        
    }
    public void Draw()
    {
        Raylib.DrawRectangleRec(rect, color);
    }
        public virtual void Update() 
    {
       
    }

}
