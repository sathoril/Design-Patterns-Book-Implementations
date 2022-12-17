using DesignPatters.Studies.MazeObjects;

namespace DesignPatters.Studies.CreationalPatterns.AbstractFactory;

public class AbstractMazeFactory
{
    public virtual Maze MakeMaze()
    {
        return new Maze();
    }

    public virtual Wall MakeWall()
    {
        return new Wall();
    }

    public virtual Room MakeRoom(int roomNumber)
    {
        return new Room(roomNumber);
    }

    public virtual Door MakeDoor(Room room1, Room room2)
    {
        return new Door(room1, room2);
    }
}