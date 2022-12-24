namespace DesignPatters.Studies.DecoratorPattern.ConcreteComponents;

public class DarkRoast : Beverage
{
    public DarkRoast(Size size) : base(size)
    {
    }
    
    public override string Description => "Dark Roast Coffee";
    public override double Cost()
    {
        switch (this.Size)
        {
            case Size.Grande:
                return 0.99;
            case Size.Tall:
                return 1.09;
            case Size.Venti:
                return 1.19;
            default:
                return default;
        }
    }
}