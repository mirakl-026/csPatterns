using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    namespace Bridge
    {
    }
}

/*
Мост (Bridge) - структурный шаблон проектирования, который позволяет отделить абстракцию от реализации
таким образом, чтобы и абстракцию, и реализацию можно было изменять независимо друг от друга.

Даже если мы отделим абстракцию от конкретных реализаций, то у нас все равно все наследуемые классы
будут жестко привязаны к интерфейсу, определяемому в базовом абстрактном классе.
Для преодоления жестких связей и служит паттерн Мост.

    class Client
    {
        static void Main()
        {
            Abstraction abstraction;
            abstraction = new RefinedAbstraction(new ConcreteImplementorA());
            abstraction.Operation();
            abstraction.Implementor=new ConcreteImplementorB();
            abstraction.Operation();
        }
    }
    abstract class Abstraction
    {
        protected Implementor implementor;
        public Implementor Implementor
        {
            set { implementor = value; }
        }
        public Abstraction(Implementor imp)
        {
            implementor = imp;
        }
        public virtual void Operation()
        {
            implementor.OperationImp();
        }
    }
 
    abstract class Implementor
    {
        public abstract void OperationImp();
    }
 
    class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementor imp)
            : base(imp)
        {}
        public override void Operation()
        {
        }
    }
 
    class ConcreteImplementorA : Implementor
    {
        public override void OperationImp()
        {
        }
    }
 
    class ConcreteImplementorB : Implementor
    {
        public override void OperationImp()
        {
        }
    }

Abstraction: определяет базовый интерфейс и хранит ссылку на объект Implementor. 
Выполнение операций в Abstraction делегируется методам объекта Implementor

RefinedAbstraction: уточненная абстракция, наследуется от Abstraction и расширяет унаследованный интерфейс

Implementor: определяет базовый интерфейс для конкретных реализаций.
Как правило, Implementor определяет только примитивные операции.
Более сложные операции, которые базируются на примитивных, определяются в Abstraction

ConcreteImplementorA и ConcreteImplementorB: конкретные реализации, которые унаследованы от Implementor

Client: использует объекты Abstraction
*/