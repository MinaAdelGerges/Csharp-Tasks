using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Math
    {
        public Math(int x, int y)
        {
            Console.WriteLine($"The sum of Two numbers is {x+y} the Div of Two Numbers is : {x/y} the Sub of two number is : {x-y} the Mul of two numbers is {x*y}");
        }

        //public int Sum(int x, int y)
        //{
        //    int sum = x + y;
        //    return sum;
        //}
        //public int Sub(int x, int y)
        //{
        //    int sub = x - y;
        //    return sub;
        //}
        //public float Div(int x, int y)
        //{
        //    float div = x / y;
        //    return div;
        //}
        //public int Mul(int x, int y)
        //{
        //    int mul = x * y;
        //    return mul;
        //}
    }
    class Test2
    {
        static void Main(string[] args)
        {
            //int x;
            //int y;
            Console.WriteLine("Enter Number 1");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            int numberTwo = int.Parse(Console.ReadLine());
            Math math1 = new Math(numberOne,numberTwo);




            //Console.WriteLine($"Sum :{math1.Sum(numberOne,numberTwo)} Sub: {math1.Sub(numberOne,numberTwo)} Div: {math1.Div(numberOne,numberTwo)} Mul: {math1.Mul(numberOne,numberTwo)}");
        }
    }
}
