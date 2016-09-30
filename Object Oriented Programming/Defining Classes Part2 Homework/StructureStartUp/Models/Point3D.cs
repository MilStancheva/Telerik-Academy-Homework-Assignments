//Problem 1. Structure
//Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
//Implement the ToString() to enable printing a 3D point.

//Problem 2. Static read-only field
//Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
//Add a static property to return the point O.

using System;
using System.Linq;

namespace EuclideanSpace.Models
{
      public struct Point3D
    {
        //Adding a start point O - static read-only
        private static readonly Point3D startPointO = new Point3D() { X = 0, Y = 0, Z = 0};

        //constructor of the 3D Point
        public Point3D(double x, double y, double z) :this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;

        }

        //properties of the 3D point

        //property of the static field startPointO
        public static Point3D StartPointO
        {
            get { return startPointO; }
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        //Method to get the coordinates of the point
        public override string ToString()
        {
            return string.Format("Point ({0}, {1}, {2})", this.X, this.Y, this.Z);

        }

        //Parsing the point coordinates (problem 4)
        public static Point3D Parse(string text)
        {
            int openPar = text.IndexOf('(');
            double[] coord = text.Substring(openPar + 1, text.Length - openPar - 2)
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .ToArray();

            return new Point3D() { X = coord[0], Y = coord[1], Z = coord[2] };
        }
    }
}
