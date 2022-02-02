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

*/
