using DesignPatters.Studies.StrategyPattern.DuckSimulator;
using DesignPatters.Studies.StrategyPattern.DuckSimulator.Strategies.ConcreteStrategies.Fly;
using DesignPatters.Studies.StrategyPattern.DuckSimulator.Strategies.ConcreteStrategies.Quacks;
using DesignPatters.Studies.StrategyPattern.DuckSimulator.Subclasses;
using DesignPatters.Studies.StrategyPattern.MedievalGame;
using DesignPatters.Studies.StrategyPattern.MedievalGame.Strategies;

namespace DesignPatters.Studies.StrategyPattern;

public static class StrategyPatternDemo
{
    public static void RunDuckSimulator()
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
    
    public static void RunMedievalGame()
    {
        Console.WriteLine("Hello to our MedievalGame! Lets see some fights..\n");
    
        bool exit = true;
        while (exit) 
        {
            Console.WriteLine("First, choose one type of Warrior to see: \n");
            Console.WriteLine($"Type the number that matches the Warrior type you want to see! (to leave, press 9)");
    
            Console.WriteLine($" 0 - King");
            Console.WriteLine($" 1 - Queen");
            Console.WriteLine($" 2 - Troll");
            Console.WriteLine($" 3 - Knight");
            
            var chosenWarrior = Console.ReadLine();
            if (chosenWarrior == 9.ToString())
            {
                exit = false;
                continue;
            }
            
            Console.WriteLine($"Type the number that matches the Weapon you want your character to use! (to leave, press 9)");
    
            Console.WriteLine($" 0 - Knife");
            Console.WriteLine($" 1 - Sword");
            Console.WriteLine($" 2 - Axe");
            Console.WriteLine($" 3 - Bow");

            var chosenWeapon = Console.ReadLine();
            if (chosenWeapon == 9.ToString())
            {
                exit = false;
                continue;
            }
    
            Character chosenCharacterWithWeapon = GetSelectedWarriorImplementation(chosenWarrior, chosenWeapon);
            chosenCharacterWithWeapon.Speak();
            chosenCharacterWithWeapon.UseWeapon();
        
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
    
    private static Character GetSelectedWarriorImplementation(string? chosenWarrior, string? chosenWeapon)
    {
        // When we instantiate a specific ConcreteStrategy, we are able to change the behaviour (change the algorithm, during runtime)
        switch (chosenWarrior)
        {
            case "0":
                return new King(GetSelectedWeaponImplementation(chosenWeapon));
            case "1":
                return new Queen(GetSelectedWeaponImplementation(chosenWeapon));
            case "2":
                return new Troll(GetSelectedWeaponImplementation(chosenWeapon));
            case "3":
                return new Knight(GetSelectedWeaponImplementation(chosenWeapon));
            default:
                return default;
        }
    }

    private static IWeaponBehaviour GetSelectedWeaponImplementation(string? chosenWeapon)
    {
        // When we instantiate a specific ConcreteStrategy, we are able to change the behaviour (change the algorithm, during runtime)
        switch (chosenWeapon)
        {
            case "0":
                return new KnifeBehaviour();
            case "1":
                return new SwordBehaviour();
            case "2":
                return new AxeBehaviour();
            case "3":
                return new BowBehaviour();
            default:
                return default;
        }
    }
}