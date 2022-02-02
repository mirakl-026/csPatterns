using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior
{
    namespace ChainOfResponsibility
    {
    }
}
/*
Цепочка Обязанностей (Chain of responsibility) - поведенческий шаблон проектирования, который позволяет
избежать жесткой привязки отправителя запроса к получателю.

Все возможные обработчики запроса образуют цепочку, а сам запрос перемещается по этой цепочке.
Каждый объект в этой цепочке при получении запроса выбирает, либо закончить обработку запроса, 
либо передать запрос на обработку следующему по цепочке объекту.


    class Client
    {
        void Main()
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            h1.Successor = h2;
            h1.HandleRequest(2);
        }
    }

    abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void HandleRequest(int condition);
    }
 
    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int condition)
        {
            // некоторая обработка запроса
         
            if (condition==1)
            {
                // завершение выполнения запроса;
            }
            // передача запроса дальше по цепи при наличии в ней обработчиков
            else if (Successor != null)
            {
                Successor.HandleRequest(condition);
            }
        }
    }
 
    class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int condition)
        {
            // некоторая обработка запроса
         
            if (condition==2)
            {
                // завершение выполнения запроса;
            }
            // передача запроса дальше по цепи при наличии в ней обработчиков
            else if (Successor != null)
            {
                Successor.HandleRequest(condition);
            }
        }
    }

Handler: определяет интерфейс для обработки запроса. Также может определять ссылку на следующий обработчик
запроса

ConcreteHandler1 и ConcreteHandler2: конкретные обработчики, которые реализуют функционал
для обработки запроса. При невозможности обработки и наличия ссылки на следующий обработчик, передают запрос 
этому обработчику

В данном случае для простоты примера в качестве параметра передается некоторое число, сначала обработчик
обрабатывает запрос и, если передано соответствующее число, завершает его обработку. Иначе передает запрос 
на обработку следующем в цепи обработчику при его наличии.

Client: отправляет запрос объекту Handler

*/
