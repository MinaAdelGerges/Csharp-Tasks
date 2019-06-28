using System;


namespace Day3
{
    class arrayOfIntegers
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            int Avg = 0;
            Console.WriteLine("Enter size of array");
            int size = int.Parse(Console.ReadLine());
            int[] arrIntegers = new int[size];
            for (int i = 0; i < arrIntegers.Length; i++)
            {
                Console.WriteLine($"Enter Num{i+1}");
                int nums = int.Parse(Console.ReadLine());
                arrIntegers[i] = nums;
            }
            for (int g = 0; g < arrIntegers.Length; g++)
            {
                Sum += arrIntegers[g];
                Avg = Sum/2;
            }
            Console.WriteLine(Sum);
            Console.WriteLine(Avg);
        }
    }
}
