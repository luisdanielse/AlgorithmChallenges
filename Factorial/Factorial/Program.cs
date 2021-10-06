using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Provide me the number you would like to calculate the factorial: ");
            number = Convert.ToInt32(Console.ReadLine());

            int result = calcFactorial(number);
            Console.WriteLine("The factorial of the number {0} is {1}", number, result);

        }

        static int calcFactorial(int number)
        {

            int result = 1;
            /* Hint: start here and return the result */
            
            return result;

        }
    }
}
