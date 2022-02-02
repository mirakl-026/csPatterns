using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior
{
    namespace State
    {
    }
}

/*
Состояние (State) - шаблон проектирования, который позволяет объекту изменять свое поведение в зависимости
от внутреннего состояния.

    class Program
    {
        static void Main()
        {
            Context context = new Context(new StateA());
            context.Request(); // Переход в состояние StateB
            context.Request();  // Переход в состояние StateA
        }
    }

    abstract class State
    {
        public abstract void Handle(Context context);
    }

    class StateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new StateB();
        }
    }

    class StateB : State
    {
        public override void Handle(Context context)
        { 
            context.State = new StateA();
        }
    }
 
    class Context
    {
        public State State { get; set; }
        public Context(State state)
        {
            this.State = state;
        }
        public void Request()
        {
            this.State.Handle(this);
        }
    }

State: определяет интерфейс состояния

Классы StateA и StateB - конкретные реализации состояний

Context: представляет объект, поведение которого должно динамически изменяться в соответствии с состоянием. 
Выполнение же конкретных действий делегируется объекту состояния
*/

