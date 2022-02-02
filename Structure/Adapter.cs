using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    namespace Adapter
    {
    }
}

/*
 * 
Паттерн Адаптер (Adapter) предназначен для преобразования интерфейса одного класса в интерфейс другого. 
Благодаря реализации данного паттерна мы можем использовать вместе классы с несовместимыми интерфейсами.

    class Client
    {
        public void Request(Target target)
        {
            target.Request();
        }
    }

    // класс, к которому надо адаптировать другой класс   
    class Target
    {
        public virtual void Request()
        {}
    }
  
    // Адаптер
    class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();
  
        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
  
    // Адаптируемый класс
    class Adaptee
    {
        public void SpecificRequest()
        {}
    }


Target: представляет объекты, которые используются клиентом

Client: использует объекты Target для реализации своих задач

Adaptee: представляет адаптируемый класс, который мы хотели бы использовать у клиента вместо объектов Target

Adapter: собственно адаптер, который позволяет работать с объектами Adaptee как с объектами Target.

То есть клиент ничего не знает об Adaptee, он знает и использует только объекты Target.
И благодаря адаптеру мы можем на клиенте использовать объекты Adaptee как Target
*/
