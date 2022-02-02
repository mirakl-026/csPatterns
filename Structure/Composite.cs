using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    namespace Composite
    {
    }
}
/*
Паттерн Компоновщик (Composite) объединяет группы объектов в древовидную структуру по принципу
"часть-целое и позволяет клиенту одинаково работать как с отдельными объектами, так и с группой объектов.

Образно реализацию паттерна можно представить в виде меню, которое имеет различные пункты.
Эти пункты могут содержать подменю, в которых, в свою очередь, также имеются пункты.
То есть пункт меню служит с одной стороны частью меню, а с другой стороны еще одним меню. 
В итоге мы однообразно можем работать как с пунктом меню, так и со всем меню в целом.


    class Client
    {
        public void Main()
        {
            Component root = new Composite("Root");
            Component leaf = new Leaf("Leaf");
            Composite subtree = new Composite("Subtree");
            root.Add(leaf);
            root.Add(subtree);
            root.Display();
        }
    }

    abstract class Component
    {
        protected string name;
 
        public Component(string name)
        {
            this.name = name;
        }
 
        public abstract void Display();
        public abstract void Add(Component c); 
        public abstract void Remove(Component c);
    }

    class Composite : Component
    {
        List<Component> children = new List<Component>();
 
        public Composite(string name)
            : base(name)
        {}
 
        public override void Add(Component component)
        {
            children.Add(component);
        }
 
        public override void Remove(Component component)
        {
            children.Remove(component);
        }
 
        public override void Display()
        {
            Console.WriteLine(name);
 
            foreach (Component component in children)
            {
                component.Display();
            }
        }
    }

    class Leaf : Component
    {
        public Leaf(string name)
            : base(name)
        {}
 
        public override void Display()
        {
            Console.WriteLine(name);
        }
 
        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }
 
        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }

Component: определяет интерфейс для всех компонентов в древовидной структуре

Composite: представляет компонент, который может содержать другие компоненты и 
реализует механизм для их добавления и удаления

Leaf: представляет отдельный компонент, который не может содержать другие компоненты

Client: клиент, который использует компоненты

*/
