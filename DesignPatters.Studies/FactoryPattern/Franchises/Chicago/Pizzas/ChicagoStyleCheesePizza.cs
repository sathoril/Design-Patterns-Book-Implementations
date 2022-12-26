namespace DesignPatters.Studies.FactoryPattern.Franchises.Pizzas;

/// <summary>
/// This is a ConcreteProduct, a Product that is produce by one specific ConcreteCreator
/// </summary>
public class ChicagoStyleCheesePizza : Pizza
{
    public ChicagoStyleCheesePizza()
    {
        Name = "Chicago Styled Deep Dish Cheese Pizza";
        Dough = "Extra Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";
        Toppings.Add("Shredded Mozzarella Cheese");
    }

    public override void Cut()
    {
        Console.WriteLine($"Cutting the pizza into square slices...");
    }
}