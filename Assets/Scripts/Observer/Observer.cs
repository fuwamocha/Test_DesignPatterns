using System;
using UnityEngine;

namespace TestObserver
{
    public class Observer : IObserver<int>
    {
        /// <summary>
        /// 購読者の名前
        /// </summary>
        private string _observerName;

        /// <summary>
        /// 購読者の名前を取得するコンストラクタ
        /// </summary>
        /// <param name="name"></param>
        public Observer(string name)
        {
            _observerName = name;
        }

        /// <summary>
        /// 購読完了時のメソッド
        /// </summary>
        public void OnCompleted()
        {
            Debug.Log($"{_observerName}が通知を受け取った");
        }
        /// <summary>
        /// 購読エラー時のメソッド
        /// </summary>
        /// <param name="ex">エラー内容</param>
        public void OnError(Exception ex)
        {
            Debug.Log($"{_observerName}がエラー{ex}を受け取った");
        }

        /// <summary>
        /// 購読時に呼ばれるメソッド
        /// </summary>
        /// <param name="value">受け取った値</param>
        public void OnNext(int value)
        {
            Debug.Log($"{_observerName}が{value}を受け取った");
        }
    }
}
