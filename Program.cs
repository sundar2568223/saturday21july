using System;

namespace BasicCSharpAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1

            //Console.WriteLine("Hello, World!");

            //2

            //Console.WriteLine("What's your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello, {name}!");

            //3

            //Console.WriteLine("Enter the first number:");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the second number:");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //int sum = num1 + num2;
            //int difference = num1 - num2;
            //int product = num1 * num2;

            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Difference: {difference}");
            //Console.WriteLine($"Product: {product}");

            //if (num2 != 0)
            //{
            //    double division = (double)num1 / num2;
            //    double modulus = num1 % num2;

            //    Console.WriteLine($"Division: {division}");
            //    Console.WriteLine($"Modulus: {modulus}");
            //}
            //else
            //{
            //    Console.WriteLine("Cannot divide by zero.");
            //}

            //4

            //Console.WriteLine("Enter a number:");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number >= 0)
            //{
            //    Console.WriteLine($"{number} is Positive.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is Negative.");
            //}

            //5

            //Console.WriteLine("Numbers 1 to 100");
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //6

            //int[] numbers = { 2, 10, 12, 20, 22 };

            //int sum = 0;
            //foreach (int num in numbers)
            //{
            //    sum += num;
            //}

            //double average = (double)sum / numbers.Length;
            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Average: {average}");

            //7

            //    try
            //    {
            //        Console.Write("Enter a positive integer: ");
            //        int number = int.Parse(Console.ReadLine());

            //        if (number < 0)
            //        {
            //            Console.WriteLine("Factorial is not defined for negative numbers.");
            //        }
            //        else
            //        {
            //            long factorial = CalculateFactorial(number);
            //            Console.WriteLine($"Factorial of {number} is: {factorial}");
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid positive integer.");
            //    }
            //}

            //static long CalculateFactorial(int n)
            //{
            //    if (n == 0 || n == 1)
            //    {
            //        return 1;
            //    }
            //    else
            //    {
            //        return n * CalculateFactorial(n - 1);
            //    }
            //}

            //8

            int age = GetValidAgeFromUser();
            DetermineAgeCategory(age);
        }

        static int GetValidAgeFromUser()
        {
            int age;

            while (true)
            {
                Console.Write("Please enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    if (age >= 0)
                    {
                        return age;
                    }
                    else
                    {
                        Console.WriteLine("Age cannot be negative. Please enter a valid age.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for age.");
                }
            }
        }

        static void DetermineAgeCategory(int age)
        {
            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }
        }
    }
}




     