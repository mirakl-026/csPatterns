using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior
{
    namespace TemplateMethod
    {

    }
}

/*
Шаблонный метод (Template Method) определяет общий алгоритм поведения подклассов,
позволяя им переопределить отдельные шаги этого алгоритма без изменения его структуры.

    abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Operation1();
            Operation2();
        }
        public abstract void Operation1();
        public abstract void Operation2();
    }
 
    class ConcreteClass : AbstractClass
    {
        public override void Operation1()
        {
        }
 
        public override void Operation2()
        {
        }
    }

AbstractClass: определяет шаблонный метод TemplateMethod(), который реализует алгоритм. 
Алгоритм может состоять из последовательности вызовов других методов, часть из которых может быть абстрактными
и должны быть переопределены в классах-наследниках. При этом сам метод TemplateMethod(), представляющий
структуру алгоритма, переопределяться не должен.

ConcreteClass: подкласс, который может переопределять различные методы родительского класса.

*/