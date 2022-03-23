namespace TestDecorator
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            base.Description = "ダークローストコーヒー";
        }

        public override float Cost()
        {
            return BeverageParamsSO.Entity.DarkRoastCost;
        }
    }
}