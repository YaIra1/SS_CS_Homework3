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
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            Task10();
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

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            var average1 = (double)sum / numbers.Count;
            Console.WriteLine($"Average number using for loop: {average1}");
        }

        /// <summary>
        /// Check if the entered year is a leap.
        /// </summary>
        public static void Task5()
        {
            Console.Write("Enter the year: ");
            int year;
            var inputYear = Console.ReadLine();
            var parsed = int.TryParse(inputYear, out year);

            if (!parsed)
            {
                Console.WriteLine("Can't parse the year, enter valid year.");
                return;
            }
            Console.WriteLine($"{year} year is leap: {DateTime.IsLeapYear(year)} ");
        }

        /// <summary>
        /// Find the sum of digits of the entered integer number //(365 -> 3+6+5)
        /// </summary>
        public static void Task6()
        {
            int number = 46587;
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine($"The sum of digits is {sum}.");
        }


        /// <summary>
        /// Check if the entered integer number contains only odd digits. 
        /// </summary>
        public static void Task7()
        {
            int number = 46587;
            bool areAllOdd = true;

            while (number != 0)
            {
                if ((number % 10) % 2 == 0)
                {
                    areAllOdd = false;
                    break;
                }

                number /= 10;
            }

            Console.WriteLine($"All digits of the number are odd: {areAllOdd}");
        }


        /// <summary>
        /// Read some string str.
        /// Calculate the counts of characters ‘a’, ’o’, ’i’, ’e’  in this text.
        /// </summary>
        public static void Task8()
        {
            string str = "Hello string";
            int countA = 0;
            int countO = 0;
            int countI = 0;
            int countE = 0;

            foreach (char symbol in str)
            {
                switch (symbol)
                {
                    case 'a':
                        countA++;
                        break;
                    case 'o':
                        countO++;
                        break;
                    case 'i':
                        countI++;
                        break;
                    case 'e':
                        countE++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Count a: {countA}, count o: {countO}, count i: {countI}, count e: {countE}");
        }

        /// <summary>
        /// Ask user to enter the number of month. 
        /// Read value and output the count of days in this month.
        /// </summary>
        public static void Task9()
        {
            Console.WriteLine("Enter the number of the month: ");
            int month;
            var inputMonth = Console.ReadLine();
            var parsed = int.TryParse(inputMonth, out month);

            if (!parsed)
            {
                Console.WriteLine("Can't parse the month number.");
                return;
            }
            if (month < 1 || month > 12)
            {
                Console.WriteLine("You have entered invalid month number");
                return;
            }

            Console.WriteLine($"{month} month has {DateTime.DaysInMonth(2023, month)} days");
        }

        /// <summary>
        /// Enter 10 integer numbers. 
        /// Calculate the sum of first 5 elements if they are positive
        /// or product of last 5 element in  the other case.
        /// </summary>
        public static void Task10()
        {
            int[] array = new int[10] { 5, 8, 2, 9, 67, 65, 8, 1, 55, 3 };
            //int[] array = new int[10] { 5, -8, 2, 9, 67, 65, 8, 1, 55, 3 };

            int sum = 0;
            bool allPositive = true;

            for (int i = 0; i < 5; i++)
            {
                if (array[i] < 0)
                {
                    allPositive = false;
                    break;
                }
                sum += array[i];
            }
            if (allPositive)
            {
                Console.WriteLine($"The sum of first 5 elements is: {sum}");
            }
            else
            {
                double product = 1;
                for (int i = 5; i < 10; i++)
                {
                    product *= array[i];
                }
                Console.WriteLine($"The product of last 5 elements is: {product}");
            }
        }
    }
}