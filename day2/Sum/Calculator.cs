using System;
namespace Sum
{
    class Calculator
    {
        static void Main()
        {
            
            
            Console.WriteLine("Enter First Num");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second num");
            int num2 = int.Parse(Console.ReadLine());
            int Sum = num1 + num2;
            int Subtraction = num1 - num2;
            int Multiplication = num1 * num2;
             Console.WriteLine(Sum);
            Console.WriteLine(Subtraction);
            Console.WriteLine(Multiplication);
            
        }
    }
}
