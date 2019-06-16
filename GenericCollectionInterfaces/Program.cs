using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle buick = new Vehicle("Buick", 4, 160);
            

            if (buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }else
            {
                Console.WriteLine($"the {buick.Brand} can't be driven");
            }

            IElectronicDevice TV = 
                TVRemote.GetDevice();
                PowerButton powButt = new PowerButton(TV);

            powButt.Execute();
            powButt.Undo();


            Console.ReadLine();
        }
    }
}
