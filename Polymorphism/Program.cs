using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            
            student.Details("Dave",15);
            student.Details("Fred", 16, true);
            student.Details("Adam");

            Console.ReadLine();
        }
    }
}
