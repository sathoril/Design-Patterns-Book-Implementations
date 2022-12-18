using DesignPatters.Studies.StrategyPattern.MedievalGame.Strategies;

namespace DesignPatters.Studies.StrategyPattern.MedievalGame;

public class Troll : Character
{
    public Troll(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour)
    {
    }
    
    public override void Speak() => Console.WriteLine("I'm a Troll, and I'm gonna hit something!");
}