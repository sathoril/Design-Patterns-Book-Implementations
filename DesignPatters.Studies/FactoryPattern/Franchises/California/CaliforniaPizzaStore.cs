using DesignPatters.Studies.FactoryPattern.Franchises.Pizzas;

namespace DesignPatters.Studies.FactoryPattern.Franchises;

/// <summary>
/// This is a Concrete Creator, since it implements the Factory Method
/// from the Abstract Creator (CreatePizza method).
/// </summary>
public class CaliforniaPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(PizzaFlavor type)
    {
        switch (type)
        {
            case PizzaFlavor.Cheese:
                return new CaliforniaStyleCheesePizza();
            case PizzaFlavor.Veggie:
                return new CaliforniaStyleVeggiePizza();
            case PizzaFlavor.Clam:
                return new CaliforniaStyleClamPizza();
            case PizzaFlavor.Pepperoni:
                return new CaliforniaStylePepperoniPizza();
            default:
                return default;
        }
    }
}