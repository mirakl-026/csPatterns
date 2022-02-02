using System.Text;
using System.Collections.Generic;

using Creation.FactoryMethod;
using Creation.AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        //Builder tom = new WoodBuilder("Tom");
        //tom.Create();

        Hero elf = new Hero(new ElfFactory());
        elf.Hit();
        elf.Run();

        Hero orc = new Hero(new WarriorFactory());
        orc.Hit();
        orc.Run();

        Console.ReadLine();
    }
}

