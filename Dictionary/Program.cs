using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
             // Create a new Dictionary of strings
            Dictionary<string, string> openWith = new Dictionary<string, string>();

            //Add some elements to the dictionary
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bpm", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            //add method throws an exception if the new key is already in the dictionary
            try
            {
                openWith.Add("dib", "winword.exe");
               
            }
            catch (ArgumentException)
            {

                Console.WriteLine($"an element with this key already exists ");
            }
            Console.WriteLine("--------------------");

            //get the value by using the key
            Console.WriteLine("for key = txt the value is {0}",openWith["txt"]);

            Console.WriteLine("--------------------");


            //change the value of particular key
            Console.WriteLine("the old value is {0}",openWith["bpm"]);
            openWith["bpm"] = "winword.exe";
            Console.WriteLine("the new value is {0}",openWith["bpm"]);

            Console.WriteLine("------------------");

            //if that key does not exist, it will create a new key/value pair
            try
            {
                
                if (!openWith.ContainsKey("zyx"))
                {
                    
                    openWith["zyx"] = "winword.exe";
                    Console.WriteLine("new key/value pair added");
                }
                else
                {
                    Console.WriteLine("the value updated");
                }
                
                
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Something went wrong");
            }

            Console.WriteLine("------------------");

            //foreach in key value pair

            foreach (KeyValuePair<string,string> kvp in openWith)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
            Console.WriteLine("------------------");

            //get the values alone
            Dictionary<string, string>.ValueCollection valColl = openWith.Values;

            foreach (var s in valColl)
            {
                Console.WriteLine($"Value = {s}");
            }

            Console.WriteLine("------------------");

            //get the keys alone
            Dictionary<string, string>.KeyCollection keyColl = openWith.Keys;

            foreach (var key in keyColl)
            {
                Console.WriteLine($"Key = {key}");
            }

            Console.WriteLine("------------------");

            //remove a key/value pair

            openWith.Remove("bpm");
            if (!openWith.ContainsKey("bpm"))
            {
                Console.WriteLine("The key does not exist");
            }
            Console.ReadLine();
        }
    }
}
