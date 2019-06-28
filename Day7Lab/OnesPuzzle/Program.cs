using System;

namespace OnesPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[32];
            int count = 0;
            int input = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToString(++input);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains("1"))
                {
                    count++;
                    if (arr[i].Contains("11"))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"this array has {count} ones");
        }
    }
}
