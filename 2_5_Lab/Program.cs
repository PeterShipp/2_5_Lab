using System;

namespace _2_5_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int n1, n2;
            Console.WriteLine("Enter a value for the first number:");

            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for the second number:");
            n2 = Convert.ToInt32(Console.ReadLine());

            int result = n1 + n2;
            Console.WriteLine("Sum is " + result);

            int result1 = n1 - n2;
            Console.WriteLine("Difference is " + result1);

            int result2 = n1 * n2;
            Console.WriteLine("Multiply is " + result2);

            int result3 = n1 / n2;
            Console.WriteLine("Divide is " + result3);

           

            



        }
    }
}
