//Problem 4. Path
//Create a class Path to hold a sequence of points in the 3D space.

namespace EuclideanSpace.Models
{
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Path is a group of points in a sequence
    /// </summary>

    public class Path: IEnumerable<Point3D>
    {
        private ICollection<Point3D> points; 

        public Path()
        {
            this.points = new HashSet<Point3D>();
        }
        
        public void AddPoint (Point3D point)
        {
            this.points.Add(point);
        }
              

        public void RemovePoint (Point3D point)
        {
            this.points.Remove(point);
        }

        public override string ToString()
        {
            return string.Join(" \n", this.points);
        }

        public IEnumerator<Point3D> GetEnumerator()
        {
            return this.points.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
