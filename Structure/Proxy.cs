using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    namespace Proxy
    {
    }
}

/*
Паттерн Заместитель (Proxy) предоставляет объект-заместитель, который управляет доступом к другому объекту.
То есть создается объект-суррогат, который может выступать в роли другого объекта и замещать его.

    class Client
    {
        void Main()
        {
            Subject subject = new Proxy();
            subject.Request();
        }
    }
    abstract class Subject
    {
        public abstract void Request();
    }
 
    class RealSubject : Subject
    {
        public override void Request()
        {}
    }
    class Proxy : Subject
    {
        RealSubject realSubject;
        public override void Request()
        {
            if (realSubject == null)
                realSubject = new RealSubject();
            realSubject.Request();
        }
    }

Subject: определяет общий интерфейс для Proxy и RealSubject. 
Поэтому Proxy может использоваться вместо RealSubject

RealSubject: представляет реальный объект, для которого создается прокси

Proxy: заместитель реального объекта. Хранит ссылку на реальный объект, контролирует к нему доступ,
может управлять его созданием и удалением. При необходимости Proxy переадресует запросы объекту RealSubject

Client: использует объект Proxy для доступа к объекту RealSubject
*/
