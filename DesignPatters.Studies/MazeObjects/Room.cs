namespace DesignPatters.Studies.MazeObjects;

public class Room : MapSite
{
    public int RoomNumber { get; }
    private Dictionary<Direction, MapSite> Sides { get; set; } = new();
    
    public Room(int roomNumber)
    {
        this.RoomNumber = roomNumber;
    }
    
    public MapSite GetSide(Direction direction)
    {
        return Sides[direction];
    }

    public void SetSide(Direction direction, MapSite mapSite)
    {
        Sides.Add(direction, mapSite);
    }
}