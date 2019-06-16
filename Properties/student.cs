using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Student
    {
        private string name;
        private int age;
        private double finalGrade;

        //Auto-implemented proporties, no private data for this
        public string LastName { get; set; }

        public Student(string name, int age, double finalGrade)
        {
            this.name = name;
            this.age = age;
            this.finalGrade = finalGrade;
        }
        public Student(string name, int age) : this(name, age, 0)
        {

        }

        public void SayHello()
        {
            Console.WriteLine("Hello from {0}", name);
        }
        // getters and setters
        public string Name
        {
            get
            {
               if (age >= 18)
                {
                    return name;
                }
                else
                 {
                    return "this student is too young";
                 }
            }
            set
            {
                if (value != "")
                {
                    name = value;
                }
            }
        }

       public int Age
        {
            get
            {
                if (age >= 18)
                {
                    return age;
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                if (value != 0)
                {
                    age = value;
                }
            }
        }

        public double FinalGrade
        {
            get
            {
                return finalGrade;
            }
            set
            {
                if (value < 65)
                {
                    value = 65;
                }
                else if (value > 100)
                {
                    value = 100;
                }
                finalGrade = value;
            }
        }
       
       
    }
}
