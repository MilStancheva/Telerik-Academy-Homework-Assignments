//Problem 3. Static class
//Write a static class with a static method to calculate the distance between two points in the 3D space.

namespace EuclideanSpace.Extensions
{
    using Models;
    using System;

    public static class Point3DExtensions
    {

        public static double CalculateDistanceBetweenTwoPointsIn3D (Point3D point1, Point3D point2)
        {
            var distance = Math.Sqrt((point1.X - point2.X) * (point1.X - point2.X) + (point1.Y - point2.Y) * (point1.Y - point2.Y) + (point1.Z - point2.Z) * (point1.Z - point2.Z));

            return distance;
        }

        

    }
}
