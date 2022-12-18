namespace DesignPatters.Studies.StrategyPattern.MedievalGame.Strategies;

// Concrete Strategy Class
public class BowBehaviour : IWeaponBehaviour
{
    public void UseWeapon()
    {
        Console.WriteLine("Hits with Bow!");
    }
}