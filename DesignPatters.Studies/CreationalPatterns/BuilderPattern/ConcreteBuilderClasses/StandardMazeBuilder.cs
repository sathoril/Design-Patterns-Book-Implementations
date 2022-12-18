using System.Runtime.InteropServices;
using DesignPatters.Studies.MazeObjects;

namespace DesignPatters.Studies.CreationalPatterns.BuilderPattern.ConcreteBuilderClasses;

public class StandardMazeBuilder : MazeBuilder
{
    private Maze CurrentMaze;
    private List<Room> Rooms;
    private List<Door> Doors;
    private List<Wall> Walls;
    private Direction CommonWall;

    public override void BuildMaze()
    {
        CurrentMaze = new Maze();        
    }

    public override void BuildRoom(int roomNumber)
    {
        if (!CurrentMaze.Rooms.ContainsKey(roomNumber))
        {
            var room = new Room(roomNumber);
            room.SetSide(Direction.East, new Wall());
            room.SetSide(Direction.West, new Wall());
            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.South, new Wall());
            CurrentMaze.AddRoom(room);
        }
    }

    public override void BuildDoor(int roomNumber1, int roomNumber2)
    {
        Room room1 = CurrentMaze.Rooms[roomNumber1];
        Room room2 = CurrentMaze.Rooms[roomNumber2];
        Door door = new Door(room1, room2);
        
        room1.SetSide(CommonWall(room1, room2), door);
        room2.SetSide(CommonWall(room2, room1), door);
    }

    public override Maze GetMaze()
    {
        return this.CurrentMaze;
    }
}