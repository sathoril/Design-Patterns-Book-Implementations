namespace DesignPatters.Studies.StrategyPattern.DuckSimulator.Strategies.ConcreteStrategies.Quacks;

/// <summary>
/// This is the ConcreteStrategy, this class implements the Strategy IQuackBehaviour, in this case, are used for Ducks that instead of Quack, do a Squeak soung, like Rubber Ducks.
/// </summary>
public class Squeak : IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("Squeak!!!");
    }
}