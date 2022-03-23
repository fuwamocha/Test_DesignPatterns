namespace TestDecorator
{
    public class Mocha : CondimentDecorator
    {
        Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + "、モカ";
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
                cost += BeverageParamsSO.Entity.MochaCost - BeverageParamsSO.Entity.ReducedCost;
            }
            else if (GetSize() == Beverage.Size.Grande)
            {
                cost += BeverageParamsSO.Entity.MochaCost;
            }
            else if (GetSize() == Beverage.Size.Venti)
            {
                cost += BeverageParamsSO.Entity.MochaCost + BeverageParamsSO.Entity.AdditionalCost;
            }
            return cost;
        }
    }
}