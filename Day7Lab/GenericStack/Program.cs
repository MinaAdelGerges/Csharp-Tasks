using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    public class Stack<T>
    {
        //props
        public int size { get; set; }
        int tos { get; set; }
        public T[] arr { get; set; }

        //costructors
        public Stack()
        {
            size = 3;
            arr = new T[size];
        }
        public Stack(int size)
        {
            this.size = size;
            arr = new T[size];
        }

        //methods
        public void push(T value)
        {
            if (!isFull())
            {
                arr[tos++] = value;
            }
            else
            {
                Console.WriteLine("array is full \n");
            }
        }

        private bool isFull()
        {
            if (tos >= arr.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T pop()
        {
            if (!isEmpty())
            {
                return arr[--tos];
            }
            else
            {
                Console.WriteLine("array is empty \n");
            }
            return this.arr[0];
        }

        private bool isEmpty()
        {
            if (tos <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //adding 2 stacks
        public Stack<T> add(Stack<T> stc)
        {
            int newSize = arr.Length + stc.arr.Length;
            Stack<T> stack = new Stack<T>(newSize);


            for (int i = 0; i < stc.arr.Length; i++)
            {
                stack.push(stc.arr[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                stack.push(arr[i]);
            }

            return stack;
        }

        //// s++
        //public static Stack operator ++(Stack stc)
        //{
        //    stc.arr[stc.tos - 1]++;
        //    return stc;
        //}

        // s++
        public static Stack<T> operator ++(Stack<T> stc)
        {
            Stack<T> stack = new Stack<T>(stc.arr.Length + 1);
            for (int i = 0; i < stc.arr.Length; i++)
            {
                stack.arr[i] = stc.arr[i];
                stack.tos++;
                //Console.WriteLine(stack.arr[i]);
            }
            //stack.push(T);
            return stack;
        }

        // s--
        public static Stack<T> operator --(Stack<T> stc)
        {
            stc.pop();
            Stack<T> stack = new Stack<T>(stc.arr.Length - 1);
            for (int i = 0; i < stack.arr.Length; i++)
            {
                stack.arr[i] = stc.arr[i];
                //Console.WriteLine(stack.arr[i]);
                //if (stack.arr.Length == stc.arr.Length - 1)
                //{
                //    break;
                //}

            }
            return stack;

            //stc.pop();
            //return stc;
        }

        // s = s1 + s2
        public static Stack<T> operator +(Stack<T> stc1, Stack<T> stc2)
        {
            int newSize = stc1.arr.Length + stc2.arr.Length;
            Stack<T> tempStack = new Stack<T>(newSize);

            for (int i = 0; i < stc1.arr.Length; i++)
            {
                tempStack.push(stc1.arr[i]);
            }

            for (int i = 0; i < stc2.arr.Length; i++)
            {
                tempStack.push(stc2.arr[i]);
            }

            return tempStack;
        }

        // ==
        public static bool operator ==(Stack<T> stc1, Stack<T> stc2)
        {
            if (stc1.arr.Length == stc2.arr.Length)
            {
                int count = 0;
                for (int i = 0; i < stc1.arr.Length; i++)
                {
                    if (stc1.arr[i].Equals(stc2.arr[i]))
                    {
                        count++;
                    }
                }

                if (count == stc1.arr.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        // !=
        public static bool operator !=(Stack<T> stc1, Stack<T> stc2)
        {
            if (stc1.arr.Length != stc2.arr.Length)
            {
                return true;
            }
            else
            {
                int count = 0;
                for (int i = 0; i < stc1.arr.Length; i++)
                {
                    if (!stc1.arr[i].Equals(stc2.arr[i]))
                    {
                        count++;
                    }
                }

                if (count != stc1.arr.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //toString
        public override string ToString()
        {
            Console.WriteLine("the array contents");
            for (int i = 0; i < tos; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("");
            return " ";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Stack<string> st = new Stack<string>(3);
            st.push("ali");
            st.push("ahmed");
            Console.WriteLine("");
            st.ToString();
        }
    }
}
