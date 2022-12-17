namespace DesignPatters.Studies.MazeObjects;

public class Maze
{
    public Maze()
    {
        
    }

    private Dictionary<int, Room> Rooms { get; set; } = new();

    public void AddRoom(Room room)
    {
        Rooms.Add(room.RoomNumber, room);
    }
}