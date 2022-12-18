using DesignPatters.Studies.StrategyPattern.MedievalGame.Strategies;

namespace DesignPatters.Studies.StrategyPattern.MedievalGame;

// Context class
public abstract class Character
{
    private IWeaponBehaviour weaponBehaviour;

    public Character(IWeaponBehaviour weaponBehaviour)
    {
        this.weaponBehaviour = weaponBehaviour;
    }

    public virtual void Speak() => Console.WriteLine("I'm a Character, and I'm gonna hit something!");
    public virtual void UseWeapon() => this.weaponBehaviour.UseWeapon();
}