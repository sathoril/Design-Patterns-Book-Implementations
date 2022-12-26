using DesignPatters.Studies.FactoryPattern.Franchises.Pizzas;

namespace DesignPatters.Studies.FactoryPattern.Franchises;

/// <summary>
/// This is a Concrete Creator, since it implements the Factory Method
/// from the Abstract Creator (CreatePizza method).
/// </summary>
public class ChicagoPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(PizzaFlavor type)
    {
        switch (type)
        {
            case PizzaFlavor.Cheese:
                return new ChicagoStyleCheesePizza();
            case PizzaFlavor.Veggie:
                return new ChicagoStyleVeggiePizza();
            case PizzaFlavor.Clam:
                return new ChicagoStyleClamPizza();
            case PizzaFlavor.Pepperoni:
                return new ChicagoStylePepperoniPizza();
            default:
                return default;
        }
    }
}