namespace DesignPatters.Studies.StrategyPattern.MedievalGame.Strategies;

// Concrete Strategy Class
public class KnifeBehaviour : IWeaponBehaviour
{
    public void UseWeapon()
    {
        Console.WriteLine("Hits with Knife!");
    }
}