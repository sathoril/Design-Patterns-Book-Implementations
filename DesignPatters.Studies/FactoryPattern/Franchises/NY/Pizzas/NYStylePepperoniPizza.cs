namespace DesignPatters.Studies.FactoryPattern.Franchises.Pizzas;

/// <summary>
/// This is a ConcreteProduct, a Product that is produce by one specific ConcreteCreator
/// </summary>
public class NYStylePepperoniPizza : Pizza
{
    public NYStylePepperoniPizza()
    {
        Name = "NY Styled Sauce And Pepperoni Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";
        Toppings.Add("New York Pepperoni");
    }
}