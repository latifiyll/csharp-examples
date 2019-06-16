using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymusMethods
{
    delegate void Printer(string s);
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Delegate calls");
            //instantiate the delegate type using anonymous method
            Printer p = delegate (string j)
            {
                Console.WriteLine(j);
            };

            //results from anonymous delegate  call
            p("The delegate using anonumous method");


            //the delegate instantiation using a named method DoWork
            p = DoWork;
            //results from the old style delegate call
            p("Using names method");

            Console.ReadLine();
        }

        static void DoWork(string k)
        {
            Console.WriteLine(k);
        }
    }
}
