using UnityEngine;

namespace TestDecorator
{
    public class SetCoffie : MonoBehaviour
    {
        private void Start()
        {
            Beverage beverage = new Espresso();
            beverage.SetSize(Beverage.Size.Tall);
            Debug.Log(beverage.GetDescription() + " $" + beverage.Cost());

            Beverage beverage2 = new DarkRoast();
            beverage2.SetSize(Beverage.Size.Grande);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Debug.Log(beverage2.GetDescription() + " $" + beverage2.Cost());

            Beverage beverage3 = new HouseBlend();
            beverage3.SetSize(Beverage.Size.Venti);
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Debug.Log(beverage3.GetDescription() + " $" + beverage3.Cost());

        }
    }
}