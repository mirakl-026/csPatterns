using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior
{
    namespace Observer
    {
        interface IObserver
        {
            void Update(Object ob);
        }

        interface IObservable
        {
            void RegisterObserver(IObserver o);
            void RemoveObserver(IObserver o);
            void NotifyObservers();
        }

        class Stock : IObservable
        {
            StockInfo sInfo; // информация о торгах

            List<IObserver> observers;
            public Stock()
            {
                observers = new List<IObserver>();
                sInfo = new StockInfo();
            }
            public void RegisterObserver(IObserver o)
            {
                observers.Add(o);
            }

            public void RemoveObserver(IObserver o)
            {
                observers.Remove(o);
            }

            public void NotifyObservers()
            {
                foreach (IObserver o in observers)
                {
                    o.Update(sInfo);
                }
            }

            public void Market()
            {
                Random rnd = new Random();
                sInfo.USD = rnd.Next(20, 40);
                sInfo.Euro = rnd.Next(30, 50);
                NotifyObservers();
            }
        }

        class StockInfo
        {
            public int USD { get; set; }
            public int Euro { get; set; }
        }

        class Broker : IObserver
        {
            public string Name { get; set; }
            IObservable stock;
            public Broker(string name, IObservable obs)
            {
                this.Name = name;
                stock = obs;
                stock.RegisterObserver(this);
            }
            public void Update(object ob)
            {
                StockInfo sInfo = (StockInfo)ob;

                if (sInfo.USD > 30)
                    Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
                else
                    Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
            }
            public void StopTrade()
            {
                stock.RemoveObserver(this);
                stock = null;
            }
        }

        class Bank : IObserver
        {
            public string Name { get; set; }
            IObservable stock;
            public Bank(string name, IObservable obs)
            {
                this.Name = name;
                stock = obs;
                stock.RegisterObserver(this);
            }
            public void Update(object ob)
            {
                StockInfo sInfo = (StockInfo)ob;

                if (sInfo.Euro > 40)
                    Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
                else
                    Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
            }
        }
    }
}

/*
Паттерн "Наблюдатель" (Observer) представляет поведенческий шаблон проектирования, который использует отношение "один ко многим".
В этом отношении есть один наблюдаемый объект и множество наблюдателей.
И при изменении наблюдаемого объекта автоматически происходит оповещение всех наблюдателей.

Данный паттерн еще называют Publisher-Subscriber (издатель-подписчик), поскольку отношения издателя и подписчиков характеризуют действие данного паттерна:
подписчики подписываются email-рассылку определенного сайта. Сайт-издатель с помощью email-рассылки уведомляет всех подписчиков о изменениях.
А подписчики получают изменения и производят определенные действия: могут зайти на сайт, могут проигнорировать уведомления и т.д.

    interface IObservable
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    class ConcreteObservable : IObservable
    {
        private List<IObserver> observers;
        public ConcreteObservable()
        {
            observers = new List<IObserver>();
        }
        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }
 
        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
 
        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
                observer.Update();
        }
    }
 

    interface IObserver
    {
        void Update();
    }

    class ConcreteObserver :IObserver
    {
        public void Update()
        {
        }
    }

IObservable: представляет наблюдаемый объект. Определяет три метода: AddObserver() (для добавления наблюдателя), RemoveObserver() (удаление набюдателя) и NotifyObservers() (уведомление наблюдателей)

ConcreteObservable: конкретная реализация интерфейса IObservable. Определяет коллекцию объектов наблюдателей.

IObserver: представляет наблюдателя, который подписывается на все уведомления наблюдаемого объекта. 
Определяет метод Update(), который вызывается наблюдаемым объектом для уведомления наблюдателя.

ConcreteObserver: конкретная реализация интерфейса IObserver.

При этом наблюдаемому объекту не надо ничего знать о наблюдателе кроме того, что тот реализует метод Update(). 
С помощью отношения агрегации реализуется слабосвязанность обоих компонентов. Изменения в наблюдаемом объекте не виляют на наблюдателя и наоборот.

В определенный момент наблюдатель может прекратить наблюдение. 
И после этого оба объекта - наблюдатель и наблюдаемый могут продолжать существовать в системе независимо друг от друга.

*/