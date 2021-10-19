using System;

namespace MaxInARowButMinInCol
{
    class Program
    {
        /*
         * In this program we have a matrix we want to detect numbers that are the maximum value in that row
         * but the minimum value in that column
         */
        static void Main(string[] args)
        {
            int[,] myMatrix = new int[,] { { 2, 6, 4, 15 }, { 345, 5, 12, 117 }, { 55, 4, 4, 120 }, { 2, 9, 6, 5 }, { 56, 6, 9, 140 } };
            getMaxInRowButMinInCol(myMatrix);
            Console.WriteLine("We have finished. Press any key to exit");


        }

        static void getMaxInRowButMinInCol(int[,] myMatrix)
        {
            int rowCounter;
            int colCounter;

            /* 
             * Code Tip: myMatrix.GetLength(0) <--- This will return the number of  rows
               myMatrix.GetLength(1) <--- This will return the number of columns
             
             */

            for(rowCounter = 0; rowCounter < myMatrix.GetLength(0);rowCounter++)
            {
                Console.WriteLine("we are analyzing the row number: {0}", rowCounter);
                for(colCounter = 0; colCounter < myMatrix.GetLength(1); rowCounter++)
                {
                    Console.WriteLine("In the row: {0} and the column {1} we have the number {2}", rowCounter, colCounter, myMatrix[rowCounter, colCounter]);
                    /* start from here */
                
                }
            }
        }
    }
}
