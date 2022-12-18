namespace DesignPatters.Studies.StrategyPattern.DuckSimulator.Strategies.ConcreteStrategies.Quacks;

/// <summary>
/// This is the ConcreteStrategy, this class implements the Strategy IQuackBehaviour, in this case, are used for Ducks that can do simple quacks as a sound.
/// </summary>
public class SimpleQuack : IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("SimpleQuack!!");
    }
}