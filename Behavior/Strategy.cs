using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior
{
    namespace Strategy
    {
        interface IMovable
        {
            void Move();
        }

        class PetrolMove : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Перемещение на бензине");
            }
        }

        class ElectricMove : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Перемещение на электричестве");
            }
        }
        class Car
        {
            protected int passengers; // кол-во пассажиров
            protected string model; // модель автомобиля

            public Car(int num, string model, IMovable mov)
            {
                this.passengers = num;
                this.model = model;
                Movable = mov;
            }
            public IMovable Movable { private get; set; }
            public void Move()
            {
                Movable.Move();
            }
        }
    }
}

/*
Паттерн Стратегия (Strategy) представляет шаблон проектирования, который определяет набор алгоритмов, инкапсулирует каждый из них и обеспечивает их взаимозаменяемость.
В зависимости от ситуации мы можем легко заменить один используемый алгоритм другим.
При этом замена алгоритма происходит независимо от объекта, который использует данный алгоритм.

    public interface IStrategy
    {
        void Algorithm();
    }
 
    public class ConcreteStrategy1 : IStrategy
    {
        public void Algorithm()
        {}
    }
 
    public class ConcreteStrategy2 : IStrategy
    {
        public void Algorithm()
        {}
    }
 
    public class Context
    {
        public IStrategy ContextStrategy { get; set; }
 
        public Context(IStrategy _strategy)
        {
            ContextStrategy = _strategy;
        }
 
        public void ExecuteAlgorithm()
        {
            ContextStrategy.Algorithm();
        }
    }

Интерфейс IStrategy, который определяет метод Algorithm(). 
Это общий интерфейс для всех реализующих его алгоритмов. Вместо интерфейса здесь также можно было бы использовать абстрактный класс.

Классы ConcreteStrategy1 и ConcreteStrategy, которые реализуют интерфейс IStrategy, предоставляя свою версию метода Algorithm().
Подобных классов-реализаций может быть множество.

Класс Context хранит ссылку на объект IStrategy и связан с интерфейсом IStrategy отношением агрегации.

В данном случае объект IStrategy заключена в свойстве ContextStrategy, хотя также для нее можно было бы определить приватную переменную, 
а для динамической установки использовать специальный метод.
*/
