using DesignPatters.Studies.DecoratorPattern.ConcreteComponents;
using DesignPatters.Studies.DecoratorPattern.ConcreteDecorators;

namespace DesignPatters.Studies.DecoratorPattern;

public static class DecoratorPatternDemo
{
    public static void RunStarbuzzCoffeeDemo()
    {
        Console.WriteLine($"Creating first beverage...");
        Thread.Sleep(1000);
        
        // ----------------------------------------------------------------------------------------
        
        Beverage beverage = new Espresso(Size.Tall);
        Console.WriteLine($"This is a {beverage.Description} for {beverage.Cost()}");
        
        // ----------------------------------------------------------------------------------------
        
        Console.WriteLine($"Creating second beverage...");
        Thread.Sleep(1000);
        
        Beverage beverage2 = new DarkRoast(Size.Grande);
        beverage2 = new Mocha(beverage2);
        beverage2 = new Mocha(beverage2);
        beverage2 = new Whip(beverage2);
        
        Console.WriteLine($"This is a {beverage2.Description} for {beverage2.Cost()}");
        
        // ----------------------------------------------------------------------------------------
        
        Console.WriteLine($"Creating third beverage...");
        Thread.Sleep(1000);
        
        Beverage beverage3 = new HouseBlend(Size.Venti);
        beverage3 = new Soy(beverage3);
        beverage3 = new Mocha(beverage3);
        beverage3 = new Whip(beverage3);
        
        Console.WriteLine($"This is a {beverage3.Description} for {beverage3.Cost()}");
    }
}