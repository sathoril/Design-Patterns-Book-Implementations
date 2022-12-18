using DesignPatters.Studies.StrategyPattern.MedievalGame.Strategies;

namespace DesignPatters.Studies.StrategyPattern.MedievalGame;

public class Knight : Character
{
    public Knight(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour)
    {
    }
    
    public override void Speak() => Console.WriteLine("I'm a Knight, and I'm gonna hit something!");
}