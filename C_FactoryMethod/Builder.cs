using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation
{
    namespace Builder
    {
        class Flour         // какого сорта мука
        {
            public string Sort { get; set; }
        }


        class Salt          // соль
        {
        
        }


        class Additives     // пищевые добавки
        {
            public string Name { get; set; }
        }

        class Bread
        {            
            public Flour Flour { get; set; }            // мука            
            public Salt Salt { get; set; }              // соль            
            public Additives Additives { get; set; }    // пищевые добавки

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                if (Flour != null)
                    sb.Append(Flour.Sort + "\n");
                if (Salt != null)
                    sb.Append("Соль \n");
                if (Additives != null)
                    sb.Append("Добавки: " + Additives.Name + " \n");
                return sb.ToString();
            }
        }


        // абстрактный класс строителя хлеба
        abstract class BreadBuilder
        {
            public Bread Bread { get; private set; }
            public void CreateBread()
            {
                Bread = new Bread();
            }
            public abstract void SetFlour();
            public abstract void SetSalt();
            public abstract void SetAdditives();
        }

        // строитель для ржаного хлеба
        class RyeBreadBuilder : BreadBuilder
        {
            public override void SetFlour()
            {
                this.Bread.Flour = new Flour { Sort = "Ржаная мука 1 сорт" };
            }

            public override void SetSalt()
            {
                this.Bread.Salt = new Salt();
            }

            public override void SetAdditives()
            {
                // не используется
            }
        }

        // строитель для пшеничного хлеба
        class WheatBreadBuilder : BreadBuilder
        {
            public override void SetFlour()
            {
                this.Bread.Flour = new Flour { Sort = "Пшеничная мука высший сорт" };
            }

            public override void SetSalt()
            {
                this.Bread.Salt = new Salt();
            }

            public override void SetAdditives()
            {
                this.Bread.Additives = new Additives { Name = "улучшитель хлебопекарный" };
            }
        }

        // пекарь
        class Baker
        {
            public Bread Bake(BreadBuilder breadBuilder)
            {
                breadBuilder.CreateBread();
                breadBuilder.SetFlour();
                breadBuilder.SetSalt();
                breadBuilder.SetAdditives();
                return breadBuilder.Bread;
            }
        }
    }
}

/*
Строитель (Builder) - шаблон проектирования, который инкапсулирует создание объекта и позволяет разделить его на различные этапы.

    class Client
    {
        void Main()
        {
            Builder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Construct();
            Product product = builder.GetResult();
        }
    }


    class Director
    {
        Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }
 

    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();

        public abstract Product GetResult();
    }
 
    class Product
    {
        List<object> parts = new List<object>();
        public void Add(string part)
        {
            parts.Add(part);
        }
    }
 
    class ConcreteBuilder : Builder
    {
        Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("Part A");
        }

        public override void BuildPartB()
        {
            product.Add("Part B");
        }

        public override void BuildPartC()
        {
            product.Add("Part C");
        }

        public override Product GetResult()
        {
            return product;
        }
    }

*/
