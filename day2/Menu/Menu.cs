using System;
namespace Menu
{
    class Menu
    {
        static void Main()
        {
            char input;
            do 
            {
            Console.WriteLine("Choose A for Ascii \n V for Vice versa Ascii \n M for Multiplication table \n G for Grade Calc \n C for Calculator of two numbers \n E to exit");
            input = Convert.ToChar(Console.ReadLine());

            switch (input)
            {
                case 'A' :
                        int num;
                        Console.WriteLine("Get you Ascii");
                        num = Console.Read();
                        Console.WriteLine(num);
                        break;
                case 'V':
                         Console.WriteLine("Get you Ascii");
                         int numm =int.Parse(Console.ReadLine());
                        char versa = Convert.ToChar(numm);
                        Console.WriteLine(versa);
                    break;
                case 'M':
                    for (int i = 1; i < 10; i++)
                    {
                        for (int g = 1; g < 11; g++)
                        {
                            Console.WriteLine("ixg= {0}", (i * g));
                        }
                    }
                    break;
                case 'G':
                         Console.WriteLine("Enter Your Degree");
                        float numberr = float.Parse(Console.ReadLine());
                        if (numberr < 50)
                        {
                            Console.WriteLine("Not Good Student");
                        }
                        else if (numberr >= 50 && numberr < 65)
                        {
                            Console.WriteLine("Good Student");
                        }
                        else if (numberr > 65 && numberr < 85)
                        {
                            Console.WriteLine("Very Good Student");
                        }
                        else if (numberr > 85 && numberr < 100)
                        {
                            Console.WriteLine("Excellent Student");
                        }
                         else { Console.WriteLine("invalid input"); }
                    break;
                case 'C':
                        Console.WriteLine("Enter First Num");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Second Num");
                        int num2 = int.Parse(Console.ReadLine());
                        int Sum = num1 + num2;
                        int Subtraction = num1 - num2;
                        int Multiplication = num1 * num2;
                         Console.WriteLine(Sum);
                        Console.WriteLine(Subtraction);
                        Console.WriteLine(Multiplication);
                    break;
                case 'E':
                    break;
                default:
                    Console.WriteLine("invalid character");
                    break;

            }
                Console.WriteLine("Enter to continue");
                Console.ReadLine();
            Console.Clear();
            }
            while (input != 'E');
        }
    }
}
