using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExample
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter min and max values.  I will sum all numbers in between");
            Console.WriteLine("Enter a minimum number");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a maximum number");
            int max = int.Parse(Console.ReadLine());
            int sumMinMax = sumMinToMax(min, max);
            Console.WriteLine("Here is the sum:  " + sumMinMax);
        }


        static int sumMinToMax(int min, int max)
        {
            int sum = 0;
            for (int i = min; i <= max; i++)
            {
                sum = sum + i;
                Console.WriteLine("I am summing them up " + sum);

            }
            return sum;
        }
    }
}
