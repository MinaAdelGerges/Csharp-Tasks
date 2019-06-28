using System;

namespace Day7Lab
{

    class complex<T>
    {
        public T real { get; set; }
        public T img { get; set; }

        public complex(T real, T img)
        {
            this.real = real;
            this.img = img;
        }

        public override string ToString()
        {
            return $"{real}+{img}i";
        }
        //public static complex<T> operator -(complex<T> c)
        //{
        //    complex<T> temp = new complex<T>(T, T);
        //    temp.real = -c.real;
        //    temp.img = c.img;
        //    return temp;
        //}

        //public static complex<T> operator ++(complex<T> c)
        //{
        //    c.real++;
        //    return c;
        //}

        //public static complex operator +(complex c1, complex c2)
        //{
        //    //complex temp = new complex();
        //    //temp.real = c1.real + c2.real;
        //    //temp.img = c1.img + c2.img;
        //    //return temp;


        //    return new complex(c1.real + c2.real, c1.img + c2.img);

        //}
        //public static bool operator <(complex<T> c1, complex<T> c2)
        //{
        //    if (c1.real < c2.real)
        //    {
        //        return true;
        //    }
        //    else if (c1.real > c2.real)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        if (c1.img < c2.img)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }

        //}

        //public static bool operator >(complex c1, complex c2)
        //{
        //    if (c1.real > c2.real)
        //    {
        //        return true;
        //    }
        //    else if (c1.real < c2.real)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        if (c1.img > c2.img)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }

        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
