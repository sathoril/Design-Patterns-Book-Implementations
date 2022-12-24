namespace DesignPatters.Studies.DecoratorPattern;

public abstract class CondimentDecorator : Beverage
{
    protected CondimentDecorator(Size size) : base(size)
    {
    }
    
    protected Beverage Beverage;
}