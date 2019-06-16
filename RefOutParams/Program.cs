
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Passing value using ref keyword");
            int studentGradeRef = 75;
            Console.WriteLine("The student grade is {0}", studentGradeRef);
            GiveExtraCreditRef(ref studentGradeRef);
            Console.WriteLine("The student grade after extracredit is {0}", studentGradeRef);

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Passing value using out keyword");

            int studentGradeOut;
            GiveExtraCreditOut(out studentGradeOut);
            Console.WriteLine("The student grade after extracredit is {0}", studentGradeOut);

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Passing value using params keyword");

            int[] myArray = { 5, 6, 7, 8, 9, 10 };
            PrintArray(myArray);
            PrintArray(5, 6, 7, 8, 9);

            Console.ReadLine();
        }

        public static void GiveExtraCreditRef( ref int studentGradeRef)
        {
            studentGradeRef += 3;
        }

        public static void GiveExtraCreditOut( out int studentGradeOut)
        {
            studentGradeOut = 80;
            studentGradeOut += 3;
        }

        public static void PrintArray(params int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
