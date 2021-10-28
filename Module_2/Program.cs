using System;
using System.Linq;
using System.Text.RegularExpressions;
using Assembly_2;
using static System.String;

namespace Assembly
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var car = new Car()
            {
                color = "red",
                model = CarConstants.bmw
            };

            CarConstants.bmw = "bmw 5";
            
            Console.WriteLine(car.color);

            Console.WriteLine(car.model);

            Console.ReadLine();
        }

        #region Functionality

        private static void FindArrayMaxNumber()
        {
            int[] arr = { 1, 2, 3, 1, 2, 51, 4, 1000 };

            int maxVal = 0;
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= maxVal)
                {
                    maxVal = arr[i];
                    index = i;
                }
            }

            Console.WriteLine($"The maximum number is {maxVal} at index {index}");
        }

        private static void FindArrayDuplicateElementCount()
        {
            int[] arr = { 1, 2, 3, 1, 2, 5, 4, 3, 3 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine($"Duplicate number is: {arr[i]}");
                    }
                }
            }
        }

        private static void AssigneeArrayValues()
        {
            var arr = new int[10];

            for (var i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Please input value with index {i}");

                if (int.TryParse(Console.ReadLine(), out var input))
                {
                    arr[i] = input;
                }
                else
                {
                    Console.WriteLine("Incorrect input!");
                }

            }
        }

        int GetNumber() => 1;

        #endregion
    }
}
