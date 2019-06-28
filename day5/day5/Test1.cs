using System;

namespace day5
{
    class Stack
    {

        public int size = 0;
        public int topOfStack;
        public int[] arr;

        public Stack()
        {
            size = 10;
            arr = new int[size];
            topOfStack = 0;
            
        }
        public Stack(int _size)
        {

            size = _size;
            arr = new int[_size];
            topOfStack = 0;
        }
        public void Push( int _val)
        {
            
            if (topOfStack==0)
            {
                arr[topOfStack] = _val;
                topOfStack++;
                arr[topOfStack] = _val;
            }
        }
        public int Pop()
        {

            
            if (topOfStack<=size) {

                topOfStack--;
            }
            return arr[topOfStack];
        }
    }

    class Test1
    {
        static void Main(string[] args)
        {

            Stack stack1 = new Stack();
            Console.WriteLine("Stack With Constactor Enter where to put value in size 10 stack: ");
            int whereValue3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Stack With Constactor Enter where to put value in size 10 stack: ");
            int whereValue4 = int.Parse(Console.ReadLine());
            stack1.Push(whereValue3);
            stack1.Push(whereValue4);

            Console.WriteLine(stack1.Pop());


            //Console.WriteLine("Stack Without Constractor Enter size of Stack: ");
            //int userSize = int.Parse(Console.ReadLine());
            //Stack stack2 = new Stack(userSize);


            //Console.WriteLine("Enter value to input: ");
            //int inputValue1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter value to input: ");
            //int inputValue2 = int.Parse(Console.ReadLine());
            //stack2.Push(inputValue1);
            //stack2.Push(inputValue2);
            //Console.WriteLine(stack2.Pop());

        }
    }
}
