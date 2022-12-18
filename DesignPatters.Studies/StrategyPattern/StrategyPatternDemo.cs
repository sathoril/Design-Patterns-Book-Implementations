using DesignPatters.Studies.DuckClasses.Subclasses;
using DesignPatters.Studies.DuckRefactoredClasses.Behaviours;
using DesignPatters.Studies.DuckRefactoredClasses.Behaviours.Fly;

namespace DesignPatters.Studies.DuckClasses;

public static class StrategyPatternDemo
{
    public static void RunDemo()
    {
        Console.WriteLine("Hello to our DuckSimulator! Lets see some ducks..\n");
    
        bool exit = true;
        while (exit) 
        {
            Console.WriteLine("First, choose one Type of Duck to see: \n");
            Console.WriteLine($"Type the number that matches the Duck type you want to see! (to leave, press 9)");
    
            Console.WriteLine($" 0 - MallardDuck");
            Console.WriteLine($" 1 - RedheadDuck");
            Console.WriteLine($" 2 - RubberDuck");
            Console.WriteLine($" 3 - WoodenDuck");
            Console.WriteLine($" 4 - ModelDuck");
    
            var chosenDuck = Console.ReadLine();
            if (chosenDuck == 9.ToString())
            {
                exit = false;
                continue;
            }
    
            Duck chosenDuckInstance = GetSelectedDuckImplementation(chosenDuck);
            chosenDuckInstance.Display();
            chosenDuckInstance.PerformQuack();
            chosenDuckInstance.Swim();
            chosenDuckInstance.PerformFlying();
        
            Console.WriteLine("\n\n");
        }
    }
    
    private static Duck GetSelectedDuckImplementation(string? chosenDuck)
    {
        // When we instantiate a specific ConcreteStrategy, we are able to change the behaviour (change the algorithm, during runtime)
        switch (chosenDuck)
        {
            case "0":
                return new MallardDuck(new FlyWithWings(), new SimpleQuack());
            case "1":
                return new RedheadDuck(new FlyWithWings(), new SimpleQuack());
            case "2":
                return new RubberDuck(new FlyNoWay(), new Squeak());
            case "3":
                return new WoodenDuck(new FlyNoWay(), new MuteQuack());
            case "4":
                return new ModelDuck(new FlyRocketPowered(), new MuteQuack());
            default:
                return default;
        }
    }
}