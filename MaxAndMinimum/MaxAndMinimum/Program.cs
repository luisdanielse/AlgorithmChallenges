using System;

namespace MaxAndMinimum
{
    class Program
    {
        /* We want to create a program that will find the maximum and minimum value in a given vector */
        static void Main(string[] args)
        {
           int[] myarray = new int[]{ 4,5,6,7,3,4,7,8,1,9};
           FindMaximum(myarray);
           FindMinimum(myarray);

           Console.WriteLine("We have finished. Press any key to exit.");
           Console.ReadKey();
        }

        static void FindMaximum(int[] tempArray)
        {
            /* Hint: continue (or start) here */
            // for 
            Console.WriteLine("The maximum value {0} is and you can find it at position {1}", 1, 2);
        }

        static void FindMinimum(int[] tempArray)
        {
            /* Hint: continue (or start) here */
            // for 
            Console.WriteLine("The minimum value {0} is and you can find it at position {1}", 1, 2);
        }


    }
}
