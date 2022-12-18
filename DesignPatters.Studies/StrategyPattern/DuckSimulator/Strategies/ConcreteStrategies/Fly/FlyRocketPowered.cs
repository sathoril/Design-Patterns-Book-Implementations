namespace DesignPatters.Studies.StrategyPattern.DuckSimulator.Strategies.ConcreteStrategies.Fly;

/// <summary>
/// This is the ConcreteStrategy, this class implements the Strategy IFlyBehaviour, in this case, are used for Ducks that fly with rockets.
/// </summary>
public class FlyRocketPowered : IFlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("Flying but with a rocket!!!");
    }
}