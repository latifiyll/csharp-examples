using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        public class A
        {
            //protected are only visible in derived classes
            //internal are visible in derived classes that are located in the same assembly
            //public is public everywhere

            //private can be used only from derived class that are nested in their base class
            private int value = 10;
            protected int valueC = 20;

            public class B : A
            {
                public int GetValue()
                {
                    return this.value;
                }
            }

        }

        public class C : A
        {
            public int getValue()
            {
                return this.valueC;
            }
        }

        public class D : C { }


        static void Main(string[] args)
        {
            var b = new A.B(); // is called like this becase class B is nested class in base class A
            var c = new C();
            var d = new D();


            Console.WriteLine(b.GetValue());
            Console.WriteLine(c.getValue());
            Console.WriteLine(d.getValue());

            Console.ReadLine();

            

            

            

            
        }
    }
}
