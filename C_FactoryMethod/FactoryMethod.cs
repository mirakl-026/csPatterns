using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation
{
    namespace FactoryMethod
    {
        // абстрактный класс строителя
        abstract class Builder
        {
            public string Name { get; set; }

            public Builder(string n)
            {
                Name = n;
            }
            // фабричный метод
            abstract public House Create();
        }

        // строит панельные дома
        class PanelBuilder : Builder
        {
            public PanelBuilder(string n) : base(n)
            { }

            public override House Create()
            {
                return new PanelHouse();
            }
        }
        // строит деревянные дома
        class WoodBuilder : Builder
        {
            public WoodBuilder(string n) : base(n)
            { }

            public override House Create()
            {
                return new WoodHouse();
            }
        }


        abstract class House
        { }

        class PanelHouse : House
        {
            public PanelHouse()
            {
                Console.WriteLine("Панельный дом построен");
            }
        }
        class WoodHouse : House
        {
            public WoodHouse()
            {
                Console.WriteLine("Деревянный дом построен");
            }
        }
    }
}

/*
    abstract class Product
    { }

    class ConcreteProductA : Product
    { }

    class ConcreteProductB : Product
    { }

    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductA(); }
    }

    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductB(); }
    }


https://metanit.com/sharp/patterns/2.1.php
Абстрактный класс Product определяет интерфейс класса, объекты которого надо создавать.

Конкретные классы ConcreteProductA и ConcreteProductB представляют реализацию класса Product. Таких классов может быть множество

Абстрактный класс Creator определяет абстрактный фабричный метод FactoryMethod(), который возвращает объект Product.

Конкретные классы ConcreteCreatorA и ConcreteCreatorB - наследники класса Creator, определяющие свою реализацию метода FactoryMethod().
Причем метод FactoryMethod() каждого отдельного класса-создателя возвращает определенный конкретный тип продукта.
Для каждого конкретного класса продукта определяется свой конкретный класс создателя.

Таким образом, класс Creator делегирует создание объекта Product своим наследникам. 
А классы ConcreteCreatorA и ConcreteCreatorB могут самостоятельно выбирать какой конкретный тип продукта им создавать.

*/
