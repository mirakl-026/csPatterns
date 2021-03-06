using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior
{
    namespace Mediator
    {
    }
}

/*
Паттерн Посредник (Mediator) представляет такой шаблон проектирования, который обеспечивает
взаимодействие множества объектов без необходимости ссылаться друг на друга.
Тем самым достигается слабосвязанность взаимодействующих объектов.

    abstract class Mediator
    {
        public abstract void Send(string msg, Colleague colleague);
    }
 
    abstract class Colleague
    {
        protected Mediator mediator;
 
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
 
    class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator)
            : base(mediator)
        { }
  
        public void Send(string message)
        {
            mediator.Send(message, this);
        }
  
        public void Notify(string message)
        { }
    }
 
    class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator)
            : base(mediator)
        { }
  
        public void Send(string message)
        {
            mediator.Send(message, this);
        }
  
        public void Notify(string message)
        { }
    }
 
    class ConcreteMediator : Mediator
    {
        public ConcreteColleague1 Colleague1 { get; set; }
        public ConcreteColleague2 Colleague2 { get; set; }
        public override void Send(string msg, Colleague colleague)
        {
            if (Colleague1 == colleague)
                Colleague2.Notify(msg);
            else
                Colleague1.Notify(msg);
        }
    }

Mediator: представляет интерфейс для взаимодействия с объектами Colleague

Colleague: представляет интерфейс для взаимодействия с объектом Mediator

ConcreteColleague1 и ConcreteColleague2: конкретные классы коллег, которые обмениваются 
друг с другом через объект Mediator

ConcreteMediator: конкретный посредник, реализующий интерфейс типа Mediator
*/
