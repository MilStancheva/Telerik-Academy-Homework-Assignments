namespace EuclideanSpace
{
    using System;
    using Models;
    using Extensions;

    public class EuclideanSpaceStartUp
    {
        static void Main()
        {
            var point = new Point3D();
            point.X = 3.3;
            point.Y = 21;
            point.Z = 13.3;

            var secondPoint = new Point3D() { X = 2, Y = 5.5, Z = 8.65 };

            Console.WriteLine(Point3D.StartPointO.ToString());
            Console.WriteLine(point.ToString());
            Console.WriteLine(secondPoint.ToString());

           var distance = Point3DExtensions.CalculateDistanceBetweenTwoPointsIn3D(point, secondPoint);
           Console.WriteLine(distance);

            var path = new Path();

            for (int i = 0; i < 10; i++)
            {
                path.AddPoint(new Point3D() { X = i, Y = i * 2, Z = i + 3 });
            }

            PathStorage.SavePath(path, "../../path.txt");
            var pathFromFile = PathStorage.LoadPath("../../path.txt");

            foreach (var newPoint in pathFromFile)
            {
                Console.WriteLine(newPoint);
            }
        }
    }
}
