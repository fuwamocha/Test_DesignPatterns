using System;
using UnityEngine;

namespace TestObserver
{
    public class SetObserver : MonoBehaviour
    {
        private void Start()
        {
            // 購読者の名前を登録
            var myObserver = new Observer("オブザーバさん");
            var myObserver2 = new Observer("オブザーバ2さん");

            // 送信側のインスタンスを生成
            var mySubject = new Subject();

            // 購読開始
            IDisposable myDisposable = mySubject.Subscribe(myObserver);
            IDisposable myDisposable2 = mySubject.Subscribe(myObserver2);

            // 値を送ってみる
            mySubject.SendNotice(1);

            // 一人目の購読を解除する
            myDisposable.Dispose();

            // もう一度値を送ってみる
            mySubject.SendNotice(2);
        }
    }
}