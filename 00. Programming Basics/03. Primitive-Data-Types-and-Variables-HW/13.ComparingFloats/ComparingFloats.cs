//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps. 

using System;

    class ComparingFloats
    {
        static void Main()
        {
            Console.WriteLine("Compare floating-point numbers with precision 0.000001");
            Console.Write("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            double eps = 0.000001d;
            bool isEqual = true;

            if (Math.Abs(firstNumber - secondNumber) > eps)
            {
                isEqual = false;
                Console.WriteLine("Is the first number equals to the second number: {0}", isEqual);
            }
            else
            {
                Console.WriteLine("Is the first number equals to the second number: {0}", isEqual);
            }
        }
    }
