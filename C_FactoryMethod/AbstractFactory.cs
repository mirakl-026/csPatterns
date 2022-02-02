using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation
{
    namespace AbstractFactory
    {
        //абстрактный класс - оружие
        abstract class Weapon
        {
            public abstract void Hit();
        }
        // абстрактный класс движение
        abstract class Movement
        {
            public abstract void Move();
        }

        // класс арбалет
        class Crossbow : Weapon
        {
            public override void Hit()
            {
                Console.WriteLine("Стреляем из арбалета");
            }
        }
        // класс меч
        class Sword : Weapon
        {
            public override void Hit()
            {
                Console.WriteLine("Бьем мечом");
            }
        }

        // движение полета
        class FlyMovement : Movement
        {
            public override void Move()
            {
                Console.WriteLine("Летим");
            }
        }

        // движение - бег
        class RunMovement : Movement
        {
            public override void Move()
            {
                Console.WriteLine("Бежим");
            }
        }

        // класс абстрактной фабрики
        abstract class HeroFactory
        {
            public abstract Movement CreateMovement();
            public abstract Weapon CreateWeapon();
        }

        // Фабрика создания летящего героя с арбалетом
        class ElfFactory : HeroFactory
        {
            public override Movement CreateMovement()
            {
                return new FlyMovement();
            }

            public override Weapon CreateWeapon()
            {
                return new Crossbow();
            }
        }

        // Фабрика создания бегущего героя с мечом
        class WarriorFactory : HeroFactory
        {
            public override Movement CreateMovement()
            {
                return new RunMovement();
            }

            public override Weapon CreateWeapon()
            {
                return new Sword();
            }
        }

        // клиент - сам супергерой
        class Hero
        {
            private Weapon weapon;
            private Movement movement;
            public Hero(HeroFactory factory)
            {
                weapon = factory.CreateWeapon();
                movement = factory.CreateMovement();
            }
            public void Run()
            {
                movement.Move();
            }
            public void Hit()
            {
                weapon.Hit();
            }
        }
    }
}





/*
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    abstract class AbstractProductA
    { }

    abstract class AbstractProductB
    { }

    class ProductA1 : AbstractProductA
    { }

    class ProductB1 : AbstractProductB
    { }

    class ProductA2 : AbstractProductA
    { }

    class ProductB2 : AbstractProductB
    { }

    class Client
    {
        private AbstractProductA abstractProductA;
        private AbstractProductB abstractProductB;

        public Client(AbstractFactory factory)
        {
            abstractProductB = factory.CreateProductB();
            abstractProductA = factory.CreateProductA();
        }
        public void Run()
        { }
    }


https://metanit.com/sharp/patterns/2.2.php
Абстрактные классы AbstractProductA и AbstractProductB определяют интерфейс для классов, объекты которых будут создаваться в программе.

Конкретные классы ProductA1 / ProductA2 и ProductB1 / ProductB2 представляют конкретную реализацию абстрактных классов

Абстрактный класс фабрики AbstractFactory определяет методы для создания объектов. Причем методы возвращают абстрактные продукты,
а не их конкретные реализации.

Конкретные классы фабрик ConcreteFactory1 и ConcreteFactory2 реализуют абстрактные методы базового класса и 
непосредственно определяют какие конкретные продукты использовать

Класс клиента Client использует класс фабрики для создания объектов.
При этом он использует исключительно абстрактный класс фабрики AbstractFactory и абстрактные классы продуктов AbstractProductA и AbstractProductB
и никак не зависит от их конкретных реализаций

*/