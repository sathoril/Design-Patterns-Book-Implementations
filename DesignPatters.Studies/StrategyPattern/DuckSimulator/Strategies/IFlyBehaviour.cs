namespace DesignPatters.Studies.StrategyPattern.DuckSimulator.Strategies;

/// Strategy ou Compositor, this a common interface to all the algorithms that will be used.
/// Which means that, IFlyBehaviour its a interface that when a new algorithm must be implemented to a Duck fly in a different way
/// that class that implements that different way will implement from IFlyBehaviour method (Fly).
public interface IFlyBehaviour
{
    public void Fly();
}