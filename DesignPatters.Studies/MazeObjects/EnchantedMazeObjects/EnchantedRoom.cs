namespace DesignPatters.Studies.MazeObjects;

public class EnchantedRoom : Room
{
    public int Spell  { get; }
    
    public EnchantedRoom(int roomNumber) : base(roomNumber)
    {
        this.Spell = new Random().Next();
    }
}