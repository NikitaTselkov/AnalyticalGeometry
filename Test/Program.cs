using System;
using System.Collections.Generic;
using AnalyticalGeometry;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = new Point2D(1, 2);
            var B = new Point2D(4, 3);
            var C = new Point2D(2, 7);

            Console.WriteLine(TwoDimensional.DistanceBetweenTwoPoints(A, B));
            Console.WriteLine(TwoDimensional.AngleBetweenOxAxisAndSegment(A, B));
            Console.WriteLine(TwoDimensional.DividingSegmentInGivenRatio(A, B, 1.0 / 1.0));
            Console.WriteLine(TwoDimensional.MidpointOfSegment(A, B));
            Console.WriteLine(TwoDimensional.AreaOfTriangle(A, B, C));
            Console.WriteLine(TwoDimensional.IsThreePointsLieOnOneStraightLine(A, B, C));
            Console.WriteLine(TwoDimensional.AreaOfPolygon(new List<Point2D>(new Point2D[] { A, B, C })));
        }
    }
}
