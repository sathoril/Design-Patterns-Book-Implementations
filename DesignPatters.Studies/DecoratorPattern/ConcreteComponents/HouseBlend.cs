namespace DesignPatters.Studies.DecoratorPattern.ConcreteComponents;

public class HouseBlend : Beverage
{
    public HouseBlend(Size size) : base(size)
    {
    }
    
    public override string Description => "House Blend Coffee";
    
    public override double Cost()
    {
        switch (this.Size)
        {
            case Size.Grande:
                return 0.89;
            case Size.Tall:
                return 0.99;
            case Size.Venti:
                return 1.09;
            default:
                return default;
        }
    }
}