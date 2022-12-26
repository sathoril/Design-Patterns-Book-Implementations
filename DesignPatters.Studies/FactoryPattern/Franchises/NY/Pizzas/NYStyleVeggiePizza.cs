namespace DesignPatters.Studies.FactoryPattern.Franchises.Pizzas;

/// <summary>
/// This is a ConcreteProduct, a Product that is produce by one specific ConcreteCreator
/// </summary>
public class NYStyleVeggiePizza : Pizza
{
    public NYStyleVeggiePizza()
    {
        Name = "NY Styled Sauce And Veggie Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";
        Toppings.Add("New York Vegetables");
    }
}