namespace DesignPatters.Studies.MazeObjects;

public class Maze
{
    public Maze()
    {
        
    }

    public Dictionary<int, Room> Rooms { get; set; } = new();

    public void AddRoom(Room room)
    {
        Rooms.Add(room.RoomNumber, room);
    }
}