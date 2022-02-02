using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior
{
    namespace Visitor
    {
    }
}

/*
Паттерн Посетитель (Visitor) позволяет определить операцию для объектов других классов без изменения
этих классов.

При использовании паттерна Посетитель определяются две иерархии классов: одна для элементов, для которых
надо определить новую операцию, и вторая иерархия для посетителей, описывающих данную операцию.

    class Client
    {
        void Main()
        {
            var structure = new ObjectStructure();
            structure.Add(new ElementA());
            structure.Add(new ElementB());
            structure.Accept(new ConcreteVisitor1());
            structure.Accept(new ConcreteVisitor2());
        }
    }
 
    abstract class Visitor
    {
        public abstract void VisitElementA(ElementA elemA);
        public abstract void VisitElementB(ElementB elemB);
    }
 
    class ConcreteVisitor1 : Visitor
    {
        public override void VisitElementA(ElementA elementA)
        {
            elementA.OperationA();
        }
        public override void VisitElementB(ElementB elementB)
        {
                elementB.OperationB();
        }
    }
    class ConcreteVisitor2 : Visitor
    {
        public override void VisitElementA(ElementA elementA)
        {
            elementA.OperationA();
        }
        public override void VisitElementB(ElementB elementB)
        {
            elementB.OperationB();
        }
    }
 
    class ObjectStructure
    {
        List<Element> elements = new List<Element>();
        public void Add(Element element)
        {
            elements.Add(element);
        }
        public void Remove(Element element)
        {
            elements.Remove(element);
        }
        public void Accept(Visitor visitor)
        {
            foreach (Element element in elements)
                element.Accept(visitor);
        }
    }
 
    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
        public string SomeState { get; set; }
    }
 
    class ElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElementA(this);
        }
        public void OperationA()
        { }
    }
 
    class ElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElementB(this);
        }
        public void OperationB()
        { }
    }

Visitor: интерфейс посетителя, который определяет метод Visit() для каждого объекта Element

ConcreteVisitor1 / ConcreteVisitor2: конкретные классы посетителей, реализуют интерфейс,
определенный в Visitor.

Element: определяет метод Accept(), в котором в качестве параметра принимается объект Visitor

ElementA / ElementB: конкретные элементы, которые реализуют метод Accept()

ObjectStructure: некоторая структура, которая хранит объекты Element и предоставляет к ним доступ.
Это могут быть и простые списки, и сложные составные структуры в виде деревьев
*/
