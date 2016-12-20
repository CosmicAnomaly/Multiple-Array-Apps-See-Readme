using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Assignments_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scott Robinson
            //Arrays Assignment 1-1

            //int[] myArray = new int[10];

            //for (int count = 0; count < myArray.Length; count++)
            //{
            //    Console.Write("Please input a number: ");
            //    int myCount = Convert.ToInt32(Console.ReadLine());

            //    myArray[count] = myCount; //possibly skip a step and convert into the array?
            //}
            //for (int oppositeCount = 9; oppositeCount >= 0; oppositeCount--)
            //{
            //    Console.WriteLine(myArray[oppositeCount]);
            //}

            ////Assignment 1-2

            //int[] averageArray = new int[5];
            //int sum = 0;
            //int average = 0;

            //for (int count = 0; count < averageArray.Length; count++)
            //{
            //    Console.Write("Please input a number: ");
            //    int inputValue = Convert.ToInt32(Console.ReadLine());

            //    averageArray[count] = inputValue;
            //    sum = averageArray[count] + sum;

            //    average = sum / averageArray.Length;
            //}
            //Console.WriteLine("The average of the numbers entered is: " + average);
            //Console.WriteLine();
            //Console.WriteLine("The following numbers are greater than the average: ");

            //for (int largerthanAverage = 0; largerthanAverage < averageArray.Length; largerthanAverage++)
            //{
            //    if (averageArray[largerthanAverage] > average)
            //    {
            //        Console.WriteLine(averageArray[largerthanAverage]);
            //    }
            //}

            //Assignment 1-3

            int[] listArray = new int[10];

            for (int count = 0; count < listArray.Length; count++)
            {
                Console.Write("Please input a number: ");
                int inputValue = Convert.ToInt32(Console.ReadLine());
                listArray[count] = inputValue;

            }

            Console.Write("Please enter the Target value: ");
            int targetValue = Convert.ToInt32(Console.ReadLine());

            int countValue = 0;

            for (int targetCheck = 0; targetCheck < listArray.Length; targetCheck++)
            {
                //Console.WriteLine(listArray[targetCheck]);
                if (listArray[targetCheck] == targetValue)
                {
                    countValue++;
                    //Console.WriteLine("test");
                }
            }

            Console.Write("The Target value of " + targetValue + " appeared " + countValue + " times.");

            Console.ReadKey();

        }
    }
}
