public class GameObject
{
    protected Rectangle rect;

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
