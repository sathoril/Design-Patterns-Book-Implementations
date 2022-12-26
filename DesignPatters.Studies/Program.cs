using DesignPatters.Studies.DecoratorPattern;
using DesignPatters.Studies.FactoryPattern;
using DesignPatters.Studies.ObserverPattern;
using DesignPatters.Studies.StrategyPattern;

Console.WriteLine("-------------------- Let's start our demos!! -------------------- \n");

while (true)
{
    Console.WriteLine("-------------------- Now choose a pattern: -------------------- \n");
    Console.WriteLine("0 - StrategyPattern  - DuckSimulator \n");
    Console.WriteLine("1 - StrategyPattern  - MedievalGame \n");
    Console.WriteLine("2 - ObserverPattern  - Weather-O-Rama \n");
    Console.WriteLine("3 - DecoratorPattern - StarbuzzCoffee \n");
    Console.WriteLine("4 - FactoryPattern   - PizzaStore \n");
    
    var chosenPattern = Console.ReadLine();
    switch (chosenPattern)
    {
        case "0":
            StrategyPatternDemo.RunDuckSimulator();
            Console.WriteLine("\n");
            break;
        case "1":
            StrategyPatternDemo.RunMedievalGame();
            Console.WriteLine("\n");
            break;
        case "2":
            ObserverPatternDemo.RunWeatherORamaDemo();
            Console.WriteLine("\n");
            break;
        case "3":
            DecoratorPatternDemo.RunStarbuzzCoffeeDemo();
            Console.WriteLine("\n");
            break;
        case "4":
            FactoryPatternDemo.RunPizzaStoreDemo();
            Console.WriteLine("\n");
            break;
        default:
            Console.WriteLine("Chose a valid pattern. \n");
            break;
    }
}


