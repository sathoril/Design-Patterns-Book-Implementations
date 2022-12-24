namespace DesignPatters.Studies.DecoratorPattern.ConcreteDecorators;

public class Whip : CondimentDecorator
{
    public Whip(Beverage beverage) : base(beverage.Size)
    {
        this.Beverage = beverage;
    }

    public override string Description => Beverage.Description + ", With Whip"; 

    public override double Cost()
    {
        return this.Beverage.Cost() + 0.10;
    }
}