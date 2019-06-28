using System;

namespace Degree
{
    class Grade
    {
        static void Main()
        {
            Console.WriteLine("Enter Your Degree");
            float num = float.Parse(Console.ReadLine());
            if (num < 50)
            {
                Console.WriteLine("Not Good Student");
            }
            else if(num>=50 && num <65)
            {
                Console.WriteLine("Good Student");
            }
            else if (num > 65 && num < 85)
            {
                Console.WriteLine("Very Good Student");
            }
            else if (num > 85 && num < 100)
            {
                Console.WriteLine("Excellent Student");
            }
            else { Console.WriteLine("invalid input"); }
        }
    }
}
