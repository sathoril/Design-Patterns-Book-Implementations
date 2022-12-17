using DesignPatters.Studies.MazeObjects;

namespace DesignPatters.Studies.CreationalPatterns.AbstractFactory;

public class EnchantedAbstractMazeFactory : AbstractMazeFactory
{
    private AbstractMazeFactory _abstractMazeFactory;

    public EnchantedAbstractMazeFactory() => _abstractMazeFactory = new AbstractMazeFactory();
    
    public override Room MakeRoom(int roomNumber)
    {
        var enchantedRoom = new EnchantedRoom(roomNumber);
        SpellNumber = enchantedRoom.Spell;
        return enchantedRoom;
    }

    public override Door MakeDoor(Room room1, Room room2)
    {
        return new DoorNeedingSpell(room1, room2, SpellNumber);
    }
    
    private int SpellNumber { get; set; }
}