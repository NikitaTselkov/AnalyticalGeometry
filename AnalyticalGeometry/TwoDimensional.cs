using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalyticalGeometry
{
    public static class TwoDimensional
    {
        /// <summary>
        /// Находит расстояние между двумя точками.
        /// </summary>
        public static double DistanceBetweenTwoPoints(Point2D point1, Point2D point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
        }

        /// <summary>
        /// Находит угол между отрезком и осью OX в (радианах).
        /// </summary>
        public static double AngleBetweenOxAxisAndSegment(Point2D point1, Point2D point2)
        {
            return Math.Atan(point2.Y - point1.Y) / (point2.X - point1.X);
        }

        /// <summary>
        /// Находит точку делящую отрезок в отношении lambda.
        /// </summary>
        public static Point2D DividingSegmentInGivenRatio(Point2D point1, Point2D point2, double lambda)
        {
            return new Point2D
            {
                X = (point1.X + lambda * point2.X) / (1.0 + lambda),
                Y = (point1.Y + lambda * point2.Y) / (1.0 + lambda)
            };
        }

        /// <summary>
        /// Находит точку середины отрезка.
        /// </summary>
        public static Point2D MidpointOfSegment(Point2D point1, Point2D point2)
        {
            return new Point2D
            {
                X = (point1.X + point2.X) / 2.0,
                Y = (point1.Y + point2.Y) / 2.0
            };
        }

        /// <summary>
        /// Находит площадь треугольника.
        /// </summary>
        public static double AreaOfTriangle(Point2D point1, Point2D point2, Point2D point3)
        {
            double S = (point1.X - point3.X) * (point2.Y - point3.Y) - (point2.X - point3.X) * (point1.Y - point3.Y);

            if (S < 0.0)
            {
                S *= -1.0;
            }

            return (1.0 / 2.0) * S;
        }

        /// <summary>
        /// Если 3 точки лежат на 1 прямой.
        /// </summary>
        public static bool IsThreePointsLieOnOneStraightLine(Point2D point1, Point2D point2, Point2D point3)
        {
            return point1.X * (point2.Y - point3.Y) + point2.X * (point3.Y - point1.Y) + point3.X * (point1.Y - point2.Y) == 0;
        }

        /// <summary>
        /// Находит площадь многоугольника.
        /// </summary>
        public static double AreaOfPolygon(IEnumerable<Point2D> points)
        {
            double sigma = 0;

            Point2D[] _points = points.ToArray();

            for (int i = 0; i < _points.Length; i++)
            {
                if (i == 0)
                {
                    sigma += _points[i].X * (_points[i + 1].Y - _points.Last().Y);
                }
                else if (i + 1 == _points.Length)
                {
                    sigma += _points[i].X * (points.First().Y - _points[i - 1].Y);
                }
                else
                {
                    sigma += _points[i].X * (_points[i + 1].Y - _points[i - 1].Y);
                }
            }

            return (1.0 / 2.0) * sigma;
        }

    }
}
