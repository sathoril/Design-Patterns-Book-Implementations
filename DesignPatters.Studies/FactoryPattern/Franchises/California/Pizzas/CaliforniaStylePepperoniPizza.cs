namespace DesignPatters.Studies.FactoryPattern.Franchises.Pizzas;

/// <summary>
/// This is a ConcreteProduct, a Product that is produce by one specific ConcreteCreator
/// </summary>
public class CaliforniaStylePepperoniPizza : Pizza
{
    public CaliforniaStylePepperoniPizza()
    {
        Name = "California Styled Sauce And Pepperoni Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Normal Sauce";
        Toppings.Add("Normal Pepperoni");
    }
}