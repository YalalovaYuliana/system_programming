using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadOperationLecture
{
    internal class Point
    {


        public int X {  get; set; }
        public int Y { get; set; }

        public Point()
        {
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator ++(Point point)
        {
            ++point.X; ++point.Y; return point;
        }

        public static Point operator --(Point point)
        {
            --point.X; --point.Y; return point;
        }

        public static Point operator -(Point point) => new Point(-1 * point.X, -1 * point.Y);

        public static bool operator ==(Point p1, Point p2) => p1.Equals(p2);
        public static bool operator !=(Point p1, Point p2) => !(p1 == p2);

        public static bool operator >(Point p1, Point p2)
        {
            return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) > Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);
        }

        public static bool operator <(Point p1, Point p2) => !(p1 > p2);

        public override string ToString() => $"Point: X = {X}, y = {Y}";

        public override bool Equals(object obj) => this.ToString() == obj.ToString();

        public override int GetHashCode() => this.ToString().GetHashCode();
    }

    class CPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    struct SPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
