using DesignPatters.Studies.FactoryPattern.Franchises;

namespace DesignPatters.Studies.FactoryPattern;

public static class FactoryPatternDemo
{
    public static void RunPizzaStoreDemo()
    {
        Console.WriteLine("-------------------- Welcome to the Pizza Store -------------------- \n");
        Console.WriteLine("-------------------- Please select which style you wish ------------ \n");
        Console.WriteLine("0 - New York Style \n");
        Console.WriteLine("1 - California Style \n");
        Console.WriteLine("2 - Chicago Style \n");
        var pizzaStyle = Console.ReadLine();
        
        Console.WriteLine("------------------ Please select which flavor you'd like ----------- \n");
        Console.WriteLine("0 - Cheese \n");
        Console.WriteLine("1 - Clam \n");
        Console.WriteLine("2 - Pepperoni \n");
        Console.WriteLine("3 - Veggie \n");
        var pizzaFlavor = Convert.ToInt32(Console.ReadLine());

        PizzaStore selectedPizzaStore;
        switch (pizzaStyle)
        {
            case "0":
                selectedPizzaStore = new NYPizzaStore();
                break;
            case "1":
                selectedPizzaStore = new CaliforniaPizzaStore();
                break;
            case "2":
                selectedPizzaStore = new ChicagoPizzaStore();
                break;
            default:
                selectedPizzaStore = default;
                break;
        }

        Thread.Sleep(1000);
        
        Pizza selectedPizza = selectedPizzaStore?.OrderPizza((PizzaFlavor)pizzaFlavor);
        
        Thread.Sleep(1000);
        
        Console.WriteLine($" ------- Here's your {selectedPizza?.Name}! Enjoy!! ---------- \n");
    }
}