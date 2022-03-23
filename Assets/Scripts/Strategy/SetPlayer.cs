using UnityEngine;

namespace TestStrategy
{
    public class SetPlayer : MonoBehaviour
    {
        private FireWizard _fWizard;
        void Start()
        {
            // 炎の魔法使いを作成
            _fWizard = new FireWizard();
            _fWizard.PerformAttack();

            // 雷技を出させてみる
            _fWizard.SetAttackBehavior(new Thunder());
            _fWizard.PerformAttack();
        }
    }
}