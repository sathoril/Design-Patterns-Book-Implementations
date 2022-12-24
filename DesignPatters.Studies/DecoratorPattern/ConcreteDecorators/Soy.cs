namespace DesignPatters.Studies.DecoratorPattern.ConcreteDecorators;

public class Soy : CondimentDecorator
{
    public Soy(Beverage beverage) : base(beverage.Size)
    {
        this.Beverage = beverage;
    }
    
    public override string Description => Beverage.Description + ", With Soy";
    
    public override double Cost()
    {
        return this.Beverage.Cost() + 0.15;
    }
}