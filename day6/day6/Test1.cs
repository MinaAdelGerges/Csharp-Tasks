using System;


namespace day6
{   
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //public Point(Point P)
        //{
        //    this.x = P.x;
        //    this.y = P.y;
        //}
        public override string ToString()
        {
            return $"{x}+{y}i";
        }
        
        public static Point operator --(Point p)
        {
            p.x--;
            p.y--;

            return p;
            
        }
        public static Point operator -(Point p, Point p1)
        {

            Point temp;
            temp = new Point();
            temp.x = p.x - p1.x;
            temp.y = p.y - p1.y;
            return temp; 

            
        }
        public static bool operator ==(Point p, Point p1)
        {

            if (p.x==p1.x || p.y==p1.y)
            {
                return true;
            }
            else { Console.WriteLine("False"); }
            return false;
        }

        public static bool operator !=(Point p, Point p1)
        {

            if (p.x != p1.x || p.y != p1.y)
            {
                return true;
            }
            else { Console.WriteLine("False") }
            return false;
        }




    }

    class three_D : Point
        {
            public int x { get; set; }
            public int y { get; set; }
            public int z { get; set; }
            public void Show()
            {
                
            }
        }
    
    class Test1
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2,4);
            Point p2 = new Point(2, 4);
            if (p1 == p2)
            {
                Console.WriteLine("tttt");
            }
            else { Console.WriteLine("ffff"); }
            
            
            
        }
    }
}
