using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        private string name;
        private int age;
        private float happiness;

        //method
        public void PrintBase()
        {
            Console.WriteLine("Name: " + name); // static class called
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Happiness: " + happiness);
        }

        
        public string Name //proporties //public(access modifier) string (primitive type) Name(variable)
        {
            get
            {
                return name;
            }
            set
            {
                if(value != "")
                {
                    name = value;
                }
                
            }
        }
        public int Age //proporties
        {
            get
            {
                return age;
            }
            set
            {
                if(value != 0)
                {
                    age = value;
                }
                
            }
        }

        
        public float Happiness //proporties
        {
            get
            {
                return happiness;
            }
            set
            {
                happiness = value;  
            }
        }
        public static void SayHello()
        {
            Console.WriteLine("Static line");
        }
 
    }



    class Dog : Animal  //inherited class
    {
        

        public Dog(string name, int age, float happiness) //constructor
        {
            this.Name = name;
            this.Age = age;
            this.Happiness = happiness;

        }

        public void Bark() //method
        {
            Console.WriteLine("Wuf!!");
            base.Happiness += 0.4f;
        }
    }
    class Cat : Animal //inherited class
    {
        public Cat(string name, int age, float happiness)
        {
            this.Name = name;
            this.Age = age;
            this.Happiness = happiness;
        }
        

        public void Meow()
        {
            Console.WriteLine("MEOW!!");
            base.Happiness += 0.1f;
        }
    }
}
