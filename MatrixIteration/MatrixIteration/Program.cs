using System;

namespace MatrixIteration
{
    class Program
    {

        /*
         * The challenge is to write a code that will print all the numbers we have in a matrix.
         * 
         * Example: [  [1,2,3], [4,5,6], [7,8,0] ] 
         *  
         *  At row 0 and col 0 we have 1
            At row 0 and col 1 we have 2
            At row 0 and col 1 we have 3
            At row 1 and col 0 we have 4
            At row 1 and col 1 we have 5
         */
        static void Main(string[] args)
        {
            int[,] myMatrix = new int[,] { { 1, 2,3}, { 4,5,6 }, {7,8,9 }, {10,11,12 } };
            matrixIteration(myMatrix);

            Console.WriteLine("We have finished. Press any key to continue");
            Console.ReadKey();
        }

        static void matrixIteration(int [,] myMatrix)
        {
            int rowCounter = 0;
            int colCounter = 0;

            /*
             * Hint: Start from here. Use a for loop for the ROWS and ANOTHER for loop for the COLS 
             * (A for inside a for)
             * 
             * Code Snippet:  myMatrix.GetLength(0) <--- This returns the number of rows
                              myMatrix.GetLength(1) <--- This returns the number of cols
             */

            Console.WriteLine("At row {0} and col {1} we have the number: {2} ", rowCounter, colCounter, myMatrix[rowCounter, colCounter]);


            /* 
            Oficial documentation https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays
            */
        }
    }
}
