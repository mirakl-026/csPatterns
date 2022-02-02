using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    namespace Facade
    {
    }
}

/*
Фасад (Facade) представляет шаблон проектирования, который позволяет скрыть сложность системы 
с помощью предоставления упрощенного интерфейса для взаимодействия с ней.

    class SubsystemA
    {
        public void A1()
        {}
    }

    class SubsystemB
    {
        public void B1()
        {}
    }

    class SubsystemC
    {
        public void C1()
        {}
    }
 
    public class Facade
    {
        SubsystemA subsystemA;
        SubsystemB subsystemB;
        SubsystemC subsystemC;
 
        public Facade(SubsystemA sa, SubsystemB sb, SubsystemC sc)
        {
            subsystemA = sa;
            subsystemB = sb;
            subsystemC = sc;
        }
        public void Operation1()
        {
            subsystemA.A1();
            subsystemB.B1();
            subsystemC.C1();
        }
        public void Operation2()
        {
            subsystemB.B1();
            subsystemC.C1();
        }
    }
 
    class Client
    {
        public void Main()
        {
            Facade facade = new Facade(new SubsystemA(), new SubsystemB(), new SubsystemC());
            facade.Operation1();
            facade.Operation2();
        }
    }

Классы SubsystemA, SubsystemB, SubsystemC и т.д. являются компонентами сложной подсистемы,
с которыми должен взаимодействовать клиент

Client взаимодействует с компонентами подсистемы

Facade - непосредственно фасад, который предоставляет интерфейс клиенту для работы с компонентами
*/
