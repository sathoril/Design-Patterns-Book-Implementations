namespace DesignPatters.Studies.DecoratorPattern.ConcreteComponents;

public class Decaf : Beverage
{
    public Decaf(Size size) : base(size)
    {
    }
    
    public override string Description => "Decaf Coffee";
    
    public override double Cost()
    {
        switch (this.Size)
        {
            case Size.Grande:
                return 1.05;
            case Size.Tall:
                return 1.15;
            case Size.Venti:
                return 1.25;
            default:
                return default;
        }
    }
}