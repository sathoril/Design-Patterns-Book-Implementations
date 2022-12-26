using DesignPatters.Studies.FactoryPattern.Franchises.Pizzas;

namespace DesignPatters.Studies.FactoryPattern.Franchises;

/// <summary>
/// This is a Concrete Creator, since it implements the Factory Method
/// from the Abstract Creator (CreatePizza method).
/// </summary>
public class NYPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(PizzaFlavor type)
    {
        switch (type)
        {
            case PizzaFlavor.Cheese:
                return new NYStyleCheesePizza();
            case PizzaFlavor.Veggie:
                return new NYStyleVeggiePizza();
            case PizzaFlavor.Clam:
                return new NYStyleClamPizza();
            case PizzaFlavor.Pepperoni:
                return new NYStylePepperoniPizza();
            default:
                return default;
        }
    }
}