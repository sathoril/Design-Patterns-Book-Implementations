namespace DesignPatters.Studies.FactoryPattern;

/// <summary>
/// This is our Product, the object that our Factory will produce.
/// </summary>
public class Pizza
{
    public string Name { get; set; }
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public List<string> Toppings { get; set; } = new();
    
    public void Prepare()
    {
        Console.WriteLine($"Preparing {Name} pizza...");
        Toppings.ForEach(topping => Console.WriteLine($" {topping}"));
    }
    
    public void Bake()
    {
        Console.WriteLine("Baking pizza for 25 minutes at 350 degrees...");
    }
    
    public virtual void Cut()
    {
        Console.WriteLine("Cutting pizza into diagonal slices...");
    }
    
    public void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box...");
    }
}

public enum PizzaFlavor
{
    Cheese = 0,
    Clam = 1,
    Pepperoni = 2,
    Veggie = 3
}