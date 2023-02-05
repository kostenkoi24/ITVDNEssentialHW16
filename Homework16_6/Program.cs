using System;

namespace Homework16_6
{

    struct Point
    {
        int x, y, z;

        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point operator +(Point p1, Point p2) => new Point(p1.x + p2.x, p1.y + p2.y, p1.z + p2.z);

        public void ShowPoint()
        {
            Console.WriteLine($"{x}:{y}:{z}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(10, 20, 30);

            Point p2 = p1 + p1;

            p1.ShowPoint();
            p2.ShowPoint();

            Console.ReadKey();
        }
    }
}
