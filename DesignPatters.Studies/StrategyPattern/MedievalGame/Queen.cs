using DesignPatters.Studies.StrategyPattern.MedievalGame.Strategies;

namespace DesignPatters.Studies.StrategyPattern.MedievalGame;

public class Queen : Character
{
    public Queen(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour)
    {
    }
    
    public override void Speak() => Console.WriteLine("I'm a Queen, and I'm gonna hit something!");
}