namespace DesignPatters.Studies.StrategyPattern.MedievalGame.Strategies;

// Concrete Strategy Class
public class AxeBehaviour : IWeaponBehaviour
{
    public void UseWeapon()
    {
        Console.WriteLine("Hits with Axe!");
    }
}