namespace DesignPatters.Studies.DuckRefactoredClasses.Behaviours.Fly;

/// <summary>
/// This is the ConcreteStrategy, this class implements the Strategy IFlyBehaviour, in this case, are used for Ducks that fly only with wings.
/// </summary>
public class FlyWithWings : IFlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("Fly with Wings!!");
    }
}