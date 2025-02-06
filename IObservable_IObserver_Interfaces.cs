using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_Programming
{
    public class IObservable_IObserver_Interfaces
    {

        public class MyObservable : IObservable<int>
        {
            List<IObserver<int>> _observers = new();
            public IDisposable Subscribe(IObserver<int> observer)
            {
                if ( !_observers.Contains(observer))
                {
                    _observers.Add(observer);
                }


                return new Unsubscription(() => {
                 _observers.Remove(observer);
                observer.OnCompleted();
                });



            }

            public void NotifyObservers(int value)
            {
                foreach (var observer in _observers)
                {
                    observer.OnNext(value);
                }
            }
        }

        public class Unsubscription(Action? unSubscription) : IDisposable
        {
            public void Dispose()
            {
                unSubscription?.Invoke();
                unSubscription = null;
            }
        }

        public class MyObserver(string observerName) : IObserver<int>
        {
            public void OnCompleted() => Console.WriteLine($" {observerName} takibi tamamladı");

            public void OnError(Exception error) => Console.WriteLine($" {observerName} hata aldı");

            public void OnNext(int value) => Console.WriteLine($"{observerName}  observer: {value}");
        }


    }
}
