namespace TestDecorator
{
    public class Whip : CondimentDecorator
    {
        Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + "、ホイップ";
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
                cost += BeverageParamsSO.Entity.WhipCost - BeverageParamsSO.Entity.ReducedCost;
            }
            else if (GetSize() == Beverage.Size.Grande)
            {
                cost += BeverageParamsSO.Entity.WhipCost;
            }
            else if (GetSize() == Beverage.Size.Venti)
            {
                cost += BeverageParamsSO.Entity.WhipCost + BeverageParamsSO.Entity.AdditionalCost;
            }
            return cost;
        }
    }
}