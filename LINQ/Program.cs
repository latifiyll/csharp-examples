using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
          IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
        };
           
            //using Lambda
            var filteredLambdaResults = studentList.Where(s => s.Age > 12 && s.Age < 20);

            foreach (Student std in filteredLambdaResults)
            {
                Console.WriteLine(std.StudentName);
            }


            //using LINQ
            var filteredLINQResults = from std in studentList
                                      where std.Age > 12 && std.Age < 20
                                      select std;

            foreach ( Student std in filteredLINQResults)
            {
                Console.WriteLine(std.StudentName);
            }

            //another lambda
            var results = studentList.Where((s, i) =>
            {
                if (i % 2 == 0)
                    return true;

                return false;

                
            });
            foreach(var std in results)
            {
                Console.WriteLine(std.StudentName);
            }
            //OfType
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

            var stringresults = from s in mixedList.OfType<string>()
                                select s;

            var intResults = from s in mixedList.OfType<int>()
                             select s;
            var stdResults = from s in mixedList.OfType<Student>()
                             select s;


            foreach (var stringres in stringresults)
            {
                Console.WriteLine(stringres);
            }

            foreach (var intres in intResults)
            {
                Console.WriteLine(intres);
            }
            foreach (var stdres in stdResults)
            {
                Console.WriteLine(stdres.StudentName);
            }

            Console.ReadLine();
        }
    }
}
