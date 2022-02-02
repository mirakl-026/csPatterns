using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation
{
    namespace Singleton
    {
        class Gateway
        {
            private static Gateway instance;
            public string Name { get; private set; }

            private Gateway(string name)
            { 
                this.Name = name;
            }

            public static Gateway getInstance(string name)
            {
                if (instance == null)
                    instance = new Gateway(name);
                return instance;
            }
        }
    }
}

/*
Одиночка (Singleton, Синглтон) - порождающий паттерн, который гарантирует, что для определенного класса будет создан только один объект,
а также предоставит к этому объекту точку доступа.

Синглтон позволяет создать объект только при его необходимости. Если объект не нужен, то он не будет создан. 
В этом отличие синглтона от глобальных переменных.


    class Singleton
    {
        private static Singleton instance;
 
        private Singleton()
        {}
 
        public static Singleton getInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }

*/
