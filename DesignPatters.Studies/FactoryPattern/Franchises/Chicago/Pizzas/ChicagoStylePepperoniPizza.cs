namespace DesignPatters.Studies.FactoryPattern.Franchises.Pizzas;

/// <summary>
/// This is a ConcreteProduct, a Product that is produce by one specific ConcreteCreator
/// </summary>
public class ChicagoStylePepperoniPizza : Pizza
{
    public ChicagoStylePepperoniPizza()
    {
        Name = "Chicago Styled Deep Dish Pepperoni Pizza";
        Dough = "Extra Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";
        Toppings.Add("Pepperoni");
    }
    
    public override void Cut()
    {
        Console.WriteLine($"Cutting the pizza into square slices...");
    }
}