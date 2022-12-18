namespace DesignPatters.Studies.StrategyPattern.DuckSimulator.Strategies.ConcreteStrategies.Quacks;

/// <summary>
/// This is the ConcreteStrategy, this class implements the Strategy IQuackBehaviour, in this case, are used for Ducks that can't emit a sound.
/// </summary>
public class MuteQuack : IQuackBehaviour
{
    public void Quack()
    {
        // Does nothing
    }
}