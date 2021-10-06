using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialSolved
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Provide me the number you would like to calculate the factorial: ");
            number = Convert.ToInt32(Console.ReadLine());

            //int result = calcFactorialFromBottomToTop(number);
            //int result = calcFactorialFromTopToBottom(number);
            int result = recursiveFactorial(number);
            Console.WriteLine("The factorial of the number {0} is {1}", number, result);

            Console.WriteLine("The program has  finished. Press any key to exit");
            Console.ReadKey();

        }

        /* From bottom to top */
        static int calcFactorialFromBottomToTop(int number)
        {

            int result = 1;
            int counter = 1;
            /* Hint: start here and return the result */

            while (counter <= number)
            {
                result = result * counter;
                counter++;
            }
            return result;

        }

        static int calcFactorialFromTopToBottom(int number)
        {

            int result = 1;
            int counter = number;
            /* Hint: start here and return the result */

            while (counter > 0)
            {
                result = result * counter;
                counter--;
            }
            return result;

        }
    
    
        static int recursiveFactorial(int number)
        {
            if(number == 0)
            {
                return 1;
            }
            else
            {
                return number * recursiveFactorial(number - 1);
            }
        }
    }
}
