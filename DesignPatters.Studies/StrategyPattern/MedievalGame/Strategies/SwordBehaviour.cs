namespace DesignPatters.Studies.StrategyPattern.MedievalGame.Strategies;

// Concrete Strategy Class
public class SwordBehaviour : IWeaponBehaviour
{
    public void UseWeapon()
    {
        Console.WriteLine("Hits with Sword!");
    }
}