using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppYear3.Basics
{
    public class Arrays
    {
        public static void ImplicitlyTypedArray()
        {
            var people = new[] { "Ramesh", "John", "Harry", "Simon" };

            people[2] = "Patrick";

            Console.WriteLine($"List of People are: {people[2]}");
        }

        public static void JaggedArray()
        {
            int[][] jagged_arr = new int[][]
            {
                new int[] { 1, 2, 3, 4 },
                new int[] { 11, 34, 67 },
                new int[] { 95, 40 },
                new int[] { 0, 1, 2, 3, 4 }
            };

            jagged_arr[1][2] = 99;

            Console.WriteLine("jagged Array [1][2]: "+ jagged_arr[1][2]);


        }

        public static void MultiDimensionalArray()
        {
            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };
            
            Console.WriteLine("Old element at [0,0] index: " + numbers[0,0]);

            numbers[0, 0] = 404;

            Console.WriteLine("New element at [0,0] index: "+ numbers[0,0]);
        }

        public static void SingleDimensionalArray()
        {
            int[] array1 = { 1, 3, 5, 7, 9 };
            string[] weekdays = { 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday' };

            array1[1] = 2;

            Console.WriteLine(array1[1]);
            Console.WriteLine(weekdays[3]);
        }
    }
}
