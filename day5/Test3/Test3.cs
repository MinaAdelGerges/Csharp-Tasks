using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{   
    static class Math
    {
        public static void math(int x, int y, out int sum, out float div,out int sub, out int mul)
        {
            sum = x + y;
            sub = x - y;
            mul = x * y;
            div = x / y;
        }
    }
    
    class Test3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1: ");
            int numberOne=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            int numberTwo = int.Parse(Console.ReadLine());
            int x, z, l;
            float y;
            Math.math(numberOne, numberTwo, out x, out y, out z,out l);
            Console.WriteLine($"sum:{x} ,div: {y},sub:{z},mul:{l}");

        }
    }
}
