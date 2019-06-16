using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public bool enrolled { get; set; }

        public void Details()
        {

        }

        public void Details(string name,int age, bool enrolled)
        {
            Console.WriteLine("Name: {0},Age: {1},Enrolled: {2} ", name, age, enrolled);
        }
        public void Details(string name, int age)
        {
            Console.WriteLine("Name: {0},Age: {1} ", name, age);

        }
        public void Details(string name)
        {
            Console.WriteLine("Name: {0} ", name);

        }

        
    }
}
