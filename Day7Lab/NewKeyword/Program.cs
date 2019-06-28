using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKeyword
{
    public class Point
    {
        //props
        public int x { get; set; }
        public int y { get; set; }

        //constructors
        public Point()
        {

        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //copy constructor
        public Point(Point point)
        {
            this.x = point.x;
            this.y = point.y;
        }

        //operators overloading

        // --
        public static Point operator --(Point point)
        {
            point.x -= 1;
            point.y -= 1;

            return point;
        }

        // p=p1-p2
        public static Point operator +(Point p1, Point p2)
        {
            Point temp = new Point();
            temp.x = p1.x + p2.x;
            temp.y = p1.y + p2.y;
            return temp;
        }

        // == 
        public static bool operator ==(Point p1, Point p2)
        {
            if (p1.x == p2.x && p1.y == p2.y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // !=
        public static bool operator !=(Point p1, Point p2)
        {
            if (p1.x != p2.x || p1.y != p2.y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // show method
        public virtual void show()
        {
            Console.WriteLine($"2D point = ({this.x},{this.y})");
        }
    }

    public class ThreeDpoint : Point
    {
        //props 
        public int z { get; set; }

        //constructors
        public ThreeDpoint() : base(0, 0)
        {
            this.z = 0;
        }
        public ThreeDpoint(int z) : base(0, 0)
        {
            this.z = z;
        }
        public ThreeDpoint(int x = 0, int y = 0, int z = 0)
        {
            base.x = x;
            base.y = y;
            this.z = z;
        }

        //show method
        public override void show()
        {
            //base.show();
            Console.WriteLine($"3D point = ({base.x},{base.y},{this.z})");
        }
    }


    public class FourDPoint : Point
    {
        public int z { get; set; }
        public int s { get; set; }

        public FourDPoint(int z, int s):base(0, 0)
        {
            this.z = z;
            this.s = s;
        }

        public new void show()
        {
            Console.WriteLine($"4D point = ({base.x},{base.y},{this.z},{this.s})");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Point p = new Point(1, 2);
            p.show();

            ThreeDpoint _3dPoint = new ThreeDpoint(3);
            _3dPoint.show();

            FourDPoint _4dPoint = new FourDPoint(4, 5);
            _4dPoint.show();

            Point pfrom3D = new ThreeDpoint(6);
            Console.Write("Parent from 3d point ");
            pfrom3D.show();

            Point pFrom4d = new FourDPoint(8, 9);
            Console.Write("Parent from 4d point ");
            pFrom4d.show();


        }
    }
}
