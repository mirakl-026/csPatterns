using System.Text;
using System.Collections.Generic;

using Creation.FactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        Builder tom = new WoodBuilder("Tom");
        tom.Create();
    }
}

