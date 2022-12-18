using DesignPatters.Studies.DuckClasses;

Console.WriteLine("-------------------- Let's start our demos!! -------------------- \n");

while (true)
{
    Console.WriteLine("-------------------- Now choose a pattern: -------------------- \n");
    Console.WriteLine("0 - StrategyPattern \n");
    var chosenPattern = Console.ReadLine();
    switch (chosenPattern)
    {
        case "0":
            StrategyPatternDemo.RunDemo();
            Console.WriteLine("\n");
            break;
        default:
            Console.WriteLine("Chose a valid pattern. \n");
            break;
    }
}


