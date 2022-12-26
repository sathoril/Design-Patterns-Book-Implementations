namespace DesignPatters.Studies.FactoryPattern.Franchises.Pizzas;

/// <summary>
/// This is a ConcreteProduct, a Product that is produce by one specific ConcreteCreator
/// </summary>
public class CaliforniaStyleClamPizza : Pizza
{
    public CaliforniaStyleClamPizza()
    {
        Name = "California Styled Sauce And Clam Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Normal Sauce";
        Toppings.Add("Normal Clam");
    }
}