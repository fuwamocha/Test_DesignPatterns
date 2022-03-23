namespace TestDecorator
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            base.Description = "エスプレッソ";
        }

        public override float Cost()
        {
            return BeverageParamsSO.Entity.EspressoCost;
        }
    }
}