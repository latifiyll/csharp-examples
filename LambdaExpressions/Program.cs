using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //c# simple lambda ex
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));


            Console.WriteLine();

            //lambda to expression tree
            System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
            Console.WriteLine(e);

            Console.WriteLine();

            //as method argument
            int[] numbers = { 2, 3, 4, 5, 6 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(",",squaredNumbers));


            Console.WriteLine();

            //statement lambdas
            Action<string> greet = name =>
            {
                string greeting = $"Hello {name}!";
                Console.WriteLine(greeting);
            };
            greet("World");

            Console.WriteLine();

            //lambda and tuples

            //Func<(int, int, int), (int, int, int)> doubleThem = ns => (2 * ns.Item1, 2 * ns.Item2, 2 * ns.Item3);
            //var numberss = (2, 3, 4);
            //var doubledNumbers = doubleThem(numberss);
            //Console.WriteLine(value: $"The set {numbers} doubled: {doubledNumbers}");

            Console.WriteLine();

            //count query operation
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var oddNumbers = num.Count(x => x % 2 == 1);
            Console.WriteLine($"there are {oddNumbers} odd numbers in {string.Join(",",num)}");

            Console.WriteLine();

            //takeWhile in lambda
            int[] numm = { 5, 4, 1, 3, 9, 7, 8, 5, 6 };
            var firsNumbersLessThanSix = numm.TakeWhile(n => n < 6);
            Console.WriteLine(string.Join(",",firsNumbersLessThanSix));
            //output: 5,4,1,3 because after comes 9, 9 is biggerthan 6, breaks.

            Console.WriteLine();

            int[] numero = { 5, 4, 1, 3, 9, 8, 6, 8, 7 };
            var firsSmallNumbers = numero.TakeWhile((n, index) => n >= index);
            Console.WriteLine(string.Join(",",firsSmallNumbers));


            Console.WriteLine();

            int[] scores = { 90, 85, 75, 82, 79, 65 };

            var higherScoreCount = scores.Where(n => n > 80).Count(); //scores.Count(n=>n>80); gives the same result
            
            Console.WriteLine($"{higherScoreCount} scores are greater than 80");

            Console.ReadLine();
        }
    }
}
