namespace DesignPatters.Studies.MazeObjects;

public class DoorNeedingSpell : Door
{
    public int SpellNeededNumber { get; }
    
    public DoorNeedingSpell(Room room1, Room room2, int spellNeededNumber) : base(room1, room2)
    {
        this.SpellNeededNumber = spellNeededNumber;
    }
}