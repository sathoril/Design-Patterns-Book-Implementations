namespace DesignPatters.Studies.FactoryPattern;

/// <summary>
/// This is the Abstractt creator class. It is responsible to define an abstract factory method
/// that all subclasses need to implement to product the product (Pizza).
/// </summary>
public abstract class PizzaStore
{
    /// <summary>
    /// This method, never really knows what kind of object will handle, it does not know which type
    /// the method CreatePizza will return, it only knows that it will be it somekind of pizza.
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public Pizza OrderPizza(PizzaFlavor type)
    {
        Pizza pizza = CreatePizza(type);
        
        Thread.Sleep(500);
        pizza.Prepare();
        Thread.Sleep(500);
        
        Thread.Sleep(500);
        pizza.Bake();
        
        Thread.Sleep(500);
        pizza.Cut();
        
        Thread.Sleep(500);
        pizza.Box();
        Thread.Sleep(500);
        
        return pizza;
    }

    public abstract Pizza CreatePizza(PizzaFlavor type);
}