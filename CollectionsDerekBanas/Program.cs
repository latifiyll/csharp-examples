using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDerekBanas
{
    class Program
    {
        static void Main(string[] args)
        {

            #region List Code
            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //remove odd numbers
            for (var index = numbers.Count - 1;index>=0; index--)
            {
                if (numbers[index] % 2 == 1)
                {
                    numbers.RemoveAt(index);
                }
            }

            numbers.ForEach(number => Console.Write(number + " "));


            #endregion
            Console.WriteLine();
            Console.WriteLine();

            #region ArrayList Code

            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);
           
            Console.WriteLine($"Count : {aList.Count}");
            Console.WriteLine($"Capacity : {aList.Capacity}");

            ArrayList alist2 = new ArrayList();
            alist2.AddRange(new object[] { "Mike", "Sally", "Egg" });

            aList.AddRange(alist2); // gets all elements of alist2 together with alist
            alist2.Sort();
            aList.Reverse();
            alist2.Insert(1, "Turkey");

            ArrayList range = alist2.GetRange(0,2);  //start from 0, get 2 items

            foreach (object o in range)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();

            string[] myArray = (string[])alist2.ToArray(typeof(string));

            foreach (object array in myArray)
            {
                Console.WriteLine(array);
            }

            Console.WriteLine();

            string[] customers = { "Bob", "Sally", "Sue" };

            ArrayList custArrayList = new ArrayList();
            custArrayList.AddRange(customers);

            foreach (string cust in custArrayList)
            {
                Console.WriteLine(cust);
            }

            #endregion

            Console.WriteLine();
            Console.WriteLine();

            #region Dictionaries Code

            var superheroes = new Dictionary<string, string>();
            superheroes.Add("Clark Kent", "Superman");
            superheroes.Add("Bruce Wayne", "Batman");
            superheroes.Add("Barry West", "Flash");

            superheroes.Remove("Barry West");

            Console.WriteLine("Count: {0}",superheroes.Count); // it will count all the elements inside dictionary
            Console.WriteLine("Clark Kent: {0}",superheroes.ContainsKey("Clark Kent")); // searches for the specific key given: returns bool

            superheroes.TryGetValue("Clark Kent", out string test); //geting a value and store it as a string using "out"

            Console.WriteLine($"Clark Kent: {test}");

            

            foreach (KeyValuePair<string,string> item in superheroes)
            {
                
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            foreach (var item in superheroes)
            {
                if (item.Key == "Clark Kent")
                {
                    Console.WriteLine("Found: " + item.Value);
                }
            }

            superheroes.Clear();
            // after Clear();
            foreach (KeyValuePair<string,string> item in superheroes)
            {
                Console.WriteLine(item);
            }

            #endregion

            Console.WriteLine();
            Console.WriteLine();

            #region Queue Code 

            Queue queue = new Queue(); //queue uses FIFO firt in firt out
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine("Is 1 in the queue? {0}",queue.Contains(1));
            Console.WriteLine("Remove 1 from the queue : {0}",queue.Dequeue());
            Console.WriteLine("Peek from queue: {0}",queue.Peek());

            object[] numArray = queue.ToArray();

            Console.WriteLine(string.Join(", ",numArray));

            foreach (object o in queue)
            {
                Console.WriteLine($"Queue: {o}");
            }
            #endregion
            Console.WriteLine();
            Console.WriteLine();

            #region Stack Code
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine($"Peek 1: {stack.Peek()}");
            Console.WriteLine($"Contains 1 : {stack.Contains(1)}");

            foreach (object o in stack)
            {
                Console.WriteLine($"Stack: {o}");
            }
            
            #endregion


           
            Console.ReadLine();
            
        }
    }
}
