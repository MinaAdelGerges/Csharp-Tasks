using System;

namespace vice_versa
{
    class versa
    {
        static void Main()
        {
            Console.WriteLine("Get you Ascii");
            int number =int.Parse(Console.ReadLine());
            char versa = Convert.ToChar(number);
            Console.WriteLine(versa);
            Console.ReadKey();
        }
    }
}
