namespace DesignPatters.Studies.ObserverPattern.Interfaces;

public interface ISubject
{
    public void RegisterObserver(IObserver o);
    public void RemoveObserver(IObserver o);
    public void NotifyObservers();
}