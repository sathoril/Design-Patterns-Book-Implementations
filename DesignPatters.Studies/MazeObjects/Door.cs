namespace DesignPatters.Studies.MazeObjects;

public class Door : MapSite
{
    public Door(Room room1, Room room2)
    {
        Room1 = room1;
        Room2 = room2;
    }
    
    public Room Room1 { get; set; }
    
    public Room Room2 { get; set; }
    
    public bool IsOpen { get; set; }

    public Room OtherSideFrom(Room room)
    {
        return this.Room1.RoomNumber == room.RoomNumber ? Room2 : Room1;
    }
}