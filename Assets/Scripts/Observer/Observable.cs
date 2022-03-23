using System;
using System.Collections.Generic;

namespace TestObserver
{
    public class Subject : IObservable<int>
    {
        /// <summary>
        /// 購読者たちのリスト
        /// </summary>
        private List<IObserver<int>> _observersList = new List<IObserver<int>>();


        /// <summary>
        /// 購読を始めるメソッド
        /// </summary>
        /// <param name="observer">購読したいオブザーバ</param>
        /// <returns>購読解除用のクラス</returns>
        public IDisposable Subscribe(IObserver<int> observer)
        {
            if (!_observersList.Contains(observer))
            {
                _observersList.Add(observer);
            }

            return new Unsubscriber(_observersList, observer);
        }

        /// <summary>
        /// 値を送信するメソッド
        /// </summary>
        /// <param name="value">送信する値</param>
        public void SendNotice(int value)
        {
            foreach (var observer in _observersList)
            {
                observer.OnNext(value);
            }
        }

        /// <summary>
        /// 購読解除用の内部クラス
        /// </summary>
        public class Unsubscriber : IDisposable
        {
            private List<IObserver<int>> _observersList;
            private IObserver<int> _observer;

            /// <summary>
            /// 購読解除の対象を取得するメソッド
            /// </summary>
            /// <param name="observers">解除対象のリスト</param>
            /// <param name="observer">解除対象</param>
            public Unsubscriber(List<IObserver<int>> observers, IObserver<int> observer)
            {
                _observersList = observers;
                _observer = observer;

            }

            /// <summary>
            /// 購読を解除するメソッド
            /// </summary>
            public void Dispose()
            {
                _observersList.Remove(_observer);
            }
        }
    }
}