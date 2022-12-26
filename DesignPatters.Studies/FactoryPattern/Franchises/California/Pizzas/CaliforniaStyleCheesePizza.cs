namespace DesignPatters.Studies.FactoryPattern.Franchises.Pizzas;

/// <summary>
/// This is a ConcreteProduct, a Product that is produce by one specific ConcreteCreator
/// </summary>
public class CaliforniaStyleCheesePizza : Pizza
{
    public CaliforniaStyleCheesePizza()
    {
        Name = "California Styled Sauce And Cheese Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Normal Sauce";
        Toppings.Add("Reggiano Cheese");
    }
}