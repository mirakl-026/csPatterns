using System.Text;
using System.Collections.Generic;

using Creation.FactoryMethod;
using Creation.AbstractFactory;
using Creation.Singleton;
using Creation.Prototype;

class Program
{
    static void Main(string[] args)
    {
        #region FactoryMethod
        // FactoryMethod
        //Builder tom = new WoodBuilder("Tom");
        //tom.Create();
        #endregion

        #region AbstractFactory
        //Hero elf = new Hero(new ElfFactory());
        //elf.Hit();
        //elf.Run();

        //Hero orc = new Hero(new WarriorFactory());
        //orc.Hit();
        //orc.Run();

        //Console.ReadLine();
        #endregion

        #region Singleton

        //Gateway gateway = Gateway.getInstance("North gates");
        //Console.WriteLine(gateway.Name);

        //Gateway gateway1 = Gateway.getInstance("South gates");
        //Console.WriteLine(gateway1.Name);   // same
        #endregion

        #region Prototype

        IFigure figure = new Rectangle(30, 40);
        IFigure clonedFigure = figure.Clone();
        figure.GetInfo();
        clonedFigure.GetInfo();

        figure = new Circle(30);
        clonedFigure = figure.Clone();
        figure.GetInfo();
        clonedFigure.GetInfo();


        #endregion
    }
}



