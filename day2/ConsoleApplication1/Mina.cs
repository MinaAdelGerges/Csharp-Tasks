using System;

namespace Iti
{
    class Today
    {
        static void Main()
        {
            Console.WriteLine("Enter Your name");
            string mess = Console.ReadLine();
            mess = "Welcome " + mess;
            Console.WriteLine(mess);
            Console.ReadKey();
        }
    }
}
