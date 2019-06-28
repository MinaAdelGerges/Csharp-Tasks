using System;


namespace Stack
{
    class stack
    {

        public int size { get; set; }
        public int[] arr { get; set; }
        public int tos { get; set; }
        public stack()
        {
            size = 10;
            arr = new int [size];
            tos = 0;
        }

        public stack(int size)
        {
            this.size = size;
            arr = new int[size];
            tos = 0;
        }

        public stack(stack s)
        {
            this.size = s.size;
            this.tos = s.tos;
            this.arr = new int[s.arr.Length];
            for (int i = 0; i < s.tos; i++)
            {
                this.arr[i] = s.arr[i];
            }
        }

        public void push(int item)
        {
            if (tos < size)
            {
                arr[tos++] = item;
            }
        }

        public static stack operator +(stack s, stack s2)
        {
            stack temp = new stack();

            temp.size = s.size + s2.size;
            temp.tos = s.tos + s2.tos;

            return temp;

        }

        public int pop()
        {
            if (tos > 0)
            {
                return arr[--tos];
            }
            return arr[tos]; ;
        }

        public override string ToString()
        {
            string items = "";
            for (int i = 0; i < tos; i++)
            {
                items += arr[i].ToString() + ",";
            }
            return items;
        }


        }
        class Stack
    {
        static void Main(string[] args)
        {

            stack s = new stack(5);
            s.push(4);
            s.push(3);
            
            stack s2 = new stack(4);
            s2.push(7);
            s2.push(9);
            
            stack s3 = s2 + s; 
            
            
            Console.WriteLine(s3.ToString());  
            
            
            //s.push("5");
            //s.push("6");
            //s.push("7");
            //Console.WriteLine(s.ToString());

            //s.pop();


            //Console.WriteLine(s.ToString());

            
            


            //stack s = new stack(5);
            //s.push(2);
            //s.push(4);
            //s.push(5);

            //stack s2 = new stack(s);


            //s2.push(7);
            // Console.WriteLine(s.pop());
            //  Console.WriteLine(s.ToString());
            // Console.WriteLine(s2.ToString());

        }
    }
}
