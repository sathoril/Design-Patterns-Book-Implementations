using DesignPatters.Studies.StrategyPattern.DuckSimulator.Strategies;

namespace DesignPatters.Studies.StrategyPattern.DuckSimulator.Subclasses;

public class RubberDuck : Duck
{
    public RubberDuck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour) : base(flyBehaviour, quackBehaviour)
    {
    }
    
    public override void Display() => Console.WriteLine($"I'm a RubberDuck!");
}