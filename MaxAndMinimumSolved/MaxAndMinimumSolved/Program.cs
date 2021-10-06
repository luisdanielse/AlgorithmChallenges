using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxAndMinimumSolved
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = new int[] { 4, 5, 6, 7, 3, 4, 7, 8, 1, 9 };
            FindMaximum(myarray);
            FindMinimum(myarray);

            Console.WriteLine("We have finished. Press any key to exit.");
            Console.ReadKey();
        }

        static void FindMaximum(int[] tempArray)
        {
            int index;
            int currentMaxValue;
            int tempValue;
            /* Hint: continue (or start) here */
            // Lets asume the maximum is at first position 
            index = 0;
            currentMaxValue = tempArray[index];

            for (int i = 1; i < tempArray.Length; i++)
            {
                tempValue = tempArray[i];
                if (tempValue > currentMaxValue)
                {
                    // If we found a new max value, we update the value and the index
                    index = i;
                    currentMaxValue = tempValue;

                }
            }


            Console.WriteLine("The maximum value is {0} and you can find it at position {1}", currentMaxValue, index);
        }

        static void FindMinimum(int[] tempArray)
        {
            /* Hint: continue (or start) here */
            int index;
            int currentMinValue;
            int tempValue;
            /* Hint: continue (or start) here */
            // Lets asume the minimum is at first position 
            index = 0;
            currentMinValue = tempArray[index];

            for (int i = 1; i < tempArray.Length; i++)
            {
                tempValue = tempArray[i];
                if (tempValue < currentMinValue)
                {
                    // If we found a new min value, we update the value and the index
                    index = i;
                    currentMinValue = tempValue;

                }
            }

            Console.WriteLine("The minimum value is {0} and you can find it at position {1}", currentMinValue, index);
        }
    }
}
