using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            TaxPayer[] payers = new TaxPayer[1];

            for(int i=0;i<payers.Length; i++)
            {
                payers[i] = new TaxPayer();
                payers[i].Details(i);

            }

            for(int j = 0; j < payers.Length; j++)
            {
                payers[j].Display();
            }

            Console.ReadLine();
        }
    }
}
