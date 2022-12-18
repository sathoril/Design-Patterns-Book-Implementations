using DesignPatters.Studies.DuckRefactoredClasses;

namespace DesignPatters.Studies.DuckClasses;

// This is the Duck Super Class. This is the Context on StrategyPattern
public abstract class Duck
{
    /// These are the behaviours that Duck class can perform.
    /// It delegates its implementation to other classes, which will be implemented by the algorithms (Classes that implement IFlyBehaviour or IQuackBehaviour).
    private IFlyBehaviour flyBehaviour;
    private IQuackBehaviour quackBehaviour;
    
    public Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
    {
        this.flyBehaviour = flyBehaviour;
        this.quackBehaviour = quackBehaviour;
    }
    
    public virtual void PerformQuack() => quackBehaviour.Quack();

    public virtual void Swim() => Console.WriteLine("Splash!!");

    public virtual void Display() => Console.WriteLine($"{GetType()}");

    public virtual void PerformFlying() => flyBehaviour.Fly();
    
}