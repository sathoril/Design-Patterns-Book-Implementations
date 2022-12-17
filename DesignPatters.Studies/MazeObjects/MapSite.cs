namespace DesignPatters.Studies.MazeObjects;

public class MapSite
{
    public bool Entered { get; set; } = false;
    
    public void Enter()
    {
        this.Entered = true;
    }
}