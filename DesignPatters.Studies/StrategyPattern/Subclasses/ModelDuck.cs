using DesignPatters.Studies.DuckRefactoredClasses;

namespace DesignPatters.Studies.DuckClasses.Subclasses;

public class ModelDuck : Duck
{
    public ModelDuck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour) : base(flyBehaviour, quackBehaviour)
    {
    }

    public override void Display() => Console.WriteLine($"I'm a ModelDuck!");
}