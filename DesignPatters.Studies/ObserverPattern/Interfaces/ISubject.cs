namespace DesignPatters.Studies.ObserverPattern.Interfaces;

/// <summary>
/// The Subject interface, defines which methods a class that needs to be an subject should implement.
/// </summary>
public interface ISubject
{
    /// <summary>
    /// This method, will add a class that implements IOBserver interface, to the ISubject class Data that
    /// stores all the observers.
    /// </summary>
    /// <param name="o"></param>
    public void RegisterObserver(IObserver o);
    
    /// <summary>
    /// This, will remove an observer from the observer track list from the subject object.
    /// </summary>
    /// <param name="o"></param>
    public void RemoveObserver(IObserver o);
    
    /// <summary>
    /// This, indeed will call the Update() method on the IObserver interface, and will let all the objects
    /// know a change has occured.
    /// </summary>
    public void NotifyObservers();
}