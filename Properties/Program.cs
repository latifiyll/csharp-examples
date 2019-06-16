using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Tom", 18, 65);
            s1.Name = "Bob";

            Console.WriteLine(s1.Name);
            s1.FinalGrade=100;
            Console.WriteLine(s1.FinalGrade);

            Student s2 = new Student("Brus", 15, 65);
            Console.WriteLine(s2.Name);




            Console.ReadLine();
        }
    }
}
