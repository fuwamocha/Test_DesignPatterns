namespace TestDecorator
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string GetDescription();
        public abstract override Size GetSize();

        public abstract override float Cost();
    }
}