using System;
using System.Collections.Generic;
using System.Linq;

namespace SS_CS_Homework3
{
    class Program
    {
        // method definition ==> definition of instruction set
        //<access modificators> <return_type> <MethodName>([<parameter_type> <parameterName>,])
        //{
        //    <method body>
        //}

        // Method name pattern
        // Do something

        // calling the method
        //[<result_type> <resultName> =] <MethodName>([<variableName>,]);

        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Homework1();
            //Homework2();
            Homework3();
        }

        /// <summary>
        /// Enter two integer numbers a and b.
        /// Calculate how many integers in the range [a..b] are divided by 3 without remainder. //1..10 -> 3
        /// </summary>
        public static void Task1()
        {
            int a = 10;
            int b = 2;
            int count = 0;
            var min = Math.Min(a, b);
            var max = Math.Max(a, b);

            for (int i = min; i <= max; i++)
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
            var text = Helpers.Prompt("Enter some text: ");

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
            var inputDrink = Helpers.Prompt("Enter the drink name: ");

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

                if (!Helpers.ParseAndValidateInt(input, "Can't parse input, enter valid number", out number))
                {
                    continue;
                }

                if (number >= 0)
                {
                    numbers.Add(number);
                }

            } while (number >= 0);

            var linqAverage = numbers.Average();
            Console.WriteLine($"Average number is: {linqAverage}");

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            var loopAverage = (double)sum / numbers.Count;
            Console.WriteLine($"Average number using for loop: {loopAverage}");
        }

        /// <summary>
        /// Check if the entered year is a leap.
        /// </summary>
        public static void Task5()
        {
            if (!Helpers.PromptWithValidationInt("Enter the year: ", "Can't parse the year, enter valid year.", out int year))
            {
                return;
            }

            Console.WriteLine($"{year} year is leap: {DateTime.IsLeapYear(year)}");
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
        public static void Homework1()
        {
            string str = "Hello string".ToLower();
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
        public static void Homework2()
        {
            if (!Helpers.PromptWithValidationInt("Enter the number of the month: ", "Can't parse the month number.", out int month))
            {
                return;
            }

            const int january = 1;
            const int december = 12;
            if (month < january || month > december)
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
        public static void Homework3()
        {
            int[] array = new int[10] { 5, 8, 2, 9, 67, 65, 8, 1, 55, 3 };
            //int[] array = new int[10] { 5, -8, 2, 9, 67, 65, 8, 1, 55, 3 };

            int sum = 0;
            bool allPositive = true;
            int half = array.Length / 2;

            for (int i = 0; i < half; i++)
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
                return;
            }

            double product = 1;
            for (int i = half; i < array.Length; i++)
            {
                product *= array[i];
            }
            Console.WriteLine($"The product of last 5 elements is: {product}");
        }
    }
}