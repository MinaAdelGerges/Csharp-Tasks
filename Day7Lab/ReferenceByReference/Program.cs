using System;

namespace ReferenceByReference
{

    class Program
    {


        //by value
        public static void plusValue(int[] x)
        {
            x = new int[3] { 5, 6, 7 };
            x[0] += 1;
            Console.WriteLine("x ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"{x[i]} ");
            }
            Console.WriteLine();
        }

        //by reference
        public static void plusReference(ref int[] x)
        {
            x = new int[3]{5,6,7};
            x[0] += 1;
            Console.WriteLine("x ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"{x[i]} ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] y = {2,4,6};

            

            Console.WriteLine("by value \n old y");
            for (int i = 0; i < y.Length; i++)
            {
                Console.Write($"{y[i]} ");
            }
            Console.WriteLine();
            plusValue(y);
            Console.WriteLine("new y");
            for (int i = 0; i < y.Length; i++)
            {
                Console.Write($"{y[i]} ");
            }
            Console.WriteLine();


            Console.WriteLine("by reference \n old y");
            for (int i = 0; i < y.Length; i++)
            {
                Console.Write($"{y[i]} ");
            }
            Console.WriteLine();
            plusReference(ref y);
            Console.WriteLine("new y");
            for (int i = 0; i < y.Length; i++)
            {
                Console.Write($"{y[i]} ");
            }
            Console.WriteLine();

        }
    }
}
