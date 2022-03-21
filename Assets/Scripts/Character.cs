
namespace TestStrategy
{
    public class Character
    {
        public IAttack Attack { get; set; }

        public Character() { }

        /// <summary>
        /// 振る舞いを委譲
        /// </summary>
        public void PerformAttack()
        {
            Attack.Attack();
        }

        /// <summary>
        /// 攻撃をセットする
        /// </summary>
        /// <param name="attack">攻撃の種類</param>
        public void SetAttackBehavior(IAttack attack)
        {
            Attack = attack;
        }
    }
}
