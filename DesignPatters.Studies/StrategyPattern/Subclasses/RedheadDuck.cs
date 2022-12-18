using DesignPatters.Studies.DuckRefactoredClasses;
using DesignPatters.Studies.DuckRefactoredClasses.Behaviours;
using DesignPatters.Studies.DuckRefactoredClasses.Behaviours.Fly;

namespace DesignPatters.Studies.DuckClasses.Subclasses;

public class RedheadDuck : Duck
{
    public RedheadDuck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour) : base(flyBehaviour, quackBehaviour)
    {
        
    }
    
    public override void Display() => Console.WriteLine($"I'm a RedheadDuck!");
}