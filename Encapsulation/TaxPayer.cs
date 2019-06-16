using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class TaxPayer
    {
        public int socialSecurity { get; set; }
        public double taxOwed { get; set; }

        public double MyProperty { get; set; }

        private double CalculateTax()
        {
            if (MyProperty <= 0)
            {
                return 0;
            }
            if (MyProperty < 15000)
            {
                taxOwed = MyProperty * .15;
            }
            else if (MyProperty > 15000 && MyProperty < 25000)
            {
                taxOwed = MyProperty * .20;
            }
            else if (MyProperty > 25000 && MyProperty < 35000)
            {
                taxOwed = MyProperty * .25;
            }
            else
            {
                taxOwed = MyProperty * .30;
            }

            return taxOwed;
        }


        //entering details
        public void Details( int i = 0)
        {

            Console.WriteLine("Enter payer #{0} SSN:", i+1);
            socialSecurity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter payer #{0} Yearly income: ",i+1 );
            MyProperty = double.Parse(Console.ReadLine());

        }

       
       

        //printing
        public void Display()
        {
            var calculatedTax = CalculateTax();
            Console.WriteLine("The tax payer with SSN {0},With yearly income of {1}, has to pay tax of {2}", socialSecurity,MyProperty , calculatedTax);


        }
    }
}
