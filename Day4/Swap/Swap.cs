using System;

namespace Swap
{
    struct Test
        {  
        public void swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
    class Swap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number To Swap");
            int Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number To Swap");
            int Num2 = int.Parse(Console.ReadLine());

            Test t1 = new Test();
            t1.swap(ref Num1, ref Num2);
            Console.WriteLine($"Number after swaping Num1: {Num1} Num2: {Num2}");
        }
    }
}
