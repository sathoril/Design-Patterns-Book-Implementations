namespace DesignPatters.Studies.FactoryPattern.Franchises.Pizzas;

/// <summary>
/// This is a ConcreteProduct, a Product that is produce by one specific ConcreteCreator
/// </summary>
public class ChicagoStyleClamPizza : Pizza
{
    public ChicagoStyleClamPizza()
    {
        Name = "Chicago Styled Deep Dish Clam Pizza";
        Dough = "Extra Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";
        Toppings.Add("Clam");
    }
    
    public override void Cut()
    {
        Console.WriteLine($"Cutting the pizza into square slices...");
    }
}