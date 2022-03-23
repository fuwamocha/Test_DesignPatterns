namespace TestDecorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            base.Description = "ハウスブレンドコーヒー";
        }

        public override float Cost()
        {
            return BeverageParamsSO.Entity.HouseBlendCost;
        }
    }
}