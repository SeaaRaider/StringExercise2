using System;
using System.Collections.Generic;

namespace StringExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter series of numbers separated by - ");
            var input = Console.ReadLine();
            var numbers = new List<int>();

            if (String.IsNullOrWhiteSpace(input))
                return;

            foreach (var number in input.Split("-"))
            {
                numbers.Add(Convert.ToInt32(number));
            }

            var uniques = new List<int>();
            var isDuplicate = false;

            foreach(var number in numbers)
            {
                if(!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
                else
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (isDuplicate == true)
                Console.WriteLine("Duplicate");

                System.Console.WriteLine("ESSA2");
        }
    }
}
