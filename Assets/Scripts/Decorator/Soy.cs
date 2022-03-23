namespace TestDecorator
{
    public class Soy : CondimentDecorator
    {
        Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + "、豆乳";
        }

        public override Size GetSize()
        {
            return _beverage.GetSize();
        }

        public override float Cost()
        {
            float cost = _beverage.Cost();

            if (GetSize() == Beverage.Size.Tall)
            {
                cost += BeverageParamsSO.Entity.SoyCost - BeverageParamsSO.Entity.ReducedCost;
            }
            else if (GetSize() == Beverage.Size.Grande)
            {
                cost += BeverageParamsSO.Entity.SoyCost;
            }
            else if (GetSize() == Beverage.Size.Venti)
            {
                cost += BeverageParamsSO.Entity.SoyCost + BeverageParamsSO.Entity.AdditionalCost;
            }
            return cost;
        }
    }
}