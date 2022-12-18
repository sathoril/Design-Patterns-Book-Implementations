namespace DesignPatters.Studies.StrategyPattern.DuckSimulator.Strategies.ConcreteStrategies.Fly;

/// <summary>
/// This is the ConcreteStrategy, this class implements the Strategy IFlyBehaviour, in this case, are used for Ducks that can't fly.
/// </summary>
public class FlyNoWay : IFlyBehaviour
{
    public void Fly()
    {
        // Does Nothing because it doesnt know how to fly
    }
}