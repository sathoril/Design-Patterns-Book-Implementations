using DesignPatters.Studies.MazeObjects;

namespace DesignPatters.Studies.CreationalPatterns.BuilderPattern;

public abstract class MazeBuilder
{
    public abstract void BuildMaze();
    public abstract void BuildRoom(int roomNumber);
    public abstract void BuildDoor(int roomNumber1, int roomNumber2);
    public abstract Maze GetMaze();

    public Direction CommonWall(Room room1, Room room2)
    {
        var room1SideWithNoDoor = room1.Sides.FirstOrDefault(x => x.Value.GetType() != typeof(Door));
        var room2SideWithNoDoor = room2.Sides.FirstOrDefault(x => x.Value.GetType() != typeof(Door) && x.Key != room1SideWithNoDoor.Key);

        if (room1SideWithNoDoor.Key == Direction.East && room2SideWithNoDoor.Key == Direction.West)
        {
            return room1SideWithNoDoor.Key;
        }

        if (room1SideWithNoDoor.Key == Direction.West && room2SideWithNoDoor.Key == Direction.East)
        {
            return room1SideWithNoDoor.Key;
        }

        if (room1SideWithNoDoor.Key == Direction.North && room2SideWithNoDoor.Key == Direction.South)
        {
            return room1SideWithNoDoor.Key;
        }

        if (room1SideWithNoDoor.Key == Direction.South && room2SideWithNoDoor.Key == Direction.North)
        {
            return room1SideWithNoDoor.Key;
        }

        return default;
    }
}