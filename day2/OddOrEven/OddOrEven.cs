using System;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            Console.WriteLine("Enter A Number");
            int x =int.Parse(Console.ReadLine());
            if (x % 2 == 0) 
            {
                Console.WriteLine("Even Number");
            }
            else if(x%2!=0)
            {
                Console.WriteLine("Odd Number");
            };
            Console.ReadKey();
        }
    }
}
