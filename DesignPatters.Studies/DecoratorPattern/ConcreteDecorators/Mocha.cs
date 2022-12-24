namespace DesignPatters.Studies.DecoratorPattern.ConcreteDecorators;

public class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage) : base(beverage.Size)
    {
        this.Beverage = beverage;
    }
    
    public override string Description => Beverage.Description + ", With Mocha";
    
    public override double Cost()
    {
        return Beverage.Cost() + 0.20;
    }
}