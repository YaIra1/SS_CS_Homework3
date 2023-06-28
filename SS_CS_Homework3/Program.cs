using System;
using System.Collections.Generic;
using System.Linq;

namespace SS_CS_Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            Task4();

        }

        /// <summary>
        /// Enter two integer numbers a and b.
        /// Calculate how many integers in the range [a..b] are divided by 3 without remainder. //1..10 -> 3
        /// </summary>
        public static void Task1()
        {
            int a = 1;
            int b = 0;
            int count = 0;
            var min = Math.Min(a, b);
            var max = Math.Max(a, b);

            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }

            }

            Console.WriteLine($"There are {count} integers divided by 3 without remainder");
        }

        /// <summary>
        /// Enter some string text from the console. Print each second character.
        /// </summary>
        public static void Task2()
        {
            Console.WriteLine("Enter some text: ");
            var text = Console.ReadLine();

            for (int i = 1; i < text.Length; i += 2)
            {
                Console.Write(text[i]);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Enter the name of the drink (coffee, tea, juice, water). 
        /// Print the name and price of the drink.
        /// </summary>
        public static void Task3()
        {
            Console.Write("Enter the drink name: ");
            var inputDrink = Console.ReadLine();

            var parsed = Enum.TryParse(inputDrink, out Drink drink);

            if (!parsed)
            {
                Console.WriteLine("There is no such drink.");
                return;
            }

            Console.WriteLine($"The drink {drink} costs {(int)drink} $");

        }

        /// <summary>
        /// Enter a sequence of positive integers (to the first negative).
        /// Calculate the arithmetic average of the entered positive numbers. //1,6,3,9,-8 -> (1+6+3+9)/4
        /// </summary>
        public static void Task4()
        {
            Console.WriteLine("Enter integers: ");

            var numbers = new List<int>();
            int number = 0;

            do
            {
                var input = Console.ReadLine();
                var parsed = int.TryParse(input, out number);

                if (!parsed)
                {
                    Console.WriteLine("Can't parse input, enter valid number");
                    continue;
                }

                if (number >= 0)
                {
                    numbers.Add(number);
                }

            } while (number >= 0);

            var average = numbers.Average();
            Console.WriteLine($"Average number is: {average}");

            double sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            var average1 = sum / numbers.Count;
            Console.WriteLine($"Average number using for loop: {average1}");
        }
    }
}