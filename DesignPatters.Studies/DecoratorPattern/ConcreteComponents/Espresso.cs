namespace DesignPatters.Studies.DecoratorPattern.ConcreteComponents;

public class Espresso : Beverage
{   
    public Espresso(Size size) : base(size)
    {
    }
    public override string Description => "Espresso Coffee";
    
    public override double Cost()
    {
        switch (this.Size)
        {
            case Size.Grande:
                return 1.99;
            case Size.Tall:
                return 2.09;
            case Size.Venti:
                return 2.19;
            default:
                return default;
        }
    }
}