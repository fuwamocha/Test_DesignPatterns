using UnityEngine;

namespace TestStrategy
{
    public class Thunder : IAttack
    {
        /// <summary>
        /// 雷技で攻撃
        /// </summary>
        public void Attack()
        {
            Debug.Log("かみなりのわざが出る");
        }
    }
}