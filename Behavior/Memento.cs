using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior
{
    namespace Memento
    {
    }
}

/*
Паттерн Хранитель (Memento) позволяет выносить внутреннее состояние объекта за его пределы для последующего
возможного восстановления объекта без нарушения принципа инкапсуляции.

    class Memento
    {
        public string State { get; private set;}
        public Memento(string state)
        {
            this.State = state;
        }
    }
 
    class Caretaker
    {
        public Memento Memento { get; set; }
    }
 
    class Originator
    {
        public string State { get; set; }
        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }
        public Memento CreateMemento()
        {
            return new Memento(State);
        }
    }

Memento: хранитель, который сохраняет состояние объекта Originator и предоставляет полный доступ
только этому объекту Originator

Originator: создает объект хранителя для сохранения своего состояния

Caretaker: выполняет только функцию хранения объекта Memento, в то же время у него нет полного доступа
к хранителю и никаких других операций над хранителем, кроме собственно сохранения, он не производит
*/
