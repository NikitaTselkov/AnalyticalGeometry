using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalGeometry
{
    public class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public bool IsEmpty
        {
            get
            {
                if (X == 0 && Y == 0 && Z == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Point()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format("({0}; {1}; {2})", X, Y, Z);
        }

        public static Point operator +(Point point1, Point point2)
        {
            return new Point
            {
                X = point1.X + point2.X,
                Y = point1.Y + point2.Y,
                Z = point1.Z + point2.Z
            };
        }

        public static Point operator -(Point point1, Point point2)
        {
            return new Point
            {
                X = point1.X - point2.X,
                Y = point1.Y - point2.Y,
                Z = point1.Z - point2.Z
            };
        }

        public static Point operator *(Point point1, Point point2)
        {
            return new Point
            {
                X = point1.X * point2.X,
                Y = point1.Y * point2.Y,
                Z = point1.Z * point2.Z
            };
        }

        public static Point operator /(Point point1, Point point2)
        {
            return new Point
            {
                X = point1.X / point2.X,
                Y = point1.Y / point2.Y,
                Z = point1.Z / point2.Z
            };
        }
    }
}
