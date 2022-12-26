namespace DesignPatters.Studies.FactoryPattern.Franchises.Pizzas;

/// <summary>
/// This is a ConcreteProduct, a Product that is produce by one specific ConcreteCreator
/// </summary>
public class NYStyleClamPizza : Pizza
{
    public NYStyleClamPizza()
    {
        Name = "NY Styled Sauce And Clam Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";
        Toppings.Add("New York Clam");
    }
}