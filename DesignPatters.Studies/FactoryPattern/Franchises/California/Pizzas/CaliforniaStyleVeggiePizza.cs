namespace DesignPatters.Studies.FactoryPattern.Franchises.Pizzas;

/// <summary>
/// This is a ConcreteProduct, a Product that is produce by one specific ConcreteCreator
/// </summary>
public class CaliforniaStyleVeggiePizza : Pizza
{
    public CaliforniaStyleVeggiePizza()
    {
        Name = "California Styled Sauce And Veggie Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Normal Sauce";
        Toppings.Add("California Vegetables");
    }
}