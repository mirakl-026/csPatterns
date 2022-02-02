using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation
{
    namespace Prototype
    {
        interface IFigure
        {
            IFigure Clone();
            void GetInfo();
        }

        class Rectangle : IFigure
        {
            int width;
            int height;
            public Rectangle(int w, int h)
            {
                width = w;
                height = h;
            }

            public IFigure Clone()
            {
                return new Rectangle(this.width, this.height);
            }
            public void GetInfo()
            {
                Console.WriteLine("Прямоугольник длиной {0} и шириной {1}", height, width);
            }
        }

        class Circle : IFigure
        {
            int radius;
            public Circle(int r)
            {
                radius = r;
            }

            public IFigure Clone()
            {
                return new Circle(this.radius);
            }
            public void GetInfo()
            {
                Console.WriteLine("Круг радиусом {0}", radius);
            }
        }
    }
}

/*
Паттерн Прототип (Prototype) позволяет создавать объекты на основе уже ранее созданных объектов-прототипов.
То есть по сути данный паттерн предлагает технику клонирования объектов.

    class Client
    {
        void Operation()
        {
            Prototype prototype = new ConcretePrototype1(1);
            Prototype clone = prototype.Clone();
            prototype = new ConcretePrototype2(2);
            clone = prototype.Clone();
        }
    }
 
    abstract class Prototype
    {
        public int Id { get; private set; }
        public Prototype(int id)
        {
            this.Id = id;
        }
        public abstract Prototype Clone();
    }
 
    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id)
            : base(id)
        { }
        public override Prototype Clone()
        {
            return new ConcretePrototype1(Id);
        }
    }
 
    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(int id)
            : base(id)
        { }
        public override Prototype Clone()
        {
            return new ConcretePrototype2(Id);
        }
    }


Prototype: определяет интерфейс для клонирования самого себя, который, как правило, представляет метод Clone()

ConcretePrototype1 и ConcretePrototype2: конкретные реализации прототипа. Реализуют метод Clone()

Client: создает объекты прототипов с помощью метода Clone()
*/