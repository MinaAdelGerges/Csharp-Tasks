using System;
namespace Average
{
    class Average
    {
        static void Main()
        {
            Console.WriteLine("Enter num of subject");
            int num=  int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Degree");
            float Dg = float.Parse(Console.ReadLine());
            Console.WriteLine((Dg/num)+ "%");
            Console.ReadKey();
        }
    }
}