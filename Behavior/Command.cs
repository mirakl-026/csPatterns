﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior
{
    namespace Command
    {

    }
}
/*

Паттерн "Команда" (Command) позволяет инкапсулировать запрос на выполнение определенного действия в виде отдельного объекта.
Этот объект запроса на действие и называется командой. При этом объекты, инициирующие запросы на выполнение действия, отделяются от объектов, которые выполняют это действие.

Команды могут использовать параметры, которые передают ассоциированную с командой информацию. 
Кроме того, команды могут ставиться в очередь и также могут быть отменены.


    class Client
    {  
        void Main()
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            ConcreteCommand command=new ConcreteCommand(receiver);
            invoker.SetCommand(command);
            invoker.Run();
        }
    }

    abstract class Command
    {
        public abstract void Execute();
        public abstract void Undo();
    }

    // конкретная команда
    class ConcreteCommand : Command
    {
        Receiver receiver;
        public ConcreteCommand(Receiver r)
        {
            receiver = r;
        }
        public override void Execute()
        {
            receiver.Operation();
        }
 
        public override void Undo()
        {}
    }
 
    // получатель команды
    class Receiver
    {
        public void Operation()
        { }
    }

    // инициатор команды
    class Invoker
    {
        Command command;
        public void SetCommand(Command c)
        {
            command = c;
        }

        public void Run()
        {
            command.Execute();
        }

        public void Cancel()
        {
            command.Undo();
        }
    }

Command: интерфейс, представляющий команду. Обычно определяет метод Execute() для выполнения действия, а также нередко включает метод Undo(),
реализация которого должна заключаться в отмене действия команды

ConcreteCommand: конкретная реализация команды, реализует метод Execute(), в котором вызывается определенный метод, определенный в классе Receiver

Receiver: получатель команды. Определяет действия, которые должны выполняться в результате запроса.

Invoker: инициатор команды - вызывает команду для выполнения определенного запроса

Client: клиент - создает команду и устанавливает ее получателя с помощью метода SetCommand()



Таким образом, инициатор, отправляющий запрос, ничего не знает о получателе, который и будет выполнять команду. 
Кроме того, если нам потребуется применить какие-то новые команды, мы можем просто унаследовать классы от абстрактного класса Command и реализовать его методы Execute и Undo.

В программах на C# команды находят довольно широкое применение.
Так, в технологии WPF и других технологиях, которые используют XAML и подход MVVM, на командах во многом базируется взаимодействие с пользователем. 
В некоторых архитектурах, например, в архитектуре CQRS, команды являются одним из ключевых компонентов.
*/