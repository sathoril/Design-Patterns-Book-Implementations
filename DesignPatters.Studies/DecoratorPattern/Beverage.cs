namespace DesignPatters.Studies.DecoratorPattern;

/// <summary>
/// This is class is the Component, it is the class that can be wrapped or not by decorators.
/// </summary>
public abstract class Beverage
{
    public Beverage(Size size)
    {
        this.Size = size;
    }
    
    /// <summary>
    /// Description that can be overriden when adding new condiments
    /// </summary>
    public abstract string Description { get; }
 
    public Size Size { get; }
        
    /// <summary>
    /// Calculates and returns the cost of the beverage
    /// </summary>
    /// <returns></returns>
    public abstract double Cost();
}

public enum Size
{
    Tall,
    Grande,
    Venti
}