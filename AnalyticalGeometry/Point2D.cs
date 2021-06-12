using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalGeometry
{
    public class Point2D
    {
        public double X { get; set; }

        public double Y { get; set; }

        public bool IsEmpty
        {
            get
            {
                if (X == 0 && Y == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Point2D()
        {
            X = 0;
            Y = 0;
        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format("({0}; {1})", X, Y);
        }

        public static Point2D operator +(Point2D point1, Point2D point2)
        {
            return new Point2D
            {
                X = point1.X + point2.X,
                Y = point1.Y + point2.Y
            };
        }

        public static Point2D operator -(Point2D point1, Point2D point2)
        {
            return new Point2D
            {
                X = point1.X - point2.X,
                Y = point1.Y - point2.Y
            };
        }

        public static Point2D operator *(Point2D point1, Point2D point2)
        {
            return new Point2D
            {
                X = point1.X * point2.X,
                Y = point1.Y * point2.Y
            };
        }

        public static Point2D operator /(Point2D point1, Point2D point2)
        {
            return new Point2D
            {
                X = point1.X / point2.X,
                Y = point1.Y / point2.Y
            };
        }
    }
}
