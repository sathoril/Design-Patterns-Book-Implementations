using DesignPatters.Studies.StrategyPattern.MedievalGame.Strategies;

namespace DesignPatters.Studies.StrategyPattern.MedievalGame;

public class King : Character
{
    public King(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour)
    {
    }
    
    public override void Speak() => Console.WriteLine("I'm a King, and I'm gonna hit something!");
}