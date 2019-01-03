using System;

namespace VC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Int32.Parse(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine(result);
        }
    }
}
