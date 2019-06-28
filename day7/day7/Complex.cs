using System;

namespace Day6
{
    class complex<t>
    {
        public t real { get; set; }
        public t img { get; set; }

        public complex()
        {
            
        }
        public complex(t real, t img )
        {
            this.real = real;
            this.img = img;
        }
        public static complex<t> operator +(complex<t> c1, complex<t> c2)
        {
            complex<int> temp = new complex<int>();
            temp.real = c1.real + c2.real;
            temp.img = c1.img + c2.img;
            return temp;

        }

        public override string ToString()
        {
            return $"{real}+{img}i";
        }
       

    }



    class Program
    {
        static void Main(string[] args)
        {
            complex<int> c = new complex<int>(4,5);
            Console.WriteLine(c.ToString()); 
            complex<int> c2 = new complex<int>(6, 10);
            Console.WriteLine(c2.ToString());

            
        }
    }
}
