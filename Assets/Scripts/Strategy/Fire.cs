using UnityEngine;

namespace TestStrategy
{
    public class Fire : IAttack
    {
        /// <summary>
        /// 炎技で攻撃
        /// </summary>
        public void Attack()
        {
            Debug.Log("ほのおのわざが出る");
        }
    }
}