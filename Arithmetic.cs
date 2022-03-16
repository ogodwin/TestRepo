using System;

namespace A2_4.Arithmetic
{
    class Program
    {
        static void Main()
        {
            int number1;
            int number2;
            int sum;
            int difference;
            int product;
            int quotient;

            Console.Write("Enter first integer: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;
            difference = number1 - number2;
            product = number1 * number2;
            quotient = number1 / number2;

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Difference = " + difference);
            Console.WriteLine("Product = " + product);
            Console.WriteLine("Quotient = " + quotient);

        }
    }
}
