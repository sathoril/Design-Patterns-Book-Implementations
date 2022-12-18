namespace DesignPatters.Studies.DuckRefactoredClasses;

/// Strategy ou Compositor, this a common interface to all the algorithms that will be used.
/// Which means that, IQuackBehaviour its a interface that when a new algorithm must be implemented to allow a Duck to do Quack in a different way.
/// That class that implements Quack in a different way will implement from IQuackBehaviour method (Quack).
public interface IQuackBehaviour
{
    public void Quack();
}