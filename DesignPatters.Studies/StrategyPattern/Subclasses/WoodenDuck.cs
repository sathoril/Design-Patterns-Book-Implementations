using DesignPatters.Studies.DuckRefactoredClasses;
using DesignPatters.Studies.DuckRefactoredClasses.Behaviours;
using DesignPatters.Studies.DuckRefactoredClasses.Behaviours.Fly;

namespace DesignPatters.Studies.DuckClasses.Subclasses;

// This is a Subclass of Duck, a Duck that is made from Wood
public class WoodenDuck : Duck
{
    public WoodenDuck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour) : base(flyBehaviour, quackBehaviour)
    {
    }
    
    public override void Display() => Console.WriteLine($"I'm a WoodenDuck!");
}