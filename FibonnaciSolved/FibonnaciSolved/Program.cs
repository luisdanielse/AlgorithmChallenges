using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonnaciSolved
{
    class Program
    {
        static void Main(string[] args)
        {

            int number;
            Console.Write("Provide me the number you would like to calculate Fibonnaci: ");
            number = Convert.ToInt32(Console.ReadLine());
            int result = CalcFibonnaci(number);

            Console.WriteLine("The Fibonnaci number for {0} is {1}", number, result);

            Console.WriteLine("The program has  finished. Press any key to exit");
            Console.ReadKey();
        }

        static int CalcFibonnaci(int number)
        {
            int temp0 = 0;
            int temp1 = 1;
            int result = 0;
            for (int i = 0; i < number; i++)
            {
                temp0 = result;
                result = temp1;
                temp1 = temp0 + result;
            }
            return result;

        }

    }
}
