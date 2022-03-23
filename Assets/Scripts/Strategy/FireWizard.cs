namespace TestStrategy
{
    /// <summary>
    /// 炎の魔法使い
    /// </summary>
    public class FireWizard : Character
    {
        public FireWizard()
        {
            base.Attack = new Fire();
        }
    }
}